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
            tbTenBaiKiemTra.TextChanged += CheckAllConditions;
            tbMatKhauLamBai.TextChanged += CheckAllConditions;
            tbThoiGianLamBai.TextChanged += CheckAllConditions;
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
            //Tính số tuần 
            int year = DateTime.Now.Year;
            List<string> weeks = new List<string>();

            if (DateTime.Now.Month <= 6)
            {
                for (int i = 1; i <= 26; i++)
                {
                    DateTime start = UtilityClass.FirstDateOfWeekISO8601(year, i);
                    DateTime end = start.AddDays(6);
                    //Chỉ thêm những tuần sau hiện tại vào list
                    if(end >= DateTime.Now)
                    {
                        //Thêm tuần vào list
                        weeks.Add("Tuần " + $"{i.ToString().PadLeft(2, '0')} ({start.ToString("dd/MM/yyyy")} -> {end.ToString("dd/MM/yyyy")})");
                    }
                }
            }
            else
            {
                for (int i = 27; i <= 52; i++)
                {
                    DateTime start = UtilityClass.FirstDateOfWeekISO8601(year, i);
                    DateTime end = start.AddDays(6);
                    //Chỉ thêm những tuần sau hiện tại vào list
                    if (end >= DateTime.Now)
                    {
                        //Thêm tuần vào list
                        weeks.Add("Tuần " + $"{i.ToString().PadLeft(2, '0')} ({start.ToString("dd/MM/yyyy")} -> {end.ToString("dd/MM/yyyy")})");
                    }
                }
            }

            cbTuanKiemTra.DataSource = weeks;
            cbTuanKiemTra.SelectedIndex = 0;
        }
        private void CheckAllConditions(object sender, EventArgs e)
        {
            bool allComboboxChoosed = !(cbLoaiBaiKiemTra.SelectedItem.ToString() == "Chọn loại bài kiểm tra") &&
                                      !(cbSoLuongCauHoi.SelectedItem.ToString() == "Chọn số câu hỏi") &&
                                      !(cbLopHocPhan.SelectedItem.ToString() == "Chọn lớp học phần");
            bool allTextEntered = !string.IsNullOrWhiteSpace(tbTenBaiKiemTra.Text) &&
                                  !string.IsNullOrWhiteSpace(tbThoiGianLamBai.Text) &&
                                  !string.IsNullOrWhiteSpace(tbMatKhauLamBai.Texts);

            btnTao.Enabled = allComboboxChoosed && allTextEntered;

            if(cbLoaiBaiKiemTra.SelectedItem.ToString() == "Giữa kỳ" || cbLoaiBaiKiemTra.SelectedItem.ToString() == "Test")
            {
                cbTuanKiemTra.Visible = true;
                dtpNgayKiemTra.Visible = false;
                dtpGioKT.Visible = false;
            }
            else
            {
                cbTuanKiemTra.Visible = false;
                dtpNgayKiemTra.Visible = true;
                dtpGioKT.Visible = true;
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            byte TGLamBai;
            if (byte.TryParse(tbThoiGianLamBai.Text, out TGLamBai) == false)
                CustomMessageBox.Show("Thời gian làm bài nhập không hợp lệ!");
            else
            {
                DateTime DateExam;
                if (cbLoaiBaiKiemTra.SelectedItem.ToString() == "Cuối kỳ")
                {
                    DateTime DateKT = dtpNgayKiemTra.Value.Date;
                    string TimeKT = dtpGioKT.Text;
                    DateTime TimeExam = DateTime.ParseExact(TimeKT, "h:mm tt", CultureInfo.InvariantCulture);
                    DateExam = DateKT.Add(TimeExam.TimeOfDay);
                }
                else
                {
                    string input = cbTuanKiemTra.SelectedItem.ToString();
                    Match match = Regex.Match(input, @"\((\d{2}/\d{2}/\d{4}) ->");
                    string date = match.Groups[1].Value;
                    DateExam = DateTime.ParseExact(date, "dd/MM/yyyy", null); 
                    var tkb = GiangVien_BLL.Instance.GetScheduleForTKB(cbLopHocPhan.SelectedItem.ToString());
                    DateExam.AddDays(UtilityClass.ConvertDayOfWeekToNumber(tkb.Thu) - 2);
                    DateExam = new DateTime(DateExam.Year, DateExam.Month, DateExam.Day, UtilityClass.GetHourExamWithTietBD(tkb.TietBD), 0, 0);
                }

                if (DateExam < DateTime.Now)
                    CustomMessageBox.Show("Thời gian thi không hợp lệ!");
                else
                {
                    //Lấy ra 21.13 trong OOAD21.13 hay TRR21.13 .Cụ thể là phần đuôi
                    //string NameLHPGeneric = Regex.Match(cbLopHocPhan.SelectedItem.ToString(), @"\d+\.\d+").Value;
                    if (GiangVien_BLL.Instance.CheckScheduleExamConflict(DateExam, Convert.ToByte(tbThoiGianLamBai.Text), cbLopHocPhan.SelectedItem.ToString()))
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
                            if(GiangVien_BLL.Instance.CreateExam(tbTenBaiKiemTra.Text, cbLoaiBaiKiemTra.SelectedItem.ToString(),
                                                          Convert.ToByte(tbThoiGianLamBai.Text), DateExam,
                                                          Convert.ToByte(cbSoLuongCauHoi.SelectedItem.ToString()), cbLopHocPhan.SelectedItem.ToString(),
                                                          MaGV, tbMatKhauLamBai.Texts, chbAllowReturn.Checked))
                                CustomMessageBox.Show("Tạo bài kiểm tra thành công!");
                            else
                                CustomMessageBox.Show("Bài kiểm tra " + cbLoaiBaiKiemTra.SelectedItem.ToString() + " của lớp " + cbLopHocPhan.SelectedItem.ToString() + " đã tồn tại!");
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
            tbTenBaiKiemTra.Text = "";
            tbMatKhauLamBai.Texts = "";
            tbThoiGianLamBai.Text = "";
            chbAllowReturn.Checked = false;
            dtpNgayKiemTra.Value = DateTime.Now;
            dtpGioKT.Value = DateTime.Now;
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            int offset = flowLayout2.Location.Y;
            int heightRemains = flowLayoutPanel1.Height - flowLayout2.Height
                                                  - flowLayout3.Height - flowLayout4.Height - flowLayout5.Height - flowLayout6.Height;
            flowLayout2.Width = flowLayoutPanel1.Width - 10;

            //Không thay đổi chiều cao cho pnlDiaChi, vì thay đổi nữa thì khoảng trống dư quá nhiều
            flowLayout3.Width = flowLayout2.Width;
            //flowLayout3.Height += (heightRemains - 4 * offset) / 3;

            flowLayout4.Width = flowLayout2.Width;
            //flowLayout4.Height += (heightRemains - 4 * offset) / 3;

            flowLayout5.Width = flowLayout2.Width;
            //flowLayout5.Height += (heightRemains - 4 * offset) / 3;

            flowLayout6.Width = flowLayout2.Width;
            //flowLayout6.Height += (heightRemains - 4 * offset) / 3;

            pnlTenBaiKT.Width = flowLayout2.Width / 2 - 10;
            pnlSoLuongCauHoi.Width = pnlTenBaiKT.Width;

            pnlLoaiBKT.Width = flowLayout3.Width / 2 - 10;
            pnlLHP.Width = pnlLoaiBKT.Width;

            pnlThoiGianLamBai.Width = flowLayout4.Width / 2 - 10;
            pnlMatKhauLamBai.Width = pnlThoiGianLamBai.Width;

            pnlThoiGianKiemTra.Width = flowLayout5.Width / 2 - 10;
            pnlChoPHepQuayLai.Width = pnlThoiGianKiemTra.Width;

            pnlDatLai.Width = flowLayout6.Width / 2 - 10;
            pnlTao.Width = pnlDatLai.Width;
        }
    }
}
