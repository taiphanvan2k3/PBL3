using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_Day : UserControl
    {
        public UC_Day()
        {
            InitializeComponent();
        }
        #region Properties
        public string Day
        {
            get => btnDay.Text; 
            set => btnDay.Text = value;
        }
        public Color BoderDay
        {
            get => btnDay.BorderColor;
            set => btnDay.BorderColor = value;
        }
        public Color ColorDay
        {
            get => btnDay.BackColor;
            set => btnDay.BackColor = value;
        }
        public Color ColorTextDay
        {
            get => btnDay.ForeColor;
            set => btnDay.ForeColor = value;
        }
        public string Exam
        {
            get => lbExam.Text;
            set => lbExam.Text = value;
        }
        public string IfMore
        {
            get => lbIfMore.Text; 
            set => lbIfMore.Text = value;
        }
        public Color PanelEventColor
        {
            get => pblEvent.BackColor;
            set => pblEvent.BackColor = value;
        }
        #endregion
    }
}
