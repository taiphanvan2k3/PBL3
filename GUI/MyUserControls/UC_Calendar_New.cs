using BLL;
using DTO;
using GUI.MyCustomControl;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_Calendar_New : UserControl
    {
        #region Properties
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
        CustomButton[,] btnM = new CustomButton[6, 7];
        string[,] dTime = new string[6, 7];
        List<BaiKiemTra_DTO> li = new List<BaiKiemTra_DTO>();
        //Lưu lại vị trí [i,j] của button có ngày tương ứng trên ma trận
        //vd Button ngày 1 nằm ở vị trí [0,4] thì thêm vào Dictionary <1,KeyValuePair<0,4>>
        Dictionary<int, KeyValuePair<int, int>> IndexDayInMatrix;
        int DayChoosing;
        public UC_Calendar_New()
        {
            InitializeComponent();
            init();
            formOriginalSize = this.Size;
            IndexDayInMatrix = new Dictionary<int, KeyValuePair<int, int>>();
            UC_MonthCa.ButtonPrevious += btnPrevious_Click;
            UC_MonthCa.ButtonToday += buttonToday_Click;
            UC_MonthCa.ButtonNext += btnNext_Click;
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
                    //Calendar small
                    /*btnM[i, j] = new CustomButton();
                    btnM[i, j].BorderSize = 1;
                    btnM[i, j].BorderColor = Color.LightGray;
                    btnM[i, j].BorderRadius = 40;
                    btnM[i, j].Font = new Font("Lucida Handwriting", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnM[i, j].Size = new Size(152, 82);
                    btnM[i, j].FlatStyle = FlatStyle.Flat;
                    btnM[i, j].FlatAppearance.BorderSize = 1;
                    btnM[i, j].BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                    btnM[i, j].ForeColor = ((colorBack == Color.White) ? Color.Black : Color.White);
                    btnM[i, j].Click += buttonDate_Click;
                    tableLayoutPanelM.Controls.Add(btnM[i, j]);*/
                    //Calendar big
                    btn[i, j] = new UC_Day();
                    btn[i, j].Dock = DockStyle.Fill;
                    btn[i, j].BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                    btn[i, j].ColorTextDay = ((colorBack == Color.White) ? Color.Black : Color.White);
                    tableLayoutPanel.Controls.Add(btn[i, j]);
                }
        }

        public string leng2(String s)
        {
            if (s.Length == 1)
                return "0" + s;
            return s;
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
                    //Calendar small
                    /*btnM[i, j].Enabled = true;
                    btnM[i, j].BorderSize = 1;
                    btnM[i, j].Font = new Font("Segoe UI", 8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold)), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnM[i, j].BorderColor = Color.LightGray;
                    btnM[i, j].Size = new Size((int)(btn[i, j].Width * xRatio), (int)(btn[i, j].Height * yRatio));
                    btnM[i, j].Location = new Point((int)(btn[i, j].Location.X * xRatio), (int)(btn[i, j].Location.Y * yRatio));
                    btnM[i, j].BackColor = ((colorBack == Color.White) ? Color.WhiteSmoke : Color.FromArgb(58, 59, 60));
                    btnM[i, j].ForeColor = ((colorBack == Color.White) ? Color.Black : Color.WhiteSmoke);*/
                    //Calendar big
                    btn[i, j].ColorDay = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                    btn[i, j].BoderDay = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                    btn[i, j].Size = new Size((int)(btn[i, j].Width * xRatio), (int)(btn[i, j].Height * yRatio));
                    btn[i, j].Location = new Point((int)(btn[i, j].Location.X * xRatio), (int)(btn[i, j].Location.Y * yRatio));
                    btn[i, j].BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                    btn[i, j].ColorTextDay = ((colorBack == Color.White) ? Color.Black : Color.White);
                    dTime[i, j] = "";
                }
            formOriginalSize = this.Size;
        }
        public int[,] update(int month, int year)
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
            if (IndexDayInMatrix.Count > 0)
                IndexDayInMatrix.Clear();
            int I = 0, J = start;
            for (int i = 1; i <= day; i++)
            {
                IndexDayInMatrix.Add(i, new KeyValuePair<int, int>(I, J));
                //Calendar small
                //btnM[I, J].Text = i.ToString();
                //Calendar big
                btn[I, J].DateValue = (i + "").PadLeft(2, '0') + "/" + ((MONTH + "").PadLeft(2, '0')) + "/" + YEAR;
                btn[I, J].Day = i.ToString();
                btn[I, J].ColorTextDay = ((colorBack == Color.White) ? Color.Black : Color.White);
                btn[I, J].BackColor = ((colorBack == Color.White) ? Color.White : Color.FromArgb(58, 59, 60));
                if (i == DateTime.Now.Day && month == DateTime.Now.Month && year == DateTime.Now.Year)
                {
                    //Calendar small
                    /*btnM[I, J].BorderSize = 3;
                    btnM[I, J].BorderColor = Color.DeepSkyBlue;
                    btnM[I, J].BackColor = ((colorBack == Color.White) ? Color.FromArgb(215, 249, 249) : Color.FromArgb(238, 191, 109));*/
                    //Calendar big
                    btn[I, J].ColorDay = ((colorBack == Color.White) ? Color.FromArgb(215, 249, 249) : Color.FromArgb(238, 191, 109));
                    btn[I, J].BoderDay = ((colorBack == Color.White) ? Color.DeepSkyBlue : Color.FromArgb(238, 191, 109));
                }
                dTime[I, J] = leng2(i + "") + "-" + leng2(month + "") + "-" + year;
                if (year != YEAR && MONTH == month + 1 && i == day)
                {
                    //Calendar small
                    //btnM[I, J].BackColor = Color.Cyan;
                    //Calendar big
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
                //Calendar small
                /*btnM[0, i].Enabled = false;
                btnM[0, i].Text = (pday-- + "");
                btnM[0, i].BackColor = ((colorBack == Color.White) ? Color.LightGray : colorBack);*/
                //Calendar big
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
                //Calendar small
                /*btnM[I, J].Enabled = false;
                btnM[I, J].Text = (st++ + "");
                btnM[I, J].BackColor = ((colorBack == Color.White) ? Color.LightGray : colorBack);*/
                //Calendar big
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
            return a;
        }

        private void LoadListExamInMonth()
        {
            li = BaiKiemTra_BLL.Instance.GetListExamInMonth(MONTH, YEAR);
            //MessageBox.Show("Số exam trong tháng hiện tại:" + li.Count);
            foreach(BaiKiemTra_DTO bkt in li)
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
            int[,] a = update(MONTH, YEAR);
            LoadListExamInMonth();
            int check = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (check == 0 && (j != 0 && a[i, j] < a[i, j - 1]))
                    {
                        check++;
                    }
                    if (check == 1)
                    {
                        if (j != 6)
                        {
                            if (a[i, j] > a[i, j + 1])
                                check++;
                        }
                        else
                        {
                            if (i == 5)
                                check++;
                            else if (a[i, j] > a[i + 1, 0])
                                check++;
                        }
                    }
                }
            }
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

        private string GetDateOnButton(Button e)
        {
            string res = "";
            /*
             * 28/2/2023: hello
             * select *from baiKiemTra
             * where month(ngaykiemtra)=@p1 and year(ngaykiemtra)=@p2
             * Mình sẽ truyền @p1 -> giá trị tháng hiện tại, @p2 -> giá trị của năm hiện tại
             * -> Trả về 1 List<Job> trong đó Job chứa DateTime, tên sự kiện, 
             * for cho button, mỗi button đi vào List kiếm , nếu xuất hiện sự kiện thì break
             * hiển thị form và add sự kiện vào cho form hiển thị
             */
            return res;
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
            //Button button = sender as Button;
            if (ButtonDateMonth.BackColor != Color.LightGray)
            {
                //Gán biến ngày đang chọn để khi muốn xem chi tiết sẽ biết ngày nào đang chọn 
                DayChoosing = Convert.ToInt32(ButtonDateMonth.Text);
                KeyValuePair<int, int> pair = IndexDayInMatrix[DayChoosing];
                UC_Day day = btn[pair.Key, pair.Value];
                lbLoaiBaiKiemTra.Text = day.ExamName;
                lbCacLopCoBaiKiemTra.Text = "";
                foreach (BaiKiemTra_DTO bkt in day.listExams)
                {
                    lbCacLopCoBaiKiemTra.Text += bkt.TieuDeBaiKiemTra + "\n";
                }
            }
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(0 < DayChoosing && DayChoosing < UtilityClass.GetNumberOfDayInMonth(MONTH,YEAR))
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
