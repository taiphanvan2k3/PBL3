using PBL3.MyUserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class FormTaoCauHoi : Form
    {
        private List<DapAnControl> dsDapAn;
        public FormTaoCauHoi()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSingleMulti.Checked)
            {
                groupBoxSingleChoice.Visible = false;
                groupBoxMultiChoices.Visible = true;
                groupBoxMultiChoices.Location = groupBoxSingleChoice.Location;
            }
            else
            {
                groupBoxSingleChoice.Visible = true;
                groupBoxMultiChoices.Visible = false;
                groupBoxMultiChoices.Location = groupBoxSingleChoice.Location;
            }
        }

        private void FormTaoCauHoi_Load(object sender, EventArgs e)
        {
            dsDapAn = new List<DapAnControl>();
            for (int i = 1; i <= 4; i++)
            {
                DapAnControl da = new DapAnControl() { STT = i };
                panelDanhSachDapAn.Controls.Add(da);
                dsDapAn.Add(da);
            }
        }

        private void selectChoiceChanged(object sender, EventArgs e)
        {
            RadioButton src = sender as RadioButton;
            foreach (var control in groupBoxMultiChoices.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox temp = control as CheckBox;
                    if (temp.Text == src.Text)
                    {
                        temp.Checked = src.Checked;
                        break;
                    }
                }
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (textBoxCauHoi.Text == "")
                check = false;
            string input = textBoxCauHoi.Text;
            foreach (DapAnControl item in dsDapAn)
            {
                if (item.DapAn == "")
                {
                    check = false;
                    break;
                }
                else
                {
                    input += "\n" + item.DapAn;
                }
            }

            if (!check)
                MessageBox.Show("Bạn cần phải nhập đầy đủ các nội dung cần thiết cho câu hỏi");
            else
            {
                MessageBox.Show(input);
            }
        }

        private void textBoxCauHoi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCauHoi.Text == "")
                labelCheck.Visible = true;
            else labelCheck.Visible = false;
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
