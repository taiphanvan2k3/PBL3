using System;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_DailySchoolSchedule : UserControl
    {
        public UC_DailySchoolSchedule()
        {
            InitializeComponent();
        }
        private void lblShowDateTime_Click(object sender, EventArgs e)
        {
            dateTimePicker.Select();
            SendKeys.Send("%{Down}");
        }

        private string GetDayOfWeek(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Sunday)
                return "CN -";
            DayOfWeek[] ds = { DayOfWeek.Sunday,DayOfWeek.Sunday,DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday,
                                DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday };
            string res = null;
            for (int i = 2; i <= 7; i++)
            {
                if (dt.DayOfWeek == ds[i])
                    res = "T" + i + " -";
            }
            return res;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker.Value;
            lblShowDateTime.Text = GetDayOfWeek(date) + " " + dateTimePicker.Value.ToShortDateString();
        }

        private void btnXemLich_Click(object sender, EventArgs e)
        {
            Panel pnl = Parent as Panel;
            MessageBox.Show(pnl.Width + "");
        }
    }
}
