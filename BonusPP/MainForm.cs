using System.Diagnostics;

namespace BonusPP;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        Task.Run(async () =>
        {
            var version = await CheckVersion();
            ver.Text = $"Version: v1.0, latest version: {version ?? "unknown"}";
        });
    }

    private void git_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        try
        {
            git.LinkVisited = true;
            Process.Start(new ProcessStartInfo("https://github.com/kami-poi/osu-BonusPP")
            { UseShellExecute = true });
        }
        catch
        {
            MessageBox.Show("Unable to open link.");
        }
    }

    /// <summary>
    /// Checks the BonusPP version to see if we are running the latest version.
    /// </summary>
    /// <returns>The latest version</returns>
    private static async Task<string?> CheckVersion()
    {
        try
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.github.com");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github.v3+json");
            client.Timeout = TimeSpan.FromSeconds(10);
            var line = await client.GetStringAsync("repos/kami-poi/osu-BonusPP/tags");
            var versions = line.Split("\"name\":\"v");
            var maxMain = 1;
            var maxSub = 0;
            string[] tmp;
            for (var i = 1; i < versions.Length; i++)
            {
                tmp = versions[i].Split("\",\"")[0].Split("\\.");
                if (int.Parse(tmp[0]) > maxMain)
                {
                    maxMain = int.Parse(tmp[0]);
                    maxSub = int.Parse(tmp[1]);
                }
                else if (int.Parse(tmp[0]) < maxMain)
                {
                    continue;
                }
                else
                {
                    if (int.Parse(tmp[1]) > maxSub)
                    {
                        maxSub = int.Parse(tmp[1]);
                    }
                }
            }

            return "v" + maxMain + "." + maxSub;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    private void cancel_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }

    private void ok_Click(object sender, EventArgs e)
    {
        var resultForm = new ResultForm(modes.SelectedIndex.ToString(),name.Text,api.Text,modes.Text);

        resultForm.ShowDialog();
    }
}