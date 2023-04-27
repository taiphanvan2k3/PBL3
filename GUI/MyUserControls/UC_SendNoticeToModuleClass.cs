using BLL;
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

namespace GUI.MyUserControls
{
    public partial class UC_SendNoticeToModuleClass : UserControl
    {
        public UC_SendNoticeToModuleClass()
        {
            InitializeComponent();
        }
        #region Properties
        public string ID { get; set; }
        #endregion
        private void UC_SendAnnounceToModuleClass_Load(object sender, EventArgs e)
        {
            cbbLHP.SelectedIndex = 0;
            cbbLHP.Items.AddRange(GiangVien_BLL.Instance.GetListLHPByIDTeacher(ID).ToArray());
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
            if(cbbLHP.SelectedItem.ToString() == "Danh sách LHP")
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
                if (GiangVien_BLL.Instance.CheckNoticeRedundanṭ̣̣̣(ID, dt, cbbLHP.SelectedItem.ToString()))
                {
                    GiangVien_BLL.Instance.SendNoticeToLHP(ID, cbbLHP.SelectedItem.ToString(), tbTieuDe.Text, tbNoiDung.Texts, dt);
                    CustomMessageBox.Show("Gửi thông báo thành công!");
                }
                else
                {
                    if(MessageBox.Show("Bạn có muốn thay thế thông báo đã gửi vào lớp học phần này trong hôm nay!","Tồn tại thông báo trong ngày",MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        GiangVien_BLL.Instance.ReplaceNotice(ID, dt, cbbLHP.SelectedItem.ToString(), tbTieuDe.Text, tbNoiDung.Texts);
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
