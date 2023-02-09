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
    public class BoxCalendar : Panel
    {
        //Fields
        private Color titleForeColor = Color.White;
        private Color componentBackColor = Color.WhiteSmoke;
        private Color componentForeColor = Color.Black;
        private Label title;
        private Label componentLabel;
        private UpDownArrow upDownArrow;
        private Label endPanel;

        //Properties
        public Color TitleForeColor 
        { 
            get => titleForeColor;
            set
            {
                titleForeColor = value;
                this.Invalidate();
            }
        }
        public Color ComponentBackColor
        { 
            get => componentBackColor;
            set
            {
                componentBackColor = value;
                this.Invalidate();
            }
        }
        public Color ComponentForeColor 
        { 
            get => componentForeColor;
            set
            {
                componentForeColor = value;
                this.Invalidate();
            }
        }

        //Constructor
        public BoxCalendar()
        {
            this.MinimumSize = new Size(220, 100);
            this.Controls.Add(title);
            title = new Label() { Text = "Thi OOP" };
            title.Location = new Point(3, 5);
            title.ForeColor = titleForeColor;
            title.Font = new Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(upDownArrow);
            upDownArrow = new UpDownArrow();
            upDownArrow.Location = new Point(190, 4);
            upDownArrow.CheckedChanged += UpDownArrow_CheckedChanged;
            componentLabel = new Label() { Text = "Nhóm: 21Nh10, 21Nh11, 21Nh12, \n21Nh13" };
            componentLabel.AutoSize = true;
            componentLabel.Location = new Point(3, 105);
            componentLabel.Size = new Size(this.Width - 6, 20);
            componentLabel.ForeColor = componentForeColor;
            componentLabel.BackColor = componentBackColor;
            endPanel = new Label();
            this.Controls.Add(title);
            this.Controls.Add(upDownArrow);
            this.BackColor = Color.Red;
        }


        //Methods

        //Events
        private void UpDownArrow_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if(cb.Checked) 
            {
                this.Controls.Add(componentLabel);
                endPanel.Location = new Point(3, this.Height - 3);
                this.Controls.Add(endPanel);
            }
            else 
            {
                this.Controls.Remove(componentLabel);
                this.Controls.Remove(endPanel);
            }
            MessageBox.Show(this.Width.ToString());
        }
    }
}
