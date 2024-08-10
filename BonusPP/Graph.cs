using System.ComponentModel;

namespace BonusPP;

public class Graph : Panel
{
    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Always)]
    public Score[] Scores { get; set; } = [];

    /// <inheritdoc />
    protected override Size DefaultSize => new(0, 100);

    /// <inheritdoc />
    protected override void OnPaint(PaintEventArgs e)
    {
        if (Scores.Length == 0) return;
        base.OnPaint(e);

        double w = this.Width;
        double h = this.Height;
        var maxpp = Scores[0].Pp;

        var dx = w / Scores.Length;
        var dy = h / (maxpp + 2);

        var g = e.Graphics;
        var bluePen = new Pen(Color.Blue);
        var greenPen = new Pen(Color.Green);
        for (var i = 0; i < Scores.Length; i++)
        {
            g.DrawEllipse(bluePen, (int)(i * dx), (int)(h - dy * (Scores[i].Pp + 2)), 2, 2);
            g.DrawEllipse(greenPen, (int)(i * dx), (int)(h - dy * (Scores[i].Pp * Math.Pow(0.95D, i) + 2)), 2, 2);
        }

        g.DrawString("Raw PP", this.Font, Brushes.Blue, (int)(Scores.Length / 2.0D * dx),
            (int)(h - dy * (Scores[(int)(Scores.Length / 2.0D)].Pp + 2)) - 15);
        g.DrawString("Weighted PP", this.Font, Brushes.DarkGreen, (int)(Scores.Length / 2.0D * dx),
            (int)(h - dy * (Scores[(int)(Scores.Length / 2.0D)].Pp * Math.Pow(0.95D, Scores.Length / 2.0D) + 2)) - 15);
    }
}