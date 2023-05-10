using BLL;
using DTO;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private string TaiKhoan;

        // Khai báo delegate và event
        public delegate void DataAddedSuccessHandler();
        public event DataAddedSuccessHandler DataAddedSuccessEvent;
        public frmAddAccount(int role, string TaiKhoan)
        {
            InitializeComponent();
            UtilityClass.EnableDragForm(panelContainer);
            this.role = role;
            this.TaiKhoan = TaiKhoan;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



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
            if (cmbList.SelectedIndex == -1 || cmbYearOrLevel.SelectedIndex == -1 || txtSurname.Texts.ToString() == "" || txtName.Texts.ToString() == "" || txtCCCD.Texts.ToString().Length != 12 || (rbMen.Checked == false && rbWomen.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                SinhVien_DTO svDT = new SinhVien_DTO();
                GiangVien_DTO gvDT = new GiangVien_DTO();


                passID = BCrypt.Net.BCrypt.HashString(txtCCCD.Texts.ToString());
                passEmai = BCrypt.Net.BCrypt.HashString(txtCCCD.Texts.ToString());

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
                    QuocTich = null,
                    NoiSinh = null,
                    DiaChi = null,
                    Sdt = null,
                    EmailCaNhan = null,
                    MkEmailTruongCap = passEmai
                };

                if (role == 0)
                {
                    countRecord = GetInformationAcc_BLL.Instance.getTheNumberOfStudentByFaculty(MaKhoa, cmbYearOrLevel.SelectedItem.ToString().Substring(2));
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

                    if (TaiKhoan == "")
                    {

                        if (GetInformationAcc_BLL.Instance.InsertData(ttdn, nd, svDT))
                        {
                            MessageBox.Show("Thêm tài khoản sinh viên thành công" + ID_User + "\n" + txtCCCD.Texts.ToString() + "\n" + Email + "\n" + txtCCCD.Texts.ToString());
                            var result1 = MessageBox.Show("Bạn có muốn thêm mới tài khoản tiếp không", "Thông báo", MessageBoxButtons.OKCancel);
                            if (result1 == DialogResult.Cancel)
                            {
                                this.Close();
                                // Gọi event để thông báo cho formViewAcc cập nhật dữ liệu
                                DataAddedSuccessEvent?.Invoke();
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
                        if (GetInformationAcc_BLL.Instance.UpdateData(TaiKhoan, ttdn, nd, svDT))
                        {
                            MessageBox.Show("Cập nhật tài khoản sinh viên thành công");
                            // Gọi event để thông báo cho formViewAcc cập nhật dữ liệu
                            DataAddedSuccessEvent?.Invoke();
                        }
                        else
                            MessageBox.Show("Cập nhật bị lỗi! Vui lòng kiểm tra lại thông tin");
                    }
                }
                else
                {
                    countRecord = GetInformationAcc_BLL.Instance.getTheNumberOfTeacherByFaculty(MaKhoa);
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
                    if (TaiKhoan == "")
                    {

                        if (GetInformationAcc_BLL.Instance.InsertData(ttdn, nd, gvDT))
                        {
                            MessageBox.Show("Thêm tài khoản giảng viên thành công" + ID_User + "\n" + txtCCCD.Texts.ToString() + "\n" + Email + "\n" + txtCCCD.Texts.ToString());
                            var result1 = MessageBox.Show("Bạn có muốn thêm mới tài khoản tiếp không", "Thông báo", MessageBoxButtons.OKCancel);
                            if (result1 == DialogResult.Cancel)
                            {
                                this.Close();
                                // Gọi event để thông báo cho formViewAcc cập nhật dữ liệu
                                DataAddedSuccessEvent?.Invoke();
                            }
                            else
                            {
                                ReturnEmpty();
                            }
                        }
                        else
                            MessageBox.Show("Thêm bị lỗi! Vui lòng kiểm tra lại thông tin");
                    }
                    else {
                        if (GetInformationAcc_BLL.Instance.UpdateData(TaiKhoan, ttdn, nd, gvDT))
                        {
                            MessageBox.Show("Cập nhật tài khoản giảng viên thành công");
                            // Gọi event để thông báo cho formViewAcc cập nhật dữ liệu
                            DataAddedSuccessEvent?.Invoke();
                        }
                        else
                            MessageBox.Show("Cập nhật bị lỗi! Vui lòng kiểm tra lại thông tin");
                    }

                }
            }
        }

        private void frmAddAccStudent_Load(object sender, EventArgs e)
        {
            switch (role)
            {
                case 0:
                    List<string> list = new List<string>()
                        {
                           "2018", "2019", "2020", "2021", "2022", "2023"
                        };
                    cmbYearOrLevel.Items.AddRange(list.ToArray());
                    foreach (var item in GetInformationAcc_BLL.Instance.GetListEducationProgram())
                    {
                        cmbList.Items.Add(item.TenCTDT);
                    }
                    break;
                case 1:
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
                    break;
            }
            if (TaiKhoan != "")
            {
                panelEdit.Visible = true;
                txtIDAcc.Texts = TaiKhoan;
                txtIDAcc.Enabled = false;
                cmbList.Enabled = false;
                string valueItem = "";
                string valueYearOrLevel = "";
                string name;
                switch (role)
                {
                    case 0:
                        name = "";
                        InformationStudent_DTO informationStudent = GetInformationAcc_BLL.Instance.GetInformationStudentByID(TaiKhoan);
                        string[] nameParts = informationStudent.Ten.Split(' ');
                        txtCCCD.Texts = informationStudent.MaCCCD;
                        for (int i = 0; i < nameParts.Length - 1; i++)
                        {
                            name += nameParts[i] + " ";
                        }
                        txtSurname.Texts = name;
                        txtName.Texts = nameParts[nameParts.Length - 1];
                        dtpBirthday.Value = informationStudent.NgaySinh;
                        if (informationStudent.GioiTinh)
                        {
                            rbWomen.Checked = true;
                        }
                        else
                        {
                            rbMen.Checked = true;
                        }

                        foreach (var item in GetInformationAcc_BLL.Instance.GetListEducationProgram())
                        {
                            if (informationStudent.MaCTDT == item.MaCTDT.ToString())
                            {
                                valueItem = item.TenCTDT.ToString();
                                break;
                            }
                        }
                        foreach (object item in cmbList.Items)
                        {
                            if (item.ToString().Equals(valueItem))
                            {
                                cmbList.SelectedItem = item;
                                break;
                            }
                        }
                        valueYearOrLevel = "20" + TaiKhoan.Substring(3, TaiKhoan.Length - 7);
                        foreach (object item in cmbYearOrLevel.Items)
                        {
                            if (item.ToString().Equals(valueYearOrLevel))
                            {
                                cmbYearOrLevel.SelectedItem = item;
                                break;
                            }
                        }
                        cmbYearOrLevel.Enabled = false;
                        break;
                    case 1:
                        name = "";
                        InformationTeacher_DTO informationTeacher = GetInformationAcc_BLL.Instance.GetInformationTeacherByID(TaiKhoan);
                        string[] namePartsTeacher = informationTeacher.Ten.Split(' ');
                        txtCCCD.Texts = informationTeacher.MaCCCD;
                        for (int i = 0; i < namePartsTeacher.Length - 1; i++)
                        {
                            name += namePartsTeacher[i] + " ";
                        }
                        txtSurname.Texts = name;
                        txtName.Texts = namePartsTeacher[namePartsTeacher.Length - 1];
                        dtpBirthday.Value = informationTeacher.NgaySinh;
                        if (informationTeacher.GioiTinh)
                        {
                            rbWomen.Checked = true;
                        }
                        else
                        {
                            rbMen.Checked = true;
                        }

                        foreach (var item in GetInformationAcc_BLL.Instance.GetListFaculty())
                        {
                            if (informationTeacher.MaKhoa == item.MaKhoa.ToString())
                            {
                                valueItem = item.TenKhoa.ToString();
                                break;
                            }
                        }
                        foreach (object item in cmbList.Items)
                        {
                            if (item.ToString().Equals(valueItem))
                            {
                                cmbList.SelectedItem = item;
                                break;
                            }
                        }
                        foreach (object item in cmbYearOrLevel.Items)
                        {
                            if (item.ToString().Equals(informationTeacher.TrinhDo))
                            {
                                cmbYearOrLevel.SelectedItem = item;
                                break;
                            }
                        }
                        break;
                }
            }
            else
            {
                panelContainer.Location = new Point(10, 35);
                this.Size = new Size(500, 750);
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
