using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton kryptonCheckButton1;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.kryptonCheckButton1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.SuspendLayout();
            // 
            // kryptonCheckButton1
            // 
            this.kryptonCheckButton1.Location = new System.Drawing.Point(128, 171);
            this.kryptonCheckButton1.Name = "kryptonCheckButton1";
            this.kryptonCheckButton1.Size = new System.Drawing.Size(462, 169);
            this.kryptonCheckButton1.TabIndex = 0;
            this.kryptonCheckButton1.Values.Text = "kryptonCheckButton1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(727, 509);
            this.Controls.Add(this.kryptonCheckButton1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
