using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomCombobox : ComboBox
{
    public CustomCombobox()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        int radius = 15;
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(Width - radius, 0, radius, radius, 270, 90);
        path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
        path.AddArc(0, Height - radius, radius, radius, 90, 90);
        path.CloseFigure();

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
            e.Graphics.FillPath(brush, path);
        }

        using (Pen pen = new Pen(this.ForeColor, 2))
        {
            e.Graphics.DrawPath(pen, path);
        }
    }
}
