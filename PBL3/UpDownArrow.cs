using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.IO;

namespace WindowsFormsApp1.Controls
{
    public class UpDownArrow : CheckBox
    {
        //Fields
        private Color backColor = Color.Red;
        private Color arrowColor = Color.WhiteSmoke;

        //Properties
        public Color BackColor1
        {
            get => backColor; 
            set
            {
                backColor = value;
                this.Invalidate();
            }
        }
        public Color ArrowColor 
        {
            get => arrowColor; 
            set
            {
                arrowColor = value;
                this.Invalidate();
            }
        }

        public override string Text 
        {
            get => base.Text;
            set
            {

            }
        }

        //Constructor
        public UpDownArrow()
        {
            this.MinimumSize = new Size(30, 30);
            this.Size = new Size(30, 30);
        }

        private GraphicsPath GetFigurePath()
        {
            Rectangle rectangle = new Rectangle(0, 0, 30, 30);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddLine(new Point(rectangle.X, rectangle.Y), new Point(rectangle.X, rectangle.Y));
            path.AddLine(new Point(rectangle.X + rectangle.Width, rectangle.Y), new Point(rectangle.X + rectangle.Width, rectangle.Y));
            path.AddLine(new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height), new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height));
            path.AddLine(new Point(rectangle.X, rectangle.Y + rectangle.Height), new Point(rectangle.X, rectangle.Y + rectangle.Height));
            path.CloseFigure();
            return path;
        }
        private GraphicsPath GetUpArrowPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddLine(new Point(8, 16), new Point(12, 12));
            path.AddLine(new Point(12, 12), new Point(16, 16));
            path.AddLine(new Point(16, 16), new Point(20, 12));
            path.AddLine(new Point(20, 12), new Point(12, 8));
            path.AddLine(new Point(12, 8), new Point(4, 12));
            path.AddLine(new Point(4, 12), new Point(8, 16));
            path.CloseFigure();
            return path;
        }
        private GraphicsPath GetDownArrowPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddLine(new Point(8, 8), new Point(12, 12));
            path.AddLine(new Point(12, 12), new Point(16, 8));
            path.AddLine(new Point(16, 8), new Point(20, 12));
            path.AddLine(new Point(20, 12), new Point(12, 16));
            path.AddLine(new Point(12, 16), new Point(4, 12));
            path.AddLine(new Point(4, 12), new Point(8, 8));
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);
            pevent.Graphics.FillPath(new SolidBrush(backColor), GetFigurePath());
            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(arrowColor), GetUpArrowPath());
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(arrowColor), GetDownArrowPath());
            }
        }
    }
}
