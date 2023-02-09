using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace WindowsFormsApp1.Controls
{
    public class ToggleButton : CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        //Properties
        [Category("Dinh Manh")]
        public Color OnBackColor 
        { 
            get => onBackColor; 
            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }
        public Color OnToggleColor
        { 
            get => onToggleColor;
            set
            {
                onToggleColor = value;
                this.Invalidate();
            }
        }
        public Color OffBackColor 
        { 
            get => offBackColor; 
            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }
        public Color OffToggleColor 
        {
            get => offToggleColor; 
            set
            {
                offToggleColor = value;
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

        [DefaultValue(true)]
        public bool SolidStyle 
        {
            get => solidStyle; 
            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        //Constructor
        public ToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            //Vòng cung
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);
            GraphicsPath path = new GraphicsPath();
            //Vẽ hình vòng cung ở rectangle bên trái quét từ góc 90 độ xoay 1 vòng 180 độ( trục 90 độ ở đây là trục y chiều dương theo Oxy ở vật lí c3
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();
            
            
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //Clear be mat de to mau
            pevent.Graphics.Clear(this.Parent.BackColor);

            if(this.Checked)//ON
            {
                //Vẽ bề mặt control
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(onBackColor), GetFigurePath()); 
                //Vẽ toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                //Vẽ bề mặt control
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else
                    pevent.Graphics.DrawPath(new Pen(offBackColor), GetFigurePath());
                //Vẽ toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
