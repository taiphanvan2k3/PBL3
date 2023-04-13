using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace GUI
{
    public partial class frmAddAccount : Form
    {

        private string ID_User = "";
        private string MaKhoa = "";
        private string MaCTDT = "";
        private string VaiTro = "";
        private string Email = "";

        private string passID = "";
        private string passEmai = "";

        private int role;
        public frmAddAccount(int role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void LoadData()
        {

        }
        #region Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void cmbList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbList.SelectedIndex != -1)
            {
                MaKhoa = "";
                MaCTDT = "";
                if (role == 0)
                {
                    foreach (var item in GetInformationAcc_BLL.Instance.GetListEducationProgram())
                    {
                        if (cmbList.SelectedItem.ToString() == item.TenCTDT.ToString())
                        {
                            MaKhoa += item.MaKhoa;
                            MaCTDT += item.MaCTDT;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var item in GetInformationAcc_BLL.Instance.GetListFaculty())
                    {
                        if (cmbList.SelectedItem.ToString() == item.TenKhoa.ToString())
                        {
                            MaKhoa += item.MaKhoa;
                            break;
                        }
                    }
                }
            }
        }
        private void ReturnEmpty()
        {
            txtSurname.Texts = "";
            txtName.Texts = "";
            txtCCCD.Texts = "";
            cmbList.SelectedIndex = -1;
            cmbYearOrLevel.SelectedIndex = -1;
            rbMen.Checked = rbWomen.Checked = false;
        }
        private void btnADD_Click_1(object sender, EventArgs e)
        {
            Email = "";
            passID = "";
            passEmai = "";
            VaiTro = "";
            Random random = new Random();
            int countRecord = 0;
            string suffix = "";
            if (cmbList.SelectedIndex == -1 || cmbYearOrLevel.SelectedIndex == -1 || txtSurname.Texts == null || txtSurname.Texts == null || txtCCCD.Texts.ToString().Length != 12 || (rbMen.Checked == false && rbWomen.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                SinhVien_DTO svDT = new SinhVien_DTO();
                GiangVien_DTO gvDT = new GiangVien_DTO();

                int pass1 = random.Next(100000, 999999);
                int pass2 = random.Next(100000, 999999);
                passID = BCrypt.Net.BCrypt.HashString(pass1.ToString());
                passEmai = BCrypt.Net.BCrypt.HashString(pass2.ToString());

                THONG_TIN_DANG_NHAP_DTO ttdn = new THONG_TIN_DANG_NHAP_DTO();

                ttdn.MkUngDung = passID;
                ttdn.MaXacThucDeLayLaiMK = null;


                NguoiDung_DTO nd = new NguoiDung_DTO()
                {
                    Ho = txtSurname.Texts.ToString(),
                    Ten = txtName.Texts.ToString(),
                    MaCCCD = txtCCCD.Texts.ToString(),
                    AnhCaNhan = null,
                    NgaySinh = dtpBirthday.Value,
                    GioiTinh = rbMen.Checked ? false : true,
                    DanToc = null,
                    QuocTinh = null,
                    NoiSinh = null,
                    DiaChi = null,
                    Sdt = null,
                    EmailCaNhan = null,
                    MkEmailTruongCap = passEmai
                };

                if (role == 0)
                {
                    countRecord = GetInformationAcc_BLL.Instance.GetCountStudent();
                    countRecord++;
                    suffix = countRecord.ToString("D4");
                    ID_User = MaKhoa + cmbYearOrLevel.SelectedItem.ToString().Substring(2) + suffix;
                    Email = ID_User + "SV@emailling.xyz";
                    VaiTro = "Sinh viên";
                    ttdn.TaiKhoan = ID_User;
                    ttdn.VaiTro = VaiTro;
                    nd.MaNguoiDung = ID_User;
                    nd.EmailTruongCap = Email;

                    svDT = new SinhVien_DTO()
                    {
                        MaNguoiDung = ID_User,
                        MaCTDT = MaCTDT,
                        MaLopSH = null
                    };
                    if (GetInformationAcc_BLL.Instance.InsertData(ttdn, nd, svDT) == true)
                    {
                        MessageBox.Show("Thêm tài khoản sinh viên thành công" + ID_User + "\n" + pass1 + "\n" + Email + "\n" + pass2);
                        var result1 = MessageBox.Show("Bạn có muốn thêm mới tài khoản tiếp không", "Thông báo", MessageBoxButtons.OKCancel);
                        if (result1 == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                        else
                        {
                            ReturnEmpty();
                        }
                    }
                    else
                        MessageBox.Show("Thêm bị lỗi! Vui lòng kiểm tra lại thông tin");
                }
                else
                {
                    countRecord = GetInformationAcc_BLL.Instance.GetCountTeacher();
                    countRecord++;
                    suffix = countRecord.ToString("D4");
                    ID_User = MaKhoa + "BK" + suffix;
                    Email = ID_User + "GV@emailling.xyz";
                    VaiTro = "Giáo viên";
                    ttdn.TaiKhoan = ID_User;
                    ttdn.VaiTro = VaiTro;
                    nd.MaNguoiDung = ID_User;
                    nd.EmailTruongCap = Email;

                    gvDT = new GiangVien_DTO()
                    {
                        MaNguoiDung = ID_User,
                        TrinhDo = cmbYearOrLevel.SelectedItem.ToString(),
                        Luong = null,
                        MaKhoa = MaKhoa,
                    };
                    if (GetInformationAcc_BLL.Instance.InsertData(ttdn, nd, gvDT) == true)
                    {
                        MessageBox.Show("Thêm tài khoản giảng viên thành công" + ID_User + "\n" + pass1 + "\n" + Email + "\n" + pass2);
                        var result1 = MessageBox.Show("Bạn có muốn thêm mới tài khoản tiếp không", "Thông báo", MessageBoxButtons.OKCancel);
                        if (result1 == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                        else
                        {
                            ReturnEmpty();
                        }
                    }
                    else
                        MessageBox.Show("Thêm bị lỗi! Vui lòng kiểm tra lại thông tin");
                }
            }
        }

        private void frmAddAccStudent_Load(object sender, EventArgs e)
        {
            if (role == 0)
            {
                List<string> list = new List<string>()
                {
                    "2020", "2021", "2022", "2023"
                };
                cmbYearOrLevel.Items.AddRange(list.ToArray());
                foreach (var item in GetInformationAcc_BLL.Instance.GetListEducationProgram())
                {
                    cmbList.Items.Add(item.TenCTDT);
                }
            }
            else
            {
                lbFacultyOrProgram.Text = "Tên khoa";
                lbYearOrLevel.Text = "Trình độ";
                List<string> trinhDo = new List<string>()
                {
                    "Tiến sĩ", "Thạc Sĩ", "Phó Giáo Sư - Tiến sĩ", "Giáo sư - Tiến sĩ"
                };
                cmbYearOrLevel.Items.AddRange(trinhDo.ToArray());
                foreach (var item in GetInformationAcc_BLL.Instance.GetListFaculty())
                {
                    cmbList.Items.Add(item.TenKhoa);
                }
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmAddAccStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Đã đóng");
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
