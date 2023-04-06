using System;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_WeeklySchoolSchedule : UserControl
    {
        public UC_WeeklySchoolSchedule()
        {
            InitializeComponent();
        }

        private void LoadCBB()
        {
            for (int i = 2021; i <= DateTime.Now.Year - 1; i++)
            {
                string str1 = "Học kỳ 1 năm học " + i + "-" + (i + 1);
                string str2 = "Học kỳ 2 năm học " + i + "-" + (i + 1);
                cbbHocKy.Items.AddRange(new object[]{
                    str1,str2
                });
            }
        }
        private void UC_WeeklySchoolSchedule_Load(object sender, EventArgs e)
        {
            LoadCBB();
        }
    }
}
