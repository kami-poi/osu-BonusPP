namespace BonusPP;

/// <summary>
///  A class that follows the
/// same structure as the 
/// JSON representation for
/// a user returned by the 
/// osu!API.
/// </summary>
public class User
{
    /**
     * The visible total amount of
     * PP this user has, so this includes
     * bonus PP
     */
    public double PpRaw { get; set; }

    /**
     * Number of SS scores this user has
     */
    public int CountRankSs { get; set; }

    /**
     * Number of SSH or XH scores this user has
     */
    public int CountRankSsh { get; set; }

    /**
     * Number of S scores this user has
     */
    public int CountRankS { get; set; }

    /**
     * Number of SH or X scores this user has
     */
    public int CountRankSh { get; set; }

    /**
     * Number of A scores this user has
     */
    public int CountRankA { get; set; }

    /**
     * Total playcount for this user
     */
    public int Playcount { get; set; }

    public User(double ppRaw)
    {
        PpRaw = ppRaw;
    }

    /// <summary>
    /// Gets the total amount of visible scores for
    /// this user. This is the sum of the number A,
    /// S, SS, SH and SSH ranks.
    /// </summary>
    /// <returns>The total number of visible scores for this user.</returns>
    public int ScoreCount()
    {
        return CountRankA + CountRankS + CountRankSh + CountRankSs + CountRankSsh;
    }
}