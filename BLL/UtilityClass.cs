using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace BLL
{
    /// <summary>
    /// Lớp này đi xử lí các vấn đề lặp đi lặp lại
    /// </summary>
    public class UtilityClass
    {
        public static void OpenNewForm(Form oldForm, Form newForm)
        {
            oldForm.Close();
            Thread t = new Thread(() =>
            {
                Application.Run(newForm);
            });
            //Thiết lập trạng thái của tiến trình mới là STA (Single-Threaded Apartment)
            //để yêu cầu tiến trình mới được chạy trên một luồng riêng biệt, do đó nó không
            //bị ảnh hưởng bởi việc đóng form hiện tại
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public static string[] SplitAddress(string address)
        {
            return Regex.Split(address, " - ");
        }

        public static string sendEmail(string addressEmail, string digitcode)
        {
            
            string senderEmail = "nngann2402@gmail.com";
            string receiverEmail = addressEmail;
            string subject = "Digit code";
            string body = digitcode;
            string senderPassword = "fsjdkhdximrlvusc";

            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

            MailMessage mailMessage = new MailMessage(senderEmail, receiverEmail, subject, body);
            mailMessage.IsBodyHtml = true;
            try
            {
                smtpClient.Send(mailMessage);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static void SwapColumns(DataGridView dataGridView, int index1, int index2)
        {
            var column1 = dataGridView.Columns[index1];
            var column2 = dataGridView.Columns[index2];

            int temp = column1.DisplayIndex;
            column1.DisplayIndex = column2.DisplayIndex;
            column2.DisplayIndex = temp;
        }

        public static string[] GetDanToc()
        {
            return new string[] { "Kinh", "Tày", "Thái", "Hoa", "Khơ-me", "Mường", "Nùng", "HMông", "Dao",
                "Gia-rai", "Ngái", "Ê-đê", "Ba na", "Xơ-Đăng", "Sán Chay", "Cơ-ho", "Chăm", "Sán Dìu", "Hrê", "Mnông",
                "Ra-glai", "Xtiêng", "Bru-Vân Kiều", "Thổ", "Giáy", "Cơ-tu", "Gié Triêng", "Mạ", "Khơ-mú", "Co",
                "Tà-ôi", "Chơ-ro", "Kháng", "Xinh-mun", "Hà Nhì", "Chu ru", "Lào", "La Chí", "La Ha", "Phù Lá", "La Hủ",
                "Lự", "Lô Lô", "Chứt", "Mảng", "Pà Thẻn", "Co Lao", "Cống", "Bố Y", "Si La", "Pu Péo", "Brâu", "Ơ Đu",
                "Rơ măm", "Người nước ngoài" };
        }

        public static string[] GetQuocTich()
        {
            return new string[] { "Việt Nam", "Lào", "Campuchia", "Thái Lan", "Malaysia", "Myanmar", "Philippines",
                "Đông Timor", "Brunei", "Singapore" };
        }

        public static string GetAddressFromUCAddressSelection(string SoDuong, string TinhThanhPho,
            string QuanHuyen, string XaPhuong)
        {
            string address = "";
            if (SoDuong != "" && TinhThanhPho != "" && QuanHuyen != "" && XaPhuong != "")
                address += SoDuong + " - " + TinhThanhPho + " - " +
                    QuanHuyen + " - " + XaPhuong;
            return address;
        }

        public static void SetAlignmentMiddleCenterForColumns(DataGridView dtgv, int NumberOfRow)
        {
            List<string> ColumnNames = new List<string>();
            foreach (DataGridViewColumn column in dtgv.Columns)
                ColumnNames.Add(column.DataPropertyName);

            dtgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (string name in ColumnNames)
            {
                if (!string.IsNullOrEmpty(name))
                    dtgv.Columns[name].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dtgv.Height = dtgv.ColumnHeadersHeight + NumberOfRow * dtgv.RowTemplate.Height;
        }

        public static string GetFirstCharactersOfString(string str)
        {
            if (str == "Lập trình hướng đối tượng")
                return "OOP";
            else if (str == "Phân tích và thiết kế hướng đối tượng")
                return "OOAD";
            string[] ds = str.ToUpper().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string tmp = "";
            foreach (string s in ds)
            {
                if (s[0] == '.')
                    tmp += "Net";
                else if (s[0] == 'J')
                    tmp += "JV";
                else if (s[0] == 'Đ')
                    tmp += 'D';
                else tmp += s[0];
            }
            return tmp;
        }
        public static string SplitCongThucTinhDiem(string input)
        {
            //Vd [BT]*0.2 + [GK]*0.2 + [CK]*0.6 thì trả về kết quả là 2-2-6
            string[] ds = input.Split(new string[] { " + " }, StringSplitOptions.RemoveEmptyEntries);
            string res = "";
            foreach (string str in ds)
            {
                res += str[7] + "-";
            }
            return res.Remove(res.Length - 1, 1);
        }

        public static int CalculateHeightOfControl(Control control)
        {
            Size txtSize = TextRenderer.MeasureText(control.Text, control.Font, control.ClientRectangle.Size, TextFormatFlags.WordBreak);

            // Lấy chiều cao của một dòng văn bản dựa vào font của nó
            int lineHeight = control.Font.Height;

            //Tính toán số lượng hàng cần để hiển thị Text của control này
            int numLines = (int)Math.Ceiling((double)txtSize.Height / lineHeight);

            //Tính toán chiều cao (pixel) để hiển thị Text của control này
            int textHeight = numLines * lineHeight;
            return textHeight;
        }

        public static bool isLeapYear(int N)
        {
            if (N % 4 == 0 && N % 100 != 0)
                return true;
            if (N % 400 == 0)
                return true;
            return false;
        }

        //Determine number of day in the month
        public static int GetNumberOfDayInMonth(int month, int year)
        {
            int[] days = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (isLeapYear(year))
                days[2] = 29;
            return days[month];
        }
        public static string GetDayOfWeekVietnamese(string DayOfWeek)
        {
            switch (DayOfWeek)
            {
                case "Monday":
                    return "Thứ hai";
                case "Tuesday":
                    return "Thứ ba";
                case "Wednesday":
                    return "Thứ tư";
                case "Thursday":
                    return "Thứ năm";
                case "Friday":
                    return "Thứ sáu";
                case "Saturday":
                    return "Thứ bảy";
                case "Sunday":
                    return "Chủ nhật";
            }
            return "";
        }

        /// <summary>
        /// Trả về CN;T2;T3;... để hiển thị trên lblShowDateTime ở giao diện DailyShoolSchedule
        /// và DailyWorkSchedule
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string GetDayOfWeekVietnameseShortString(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Sunday)
                return "CN";
            DayOfWeek[] ds = { DayOfWeek.Sunday,DayOfWeek.Sunday,DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday,
                                DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday };
            string res = null;
            for (int i = 2; i <= 7; i++)
            {
                if (dt.DayOfWeek == ds[i])
                    res = "T" + i;
            }
            return res;
        }

        /// <summary>
        /// Chuyển CN -> Chủ nhật
        /// T2 -> Thứ hai,...
        /// </summary>
        /// <param name="dow"></param>
        /// <returns></returns>
        public static string GetDayOfWeekVietNameseLongString(string dow)
        {
            if (dow == "CN")
                return "Chủ nhật";
            string[] ds = new string[]
            {
                "","","hai","ba","tư","năm","sáu","bảy"
            };
            for (int i = 2; i <= 7; i++)
            {
                string tmp = i + "";
                if (dow.Contains(tmp))
                    return "Thứ " + ds[i];
            }
            return "";
        }
        /// <summary>
        /// Dùng để tính số thứ tự tuần trong năm 
        /// </summary>
        /// <param name="dow"></param>
        /// <returns></returns>
        public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            //Lấy Thursday trừ đi bởi vì tính theo chuẩn ISO8601
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            if (firstWeek <= 1)
            {
                weekNum -= 1;
            }

            var result = firstThursday.AddDays(weekNum * 7);

            return result.AddDays(-3);
        }
        public static int ConvertDayOfWeekToNumber(string DayOfWeek)
        {
            switch (DayOfWeek)
            {
                case "Thứ hai":
                    return 2;
                case "Thứ ba":
                    return 3;
                case "Thứ tư":
                    return 4;
                case "Thứ năm":
                    return 5;
                case "Thứ sáu":
                    return 6;
                case "Thứ bảy":
                    return 7;
                case "Chủ nhật":
                    return 8;
            }
            return -1;
        }
        public static int GetHourExamWithTietBD(int TietBD)
        {
            switch (TietBD)
            {
                case 1: return 7;
                case 2: return 8;
                case 3: return 9;
                case 4: return 10;
                case 5: return 11;
                case 6: return 13;
                case 7: return 14;
                case 8: return 15;
                case 9: return 16;
                case 10: return 17;
            }
            return -1;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static void EnableDragForm(System.Windows.Forms.Control control)
        {
            control.MouseDown += (sender, e) =>
            {
                ReleaseCapture();
                SendMessage((sender as System.Windows.Forms.Control).FindForm().Handle, 0x112, 0xf012, 0);
            };
        }
    }
}
