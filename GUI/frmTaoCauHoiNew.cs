using BLL;
using DTO;
using GUI.MyCustomControl;
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
    public partial class frmTaoCauHoiNew : Form
    {
        public frmTaoCauHoiNew()
        {
            InitializeComponent();
            tgMultiAnswer.CheckedChanged += CheckAllConditions;
            chbA.CheckedChanged += CheckAllConditions;
            chbB.CheckedChanged += CheckAllConditions;
            chbC.CheckedChanged += CheckAllConditions;
            chbD.CheckedChanged += CheckAllConditions;
            rbA.CheckedChanged += CheckAllConditions;
            rbB.CheckedChanged += CheckAllConditions;
            rbC.CheckedChanged += CheckAllConditions;
            rbD.CheckedChanged += CheckAllConditions;
            tbQuestion._TextChanged += CheckAllConditions;
            tbA._TextChanged += CheckAllConditions;
            tbB._TextChanged += CheckAllConditions;
            tbC._TextChanged += CheckAllConditions;
            tbD._TextChanged += CheckAllConditions;
            cbMonHoc.SelectedIndexChanged += CheckAllConditions;
        }
        public string MaGV { get; set;  }
        private void frmTaoCauHoiNew_Load(object sender, EventArgs e)
        {
            cbMonHoc.Items.Add("Chọn môn học");
            cbMonHoc.Items.AddRange(GiangVien_BLL.Instance.GetMonHocInKhoaForGV(MaGV).ToArray());
            cbMonHoc.SelectedIndex = 0;
        }
        //Xử lí sự kiện enable button tạo câu hỏi 
        private void CheckAllConditions(object sender, EventArgs e)
        {
            bool MonHocChoosed = !(cbMonHoc.SelectedItem.ToString() == "Chọn môn học" );
            bool allRbOrChbChecked;
            if(!tgMultiAnswer.Checked)
                allRbOrChbChecked = rbA.Checked || rbB.Checked || rbC.Checked || rbD.Checked;
            else
                allRbOrChbChecked = chbA.Checked || chbB.Checked || chbC.Checked || chbD.Checked;
            bool allTextEntered = (tbQuestion.ForeColor == Color.Black && tbQuestion.Texts != "") &&
                                  (tbA.ForeColor == Color.Black && tbA.Texts != "") &&
                                  (tbB.ForeColor == Color.Black && tbB.Texts != "") &&
                                  (tbC.ForeColor == Color.Black && tbC.Texts != "") &&
                                  (tbD.ForeColor == Color.Black && tbD.Texts != "");

            btnCreateQues.Enabled = MonHocChoosed && allRbOrChbChecked && allTextEntered;
        }
        private void tbQuestion_Enter(object sender, EventArgs e)
        {
            if (tbQuestion.Texts == "Nhập câu hỏi")
            {
                tbQuestion.Texts = "";
                tbQuestion.ForeColor = Color.Black;
            }
        }

        private void tbQuestion_Leave(object sender, EventArgs e)
        {
            if (tbQuestion.Texts == "")
            {
                tbQuestion.Texts = "Nhập câu hỏi";
                tbQuestion.ForeColor = Color.DimGray;
            }
        }

        private void tbA_Enter(object sender, EventArgs e)
        {
            if (tbA.Texts == "Nhập đáp án A")
            {
                tbA.Texts = "";
                tbA.ForeColor = Color.Black;
            }
        }

        private void tbA_Leave(object sender, EventArgs e)
        {
            if (tbA.Texts == "")
            {
                tbA.Texts = "Nhập đáp án A";
                tbA.ForeColor = Color.DimGray;
            }
        }

        private void tbB_Enter(object sender, EventArgs e)
        {
            if (tbB.Texts == "Nhập đáp án B")
            {
                tbB.Texts = "";
                tbB.ForeColor = Color.Black;
            }
        }

        private void tbB_Leave(object sender, EventArgs e)
        {
            if (tbB.Texts == "")
            {
                tbB.Texts = "Nhập đáp án B";
                tbB.ForeColor = Color.DimGray;
            }
        }

        private void tbC_Enter(object sender, EventArgs e)
        {
            if (tbC.Texts == "Nhập đáp án C")
            {
                tbC.Texts = "";
                tbC.ForeColor = Color.Black;
            }
        }

        private void tbC_Leave(object sender, EventArgs e)
        {
            if (tbC.Texts == "")
            {
                tbC.Texts = "Nhập đáp án C";
                tbC.ForeColor = Color.DimGray;
            }
        }

        private void tbD_Enter(object sender, EventArgs e)
        {
            if (tbD.Texts == "Nhập đáp án D")
            {
                tbD.Texts = "";
                tbD.ForeColor = Color.Black;
            }
        }

        private void tbD_Leave(object sender, EventArgs e)
        {
            if (tbD.Texts == "")
            {
                tbD.Texts = "Nhập đáp án D";
                tbD.ForeColor = Color.DimGray;
            }
        }

        private void tgMultiAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if(tgMultiAnswer.Checked)
            {
                foreach (CheckBox i in pnlChooseAnswer.Controls.OfType<CheckBox>())
                {
                    i.Enabled = true;
                    i.Visible = true;
                }
                foreach (RadioButton i in pnlChooseAnswer.Controls.OfType<RadioButton>())
                {
                    i.Enabled = false;
                    i.Visible = false;
                }
            }
            else
            {
                foreach (CheckBox i in pnlChooseAnswer.Controls.OfType<CheckBox>())
                {
                    i.Enabled = false;
                    i.Visible = false;
                }
                foreach (RadioButton i in pnlChooseAnswer.Controls.OfType<RadioButton>())
                {
                    i.Enabled = true;
                    i.Visible = true;
                }
            }
        }

        private void btnCreateQues_Click(object sender, EventArgs e)
        {
            string DapAnDung = "";
            string PhanLoai;
            if(tgMultiAnswer.Checked)
            {
                DapAnDung += chbA.Checked ? "a" : "";
                DapAnDung += chbB.Checked ? "b" : "";
                DapAnDung += chbC.Checked ? "c" : "";
                DapAnDung += chbD.Checked ? "d" : "";
                PhanLoai = "Multi";
            }
            else
            {
                DapAnDung += rbA.Checked ? "a" : "";
                DapAnDung += rbB.Checked ? "b" : "";
                DapAnDung += rbC.Checked ? "c" : "";
                DapAnDung += rbD.Checked ? "d" : "";
                PhanLoai = "Single";
            }
            GiangVien_BLL.Instance.CreateQuestion(tbQuestion.Texts, tbA.Texts, tbB.Texts, tbC.Texts, tbD.Texts, DapAnDung, ((CBBItem)cbMonHoc.SelectedItem).Id, PhanLoai);
            CustomMessageBox.Show("Tạo câu hỏi thành công!");
        }


    }
}
