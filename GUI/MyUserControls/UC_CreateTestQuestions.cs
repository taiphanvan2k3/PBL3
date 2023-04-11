using BLL;
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
    public partial class UC_CreateTestQuestions : UserControl
    {
        public UC_CreateTestQuestions(string id)
        {
            InitializeComponent();
            LoadInfo(id);
        }
        void LoadInfo(string id)
        {
            cbLopHocPhan.Items.Add("Chọn lớp học phần");
            cbLopHocPhan.Items.AddRange(GiangVien_BLL.Instance.GetClassSectionByID(id).ToArray());
            cbLopHocPhan.SelectedIndex = 0;
        }
        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
