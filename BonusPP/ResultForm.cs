using System.Globalization;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BonusPP;

public partial class ResultForm : Form
{
    private readonly string _modeIndex;
    private readonly string _mode;
    private readonly string _user;
    private readonly string _apiKey;

    private static readonly HttpClient Client = new();

    private static readonly JsonSerializerOptions Option = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        PropertyNameCaseInsensitive = true,
        NumberHandling = JsonNumberHandling.AllowReadingFromString
    };

    static ResultForm()
    {
        Client.BaseAddress = new Uri("https://osu.ppy.sh");
        Client.Timeout = TimeSpan.FromSeconds(10);
    }

    public ResultForm(string modeIndex, string user, string apiKey, string mode)
    {
        _modeIndex = modeIndex;
        _user = user;
        _apiKey = apiKey;
        _mode = mode;
        InitializeComponent();
    }

    private void ResultForm_Load(object sender, EventArgs e)
    {
        var loadBestScoreTask = LoadBestScores();
        var loadUserTask = LoadUser();

        Task.WaitAll(loadBestScoreTask, loadUserTask);
        if (!loadBestScoreTask.IsCompletedSuccessfully || loadBestScoreTask.Result == null)
        {
            MessageBox.Show(
                $"The requested user has not played the {_mode} game mode yet.\n(so there is nothing to compute)");
            Close();
            return;
        }

        if (!loadUserTask.IsCompletedSuccessfully || loadUserTask.Result == null)
        {
            MessageBox.Show("No user with the given username exists or the given API key is not valid.");
            Close();
            return;
        }

        var scores = loadBestScoreTask.Result;
        var user = loadUserTask.Result;

        var totalPp = user.PpRaw;
        if (totalPp == 0.0D)
        {
            MessageBox.Show(
                $"The requested user has not played {_mode} for a while.\nBecause of this their total pp appears as 0 which means their bonus pp cannot be computed.");
            Close();
            return;
        }

        var scorepp = CalculateScorePp(scores, user);
        var bonuspp = totalPp - scorepp;

        msg.Text = $"{_user}({_mode})";
        var max = user.ScoreCount() >= 1000 || bonuspp >= 416.6667;

        if (max)
        {
            bonusPP.Text = $"416.6667 (max, predicted:{Math.Round(bonuspp).ToString(CultureInfo.InvariantCulture)})";
        }
        else
        {
            bonusPP.Text = Math.Round(bonuspp).ToString(CultureInfo.InvariantCulture);
        }

        totalPP.Text = Math.Round(totalPp).ToString(CultureInfo.InvariantCulture);
        totalPpWithoutBonus.Text = Math.Round(scorepp).ToString(CultureInfo.InvariantCulture);
        rankedScoreNum.Text =
            max
                ? Math.Max(user.ScoreCount(), 1000) + "+"
                : ((int)Math.Round(Math.Log10(-(bonuspp / 416.6667D) + 1.0D) / Math.Log10(0.9994D))).ToString();

        graphPanel.Scores = scores.ToArray();
    }

    private async Task<IEnumerable<Score>?> LoadBestScores()
    {
        try
        {
            return await Client.GetFromJsonAsync<IEnumerable<Score>>(
                $"api/get_user_best?k={_apiKey}&u={_user}&limit=100&type=string&m={_modeIndex}", Option).ConfigureAwait(false);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    private async Task<User?> LoadUser()
    {
        try
        {
            return (await Client.GetFromJsonAsync<IEnumerable<User>>(
                $"api/get_user?k={_apiKey}&u={_user}&type=string&m={_modeIndex}", Option).ConfigureAwait(false))?.FirstOrDefault();
        }
        catch (Exception e)
        {
            return null;
        }
    }

    /// <summary>
    /// Calculates the amount of non-bonus PP a player has. This is done by adding together all the scores from the
    /// player's top 100 and by using regression to account for scores that are not part of the top 100. (Everything
    /// is weighted of course)
    /// </summary>
    /// <param name="scores">A list of the player's top 100 scores.</param>
    /// <param name="user">Data about the player itself.</param>
    /// <returns>The amount of non-bonus PP this player has.</returns>
    private static double CalculateScorePp(IEnumerable<Score> scores, User user)
    {
        var i = 0;
        var scorepp = scores.Sum(score => score.Pp * Math.Pow(0.95, i++));
        return scorepp + ExtraPolatePpRemainder(scores, user);
    }

    /// <summary>
    /// Calculates the amount of PP a player has from non-top-100 scores. Especially for a top player this can be a
    /// significant amount. If the player has less then 100 top scores this method returns 0.
    /// </summary>
    /// <param name="scores">A list of the player's top scores.</param>
    /// <param name="user">Data about the player itself.</param>
    /// <returns>The amount of PP the player has from non-top-100 scores.</returns>
    private static double ExtraPolatePpRemainder(IEnumerable<Score> scores, User user)
    {
        if (scores.Count() < 100)
        {
            return 0.0D;
        }

        //Data transformation
        Span<double> ys = stackalloc double[scores.Count()];
        var i = 0;
        foreach (var score in scores)
        {
            ys[i] = Math.Log10(score.Pp * Math.Pow(0.95, i)) / Math.Log10(100);
            i++;
        }

        var (b0, b1) = CalculateLinearRegression(ys);
        var pp = 0.0D;
        for (double n = 100; n <= user.Playcount; n++)
        {
            var val = Math.Pow(100.0D, b0 + b1 * n);
            if (val <= 0.0D)
            {
                break;
            }

            pp += val;
        }

        return pp;
    }

    /// <summary>
    ///  Computes a weighted linear regression equation from the given data set.
    /// <code>
    /// The following formulas are used:
    /// B1 = Ox,y / Ox^2
    /// B0 = Uy - B1 * Ux
    /// Ox,y = (1/N) * 'sigma(N,i=1)'((Xi - Ux)(Yi - Uy))
    /// Ox^2 = (1/N) * 'sigma(N,i=1)'((Xi - U)^2)
    /// </code>
    /// </summary>
    /// <param name="ys">The data set to make a regression model for.</param>
    /// <returns>The linear regression equation, or more specific this method returns <tt>b0</tt> and <tt>b1</tt>
    /// these two values can be used to form anequation of the following form <tt>y = b0 + b1 * x</tt>.
    /// </returns>
    private static (double, double) CalculateLinearRegression(Span<double> ys)
    {
        var sumOxy = 0.0D;
        var sumOx2 = 0.0D;
        var avgX = 0.0D;
        var avgY = 0.0D;
        var sumX = 0.0D;
        for (var n = 1; n <= ys.Length; n++)
        {
            var weight = Math.Log(n + 2.0D);
            sumX += weight;
            avgX += n * weight;
            avgY += ys[n - 1] * weight;
        }

        avgX /= sumX;
        avgY /= sumX;
        for (var n = 1; n <= ys.Length; n++)
        {
            sumOxy += (n - avgX) * (ys[n - 1] - avgY) * Math.Log(n + 2.0D);
            sumOx2 += Math.Pow(n - avgX, 2.0D) * Math.Log(n + 2.0D);
        }

        var oxy = sumOxy / sumX;
        var ox2 = sumOx2 / sumX;
        return (avgY - (oxy / ox2) * avgX, oxy / ox2);
    }
}