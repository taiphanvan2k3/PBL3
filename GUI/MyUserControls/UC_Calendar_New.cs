﻿using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_Calendar_New : UserControl
    {
        #region Properties
        public string MaSV { get; set; }
        private Size formOriginalSize;
        private Color colorBack;
        public Color ColorBack
        {
            get => colorBack;
            set
            {
                colorBack = value;
                this.BackColor = colorBack;
                tableLayoutPanel.BackColor = colorBack;
                lbMonday.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                lbTuesday.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                lbWednesday.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                lbThursday.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                lbFriday.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                lbSaturday.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                lbSunday.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                btnPrevious.BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                btnPrevious.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                btnNext.BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                btnNext.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                buttonToday.BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                buttonToday.ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                lbDate.ForeColor = (colorBack == Color.White) ? Color.FromArgb(13, 87, 119) : Color.FromArgb(227, 111, 38);
                //LoadDays();
                //this.Invalidate();
            }
        }
        #endregion

        public Button ButtonDateMonth { get; set; }
        int MONTH, YEAR;
        UC_Day[,] btn = new UC_Day[6, 7];
        List<BaiKiemTra_DTO> li = new List<BaiKiemTra_DTO>();

        //Lưu lại vị trí [i,j] của button có ngày tương ứng trên ma trận
        //vd Button ngày 1 nằm ở vị trí [0,4] thì thêm vào Dictionary <1,KeyValuePair<0,4>>
        Dictionary<int, KeyValuePair<int, int>> IndexDayInMatrix;
        int DayChoosing;

        //Kiểm tra xem có nhấn vào UC_Day ở lịch lớn không?
        private bool IsClickOnUC_Day { get; set; } = false;
        public UC_Calendar_New()
        {
            InitializeComponent();
            init();
            formOriginalSize = this.Size;
            IndexDayInMatrix = new Dictionary<int, KeyValuePair<int, int>>();
            UC_MonthCa.ButtonDate += buttonDate_Click;
            UC_MonthCa.UC_Calendar = this;
            DayChoosing = 0;
        }

        #region Methods
        public void init()
        {
            MONTH = DateTime.Now.Month;
            YEAR = DateTime.Now.Year;
            colorBack = Color.White;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 7; j++)
                {

                    btn[i, j] = new UC_Day();
                    btn[i, j].Click += UC_Calendar_New_Click;
                    btn[i, j].Dock = DockStyle.Fill;
                    btn[i, j].BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                    btn[i, j].ColorTextDay = ((colorBack == Color.White) ? Color.Black : Color.White);
                    tableLayoutPanel.Controls.Add(btn[i, j]);
                }
        }

        private void UC_Calendar_New_Click(object sender, EventArgs e)
        {
            UC_Day uc = sender as UC_Day;

            //Nếu nhấn vào một ngày trong tháng hiện tại
            if (uc.BackColor == Color.White)
            {
                IsClickOnUC_Day = true;
                DayChoosing = Convert.ToInt32(uc.Day);
                
                //Gọi đến event 
                buttonDate_Click(sender, e);
            }
        }

        public int getDay(int month, int year)
        {
            int N = year - 1;
            int d = N * 365 + N / 4 - N / 100 + N / 400;
            for (int i = 1; i < month; i++)
                d += UtilityClass.GetNumberOfDayInMonth(i, N + 1);
            return d;
        }

        //Determine thứ
        public int getThu(int month, int year)
        {
            //Cong them 2 de lay ra ten thu luon
            return getDay(month, year) % 7 + 2;
        }

        public void reset()
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 7; j++)
                {
                    btn[i, j].ColorDay = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                    btn[i, j].BoderDay = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                    btn[i, j].Size = new Size((int)(btn[i, j].Width * xRatio), (int)(btn[i, j].Height * yRatio));
                    btn[i, j].Location = new Point((int)(btn[i, j].Location.X * xRatio), (int)(btn[i, j].Location.Y * yRatio));
                    btn[i, j].BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                    btn[i, j].ColorTextDay = ((colorBack == Color.White) ? Color.Black : Color.White);
                    btn[i, j].HandleClickOnUC += UC_Calendar_New_Click;
                }
            formOriginalSize = this.Size;
        }

        public void update(int month, int year)
        {
            reset();
            int[,] a = new int[6, 7];
            int thu = getThu(month, year);
            int day = UtilityClass.GetNumberOfDayInMonth(month, year);
            //Previous day
            int pday = 0;
            if (month > 1)
                pday = UtilityClass.GetNumberOfDayInMonth(month - 1, year);
            else
                pday = UtilityClass.GetNumberOfDayInMonth(12, year - 1);
            int start = thu - 1;
            if (start == 7)
                start = 0;

            //Mỗi lần load lại lịch thì cũng Clear cái Dictionary chứa toạ độ của các button trong ma trận
            //trước đó
            if (IndexDayInMatrix.Count > 0)
                IndexDayInMatrix.Clear();
            int I = 0, J = start;
            for (int i = 1; i <= day; i++)
            {
                IndexDayInMatrix.Add(i, new KeyValuePair<int, int>(I, J));
                btn[I, J].DateValue = (i + "").PadLeft(2, '0') + "/" + ((MONTH + "").PadLeft(2, '0')) + "/" + YEAR;
                btn[I, J].Day = i.ToString();
                btn[I, J].ColorTextDay = ((colorBack == Color.White) ? Color.Black : Color.White);
                btn[I, J].BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                if (i == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year)
                {
                    btn[I, J].ColorDay = ((colorBack == Color.White) ? Color.FromArgb(215, 249, 249) : Color.FromArgb(238, 191, 109));
                    btn[I, J].BoderDay = ((colorBack == Color.White) ? Color.DeepSkyBlue : Color.FromArgb(238, 191, 109));
                }
                if (year != YEAR && MONTH == month + 1 && i == day)
                {
                    btn[I, J].BackColor = Color.Cyan;
                }
                J++;
                if (J == 7)
                {
                    J = 0;
                    I++;
                }
            }

            //Xác định phần ngày của tháng trước đó
            for (int i = start - 1; i >= 0; i--)
            {
                btn[0, i].Day = (pday-- + "");
                btn[0, i].ColorTextDay = ((colorBack == Color.White) ? Color.Gray : colorBack);
                btn[0, i].BackColor = ((colorBack == Color.White) ? Color.LightGray : colorBack);
                btn[0, i].ColorDay = ((colorBack == Color.White) ? Color.LightGray : colorBack);
                btn[0, i].BoderDay = ((colorBack == Color.White) ? Color.LightGray : colorBack);
            }

            //Xác định phần ngày của tháng sau đó
            int st = 1;
            while (!(I == 6 && J == 0))
            {
                btn[I, J].Day = (st++ + "");
                btn[I, J].ColorTextDay = ((colorBack == Color.White) ? Color.Gray : colorBack);
                btn[I, J].BackColor = ((colorBack == Color.White) ? Color.LightGray : colorBack);
                btn[I, J].ColorDay = ((colorBack == Color.White) ? Color.LightGray : colorBack);
                btn[I, J].BoderDay = ((colorBack == Color.White) ? Color.LightGray : colorBack);
                J++;
                if (J == 7)
                {
                    J = 0;
                    I++;
                }
            }
        }

        private void LoadListExamInMonth()
        {
            li = BaiKiemTra_BLL.Instance.GetListExamInMonth(MaSV, MONTH, YEAR);
            foreach (BaiKiemTra_DTO bkt in li)
            {
                int day = bkt.ThoiGianBatDau.Day;

                //Lấy ra vị trí của button có ngày 'day' trong ma trận
                KeyValuePair<int, int> pair = IndexDayInMatrix[day];
                UC_Day tmp = btn[pair.Key, pair.Value];
                tmp.listExams.Add(bkt);
                if (string.IsNullOrEmpty(btn[pair.Key, pair.Value].ExamName))
                {
                    tmp.ExamName = bkt.MaLoaiKiemTra;
                    if (bkt.MaLoaiKiemTra == "Giữa kỳ")
                    {
                        UC_MonthCa.btn[pair.Key, pair.Value].BackColor = Color.FromArgb(255, 192, 128);
                        UC_MonthCa.btn[pair.Key, pair.Value].BorderSize = 3;
                        UC_MonthCa.btn[pair.Key, pair.Value].BorderColor = Color.Red;
                    }
                    else if (bkt.MaLoaiKiemTra == "Cuối kỳ")
                    {
                        UC_MonthCa.btn[pair.Key, pair.Value].BackColor = Color.SpringGreen;
                        UC_MonthCa.btn[pair.Key, pair.Value].BorderSize = 3;
                        UC_MonthCa.btn[pair.Key, pair.Value].BorderColor = Color.FromArgb(0, 192, 0);
                    }
                    else if (bkt.MaLoaiKiemTra == "Test")
                    {
                        UC_MonthCa.btn[pair.Key, pair.Value].BackColor = Color.Gold;
                        UC_MonthCa.btn[pair.Key, pair.Value].BorderSize = 3;
                        UC_MonthCa.btn[pair.Key, pair.Value].BorderColor = Color.DarkGoldenrod;
                    }
                }
                else
                {
                    tmp.NumberOfExam++;
                    tmp.IfMore = "+ " + tmp.NumberOfExam + " More";
                }
            }
        }

        public void LoadDays()
        {
            update(MONTH, YEAR);
            LoadListExamInMonth();
            lbLoaiBaiKiemTra.Text = "";
            lbCacLopCoBaiKiemTra.Text = "";
            DayChoosing = 0;
        }

        private string GetStringMonth(int month)
        {
            string[] ds = {"","Tháng 1","Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6",
                "Tháng 7", "Tháng 8","Tháng 9","Tháng 10","Tháng 11","Tháng 12"};
            return ds[month];
        }
        #endregion


        #region Events
        private void Form2_Load(object sender, EventArgs e)
        {
            //Gọi event buttonDay_Click để hiển thị lịch của tháng hiện tại
            buttonToday_Click(sender, e);
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            //ButtonDateMonth này sẽ tham chiếu đến 1 button ở UC_MonthCalendar khi 1 button bên UC đó được nhấn
            if (IsClickOnUC_Day || ButtonDateMonth.BackColor != Color.LightGray)
            {
                //Nếu bấm vào button ở lịch nhỏ thì IsClickOnUC_Day = false
                if (!IsClickOnUC_Day)
                {
                    //Gán biến ngày đang chọn để khi muốn xem chi tiết sẽ biết ngày nào đang chọn 
                    DayChoosing = Convert.ToInt32(ButtonDateMonth.Text);
                }
                KeyValuePair<int, int> pair = IndexDayInMatrix[DayChoosing];
                UC_Day day = btn[pair.Key, pair.Value];
                lbLoaiBaiKiemTra.Text = day.ExamName;
                lbCacLopCoBaiKiemTra.Text = "";
                foreach (BaiKiemTra_DTO bkt in day.listExams)
                {
                    lbCacLopCoBaiKiemTra.Text += bkt.TieuDeBaiKiemTra + "\n";
                }

                //Nếu truớc đó bấm vào UC_Day và gán IsClickOnUC_Day = true thì giờ đây ta phải gán lại là false
                IsClickOnUC_Day = false;
            }
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (0 < DayChoosing && DayChoosing < UtilityClass.GetNumberOfDayInMonth(MONTH, YEAR))
            {
                KeyValuePair<int, int> pair = IndexDayInMatrix[DayChoosing];
                UC_Day day = btn[pair.Key, pair.Value];
                day.SeeMore();
            }
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            UC_MonthCa.LoadTodayDate();
            DateTime now = DateTime.Now;
            MONTH = now.Month;
            YEAR = now.Year;
            //btnDate.Text = GetStringMonth(MONTH) + "  " + YEAR;
            lbDate.Text = GetStringMonth(MONTH) + "  " + YEAR;
            LoadDays();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            UC_MonthCa.LoadNextDate();
            MONTH++;
            if (MONTH == 13)
            {
                YEAR++;
                MONTH = 1;
            }
            //btnDate.Text = GetStringMonth(MONTH) + "  " + YEAR;
            lbDate.Text = GetStringMonth(MONTH) + "  " + YEAR;
            LoadDays();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            UC_MonthCa.LoadPreviousDate();
            MONTH--;
            if (MONTH == 0)
            {
                YEAR--;
                MONTH = 12;
            }
            //btnDate.Text = GetStringMonth(MONTH) + "  " + YEAR;
            lbDate.Text = GetStringMonth(MONTH) + "  " + YEAR;
            LoadDays();
        }

        private void UC_Calendar_Resize(object sender, EventArgs e)
        {
            //29/3/2023: Edit by Tai -> Label nằm chính giữa của mỗi ngày
            double xRatio = this.Width * 1.0 / formOriginalSize.Width;
            double yRatio = this.Height * 1.0 / formOriginalSize.Height;

            tableLayoutPanel.Size = new Size((int)(tableLayoutPanel.Width * xRatio), (int)(tableLayoutPanel.Height * yRatio));
            tableLayoutPanel.Location = new Point((int)(tableLayoutPanel.Location.X * xRatio), (int)(tableLayoutPanel.Location.Y * yRatio));

            lbDate.Size = new Size((int)(lbDate.Width * xRatio), (int)(lbDate.Height * yRatio));
            lbDate.Location = new Point((int)(lbDate.Location.X * xRatio), (int)(lbDate.Location.Y * yRatio));

            int offset = tableLayoutPanel.Location.X;
            lbSunday.Size = new Size((int)(lbSunday.Width * xRatio), (int)(lbSunday.Height * yRatio));
            lbSunday.Location = new Point((int)(lbSunday.Location.X * xRatio), (int)(lbSunday.Location.Y * yRatio));

            lbMonday.Size = new Size((int)(lbMonday.Width * xRatio), (int)(lbMonday.Height * yRatio));
            int posX = offset + btn[0, 1].Location.X + (btn[0, 1].Width - lbMonday.Width) / 2;
            lbMonday.Location = new Point(posX, lbSunday.Location.Y);

            lbTuesday.Size = new Size((int)(lbTuesday.Width * xRatio), (int)(lbTuesday.Height * yRatio));
            posX = offset + btn[0, 2].Location.X + (btn[0, 1].Width - lbTuesday.Width) / 2;
            lbTuesday.Location = new Point(posX, lbSunday.Location.Y);

            lbWednesday.Size = new Size((int)(lbWednesday.Width * xRatio), (int)(lbWednesday.Height * yRatio));
            posX = offset + btn[0, 3].Location.X + (btn[0, 1].Width - lbWednesday.Width) / 2;
            lbWednesday.Location = new Point(posX, lbSunday.Location.Y);

            lbThursday.Size = new Size((int)(lbThursday.Width * xRatio), (int)(lbThursday.Height * yRatio));
            posX = offset + btn[0, 4].Location.X + (btn[0, 1].Width - lbThursday.Width) / 2;
            lbThursday.Location = new Point(posX, lbSunday.Location.Y);

            lbFriday.Size = new Size((int)(lbFriday.Width * xRatio), (int)(lbFriday.Height * yRatio));
            posX = offset + btn[0, 5].Location.X + (btn[0, 1].Width - lbFriday.Width) / 2;
            lbFriday.Location = new Point(posX, lbSunday.Location.Y);

            lbSaturday.Size = new Size((int)(lbSaturday.Width * xRatio), (int)(lbSaturday.Height * yRatio));
            posX = offset + btn[0, 6].Location.X + (btn[0, 1].Width - lbSaturday.Width) / 2;
            lbSaturday.Location = new Point(posX, lbSunday.Location.Y);

            btnNext.Size = new Size((int)(btnNext.Width * xRatio), (int)(btnNext.Height * yRatio));
            btnNext.Location = new Point((int)(btnNext.Location.X * xRatio), (int)(btnNext.Location.Y * yRatio));

            btnPrevious.Size = new Size((int)(btnPrevious.Width * xRatio), (int)(btnPrevious.Height * yRatio));
            btnPrevious.Location = new Point((int)(btnPrevious.Location.X * xRatio), (int)(btnPrevious.Location.Y * yRatio));

            buttonToday.Size = new Size((int)(buttonToday.Width * xRatio), (int)(buttonToday.Height * yRatio));
            buttonToday.Location = new Point((int)(buttonToday.Location.X * xRatio), (int)(buttonToday.Location.Y * yRatio));

            formOriginalSize = this.Size;
        }
        #endregion
    }
}
