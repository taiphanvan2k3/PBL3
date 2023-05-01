using BLL;
using GUI.MyCustomControl;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_CreateExam : UserControl
    {
        public UC_CreateExam(string ID)
        {
            InitializeComponent();
            LoadInfo(ID);
            tbTenBaiKiemTra._TextChanged += CheckAllConditions;
            tbMatKhauLamBai._TextChanged += CheckAllConditions;
            tbThoiGianLamBai._TextChanged += CheckAllConditions;
            cbLoaiBaiKiemTra.SelectedIndexChanged += CheckAllConditions;
            cbLopHocPhan.SelectedIndexChanged += CheckAllConditions;
            cbSoLuongCauHoi.SelectedIndexChanged += CheckAllConditions;
        }
        public string MaGV { get; set; }
        void LoadInfo(string ID)
        {
            dtpNgayKiemTra.Value = DateTime.Now;
            dtpGioKT.Value = DateTime.Now;
            cbLopHocPhan.Items.Add("Chọn lớp học phần");
            cbLopHocPhan.Items.AddRange(GiangVien_BLL.Instance.GetClassSectionByID(ID).ToArray());
            cbLopHocPhan.SelectedIndex = 0;
            cbLoaiBaiKiemTra.SelectedIndex = 0;
            cbSoLuongCauHoi.SelectedIndex = 0;
        }
        private void CheckAllConditions(object sender, EventArgs e)
        {
            bool allComboboxChoosed = !(cbLoaiBaiKiemTra.SelectedItem.ToString() == "Chọn loại bài kiểm tra") &&
                                      !(cbSoLuongCauHoi.SelectedItem.ToString() == "Chọn số câu hỏi") &&
                                      !(cbLopHocPhan.SelectedItem.ToString() == "Chọn lớp học phần");
            bool allTextEntered = !string.IsNullOrWhiteSpace(tbTenBaiKiemTra.Texts) &&
                                  !string.IsNullOrWhiteSpace(tbThoiGianLamBai.Texts) &&
                                  !string.IsNullOrWhiteSpace(tbMatKhauLamBai.Texts);

            btnTao.Enabled = allComboboxChoosed && allTextEntered;
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            byte TGLamBai;
            /*if(tbTenBaiKiemTra.Texts == "")
                CustomMessageBox.Show("Vui lòng nhập tên bài kiểm tra!");
            else if(tbThoiGianLamBai.Texts == "")
                CustomMessageBox.Show("Vui lòng nhập thời gian làm bài!");
            else if (byte.TryParse(tbThoiGianLamBai.Texts,out TGLamBai) == false)
                CustomMessageBox.Show("Thời gian làm bài nhập không hợp lệ!");
            else if(tbMatKhauLamBai.Texts == "")
                CustomMessageBox.Show("Vui lòng nhập mật khẩu làm bài!");
            else if(tbMatKhauLamBai.Texts == "")
                CustomMessageBox.Show("Vui lòng nhập mật khẩu làm bài!");
            else if(cbLopHocPhan.SelectedItem.ToString() == "Chọn lớp học phần")
                CustomMessageBox.Show("Vui lòng nhập chọn lớp học phần!");*/
            if (byte.TryParse(tbThoiGianLamBai.Texts, out TGLamBai) == false)
                CustomMessageBox.Show("Thời gian làm bài nhập không hợp lệ!");
            else
            {
                DateTime DateKT = dtpNgayKiemTra.Value.Date;
                string TimeKT = dtpGioKT.Text;
                DateTime TimeExam = DateTime.ParseExact(TimeKT, "h:mm tt", CultureInfo.InvariantCulture);
                DateTime DateExam = DateKT.Add(TimeExam.TimeOfDay);
                if (DateExam < DateTime.Now)
                    CustomMessageBox.Show("Thời gian thi không hợp lệ!");
                else
                {
                    //Lấy ra 21.13 trong OOAD21.13 hay TRR21.13 .Cụ thể là phần đuôi
                    string NameLHPGeneric = Regex.Match(cbLopHocPhan.SelectedItem.ToString(), @"\d+\.\d+").Value;
                    if (GiangVien_BLL.Instance.CheckScheduleExamConflict(DateExam, Convert.ToByte(tbThoiGianLamBai.Texts), NameLHPGeneric))
                        CustomMessageBox.Show("Xung đột giữa lịch thi.\nVui lòng chọn lại thời gian thi khác!", "Xung đột lich thi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        int NumQuesInDBForMonHoc = GiangVien_BLL.Instance.GetNumberQuestionForMonHoc(cbLopHocPhan.SelectedItem.ToString());
                        if (NumQuesInDBForMonHoc < Convert.ToInt32(cbSoLuongCauHoi.SelectedItem.ToString()))
                        {
                            CustomMessageBox.Show("Số lượng câu hỏi trong môn học này chỉ có " + NumQuesInDBForMonHoc + " câu.\nBạn có thể chọn số câu hỏi phù hợp hoặc tạo thêm câu hỏi vào cơ sở dữ liệu.", "Thiếu hụt câu hỏi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            GiangVien_BLL.Instance.CreateExam(tbTenBaiKiemTra.Texts, cbLoaiBaiKiemTra.SelectedItem.ToString(),
                                                          Convert.ToByte(tbThoiGianLamBai.Texts), DateExam,
                                                          Convert.ToByte(cbSoLuongCauHoi.SelectedItem.ToString()), cbLopHocPhan.SelectedItem.ToString(),
                                                          MaGV, tbMatKhauLamBai.Texts, chbAllowReturn.Checked);
                        }
                    }
                }
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            cbLoaiBaiKiemTra.SelectedIndex = 0;
            cbLopHocPhan.SelectedIndex = 0;
            cbSoLuongCauHoi.SelectedIndex = 0;
            tbTenBaiKiemTra.Texts = "";
            tbMatKhauLamBai.Texts = "";
            tbThoiGianLamBai.Texts = "";
            chbAllowReturn.Checked = false;
            dtpNgayKiemTra.Value = DateTime.Now;
            dtpGioKT.Value = DateTime.Now;
        }
    }
}
