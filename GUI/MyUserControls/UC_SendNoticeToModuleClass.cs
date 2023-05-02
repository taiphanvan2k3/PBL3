using BLL;
using GUI.MyCustomControl;
using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_SendNoticeToModuleClass : UserControl
    {
        public UC_SendNoticeToModuleClass()
        {
            InitializeComponent();
        }
        #region Properties
        public string MaGV { get; set; }

        //Nếu chỉ thông báo đến 1 lớp HP cụ thể nào đó
        public bool IsNoticeToSpecificModuleClass { get; set; }
        public string MaLopHP { get; set; }
        #endregion

        public void HideCombobox()
        {
            cbbLHP.Visible = false;
            cbbLHP.Items.Clear();
            cbbLHP.Items.Add(MaLopHP);
            cbbLHP.SelectedIndex = 0;
        }

        private void UC_SendAnnounceToModuleClass_Load(object sender, EventArgs e)
        {
            if (IsNoticeToSpecificModuleClass)
            {
                HideCombobox();
            }
            else
            {
                cbbLHP.SelectedIndex = 0;
                cbbLHP.Items.AddRange(GiangVien_BLL.Instance.GetListLHPByIDTeacher(MaGV).ToArray());
            }
        }

        private void tbTieuDe_Enter(object sender, EventArgs e)
        {
            if (tbTieuDe.Text == "Tiêu đề")
            {
                tbTieuDe.Text = "";
                tbTieuDe.ForeColor = Color.Black;
            }
        }

        private void tbTieuDe_Leave(object sender, EventArgs e)
        {
            if (tbTieuDe.Text == "")
            {
                tbTieuDe.Text = "Tiêu đề";
                tbTieuDe.ForeColor = Color.Silver;
            }
        }

        private void tbNoiDung_Enter(object sender, EventArgs e)
        {
            if (tbNoiDung.Texts == "Nội dung")
            {
                tbNoiDung.Texts = "";
                tbNoiDung.ForeColor = Color.Black;
            }
        }

        private void tbNoiDung_Leave(object sender, EventArgs e)
        {
            if (tbNoiDung.Texts == "")
            {
                tbNoiDung.Texts = "Nội dung";
                tbNoiDung.ForeColor = Color.Silver;
            }
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (cbbLHP.SelectedItem.ToString() == "Danh sách LHP")
            {
                CustomMessageBox.Show("Vui lòng chọn lớp học phần!");
            }
            else if (tbTieuDe.ForeColor == Color.Silver)
            {
                CustomMessageBox.Show("Vui lòng nhập tiêu đề!");
            }
            else if (tbNoiDung.ForeColor == Color.Silver)
            {
                CustomMessageBox.Show("Vui lòng nhập nội dung!");
            }
            else
            {
                DateTime dt = DateTime.Now;
                if (GiangVien_BLL.Instance.CheckNoticeRedundanṭ̣̣̣(MaGV, dt, cbbLHP.SelectedItem.ToString()))
                {
                    GiangVien_BLL.Instance.SendNoticeToLHP(MaGV, cbbLHP.SelectedItem.ToString(), tbTieuDe.Text, tbNoiDung.Texts, dt);
                    CustomMessageBox.Show("Gửi thông báo thành công!");
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn thay thế thông báo đã gửi vào lớp học phần này trong hôm nay!", "Tồn tại thông báo trong ngày", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        GiangVien_BLL.Instance.ReplaceNotice(MaGV, dt, cbbLHP.SelectedItem.ToString(), tbTieuDe.Text, tbNoiDung.Texts);
                    }
                }

            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            tbTieuDe.Text = "Tiêu đề";
            tbTieuDe.ForeColor = Color.Silver;
            tbNoiDung.Texts = "Nội dung";
            tbNoiDung.ForeColor = Color.Silver;
            cbbLHP.SelectedIndex = 0;
        }

    }
}
