using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Math;
using ServiceStack;
using ServiceStack.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class Form2 : Form
    {
        int MONTH, YEAR;
        Button[,] btn = new Button[7, 7];
        String[,] dTime = new String[7, 7];
        public Form2()
        {
            InitializeComponent();
            init();
        }
        //Methods
        #region Methods
        public void init()
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Font = new Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn[i, j].Size = new Size(130, 80);
                    btn[i, j].BackColor = Color.White;
                    btn[i, j].ForeColor = Color.Black;
                    flowLayoutPanel1.Controls.Add(btn[i, j]);
                }
        }
        //Kiem tra nam nhuan
        public static bool isLeapYear(BigInteger N)
        {
            if (N.Mod(toBig(4)).CompareTo(toBig(0)) == 0 && N.Mod(toBig(100)).CompareTo(toBig(0)) != 0)
                return true;
            if (N.Mod(toBig(400)).CompareTo(toBig(0)) == 0)
                return true;
            return false;
        }
        //Determine number of day in the month
        public static int Nday(int month, BigInteger year)
        {
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (isLeapYear(year))
                        return 29;
                    return 28;
            }
            return 0;
        }
        //Tinh so ngay tu 01/01/0001 -> nay
        /*public static int getDay(int month, int year)
        {
            int N = year - 1;
            int days = N*365 + N/4 - N/100 + N/400;
            for(int i  = 1; i < month; i++)
            {
                days += Nday(i, N + 1);
            }
            return days;
        }*/
        public static BigInteger toBig(int s)
        {
            return new BigInteger(s.ToString());
        }
        public String leng2(String s)
        {
            if (s.Length == 1)
                return "0" + s;
            return s;
        }
        //Determine thứ
        public static int getThu(int month, BigInteger year)
        {
            year = year.Subtract(toBig(1));
            BigInteger d = year;
            d = year.Divide(toBig(4));
            d = d.Subtract(year.Divide(toBig(100)));
            d = d.Add(year.Divide(toBig(400)));
            d = d.Add(year.Multiply(toBig(365)));
            for (int i = 1; i < month; i++)
                d = d.Add(toBig(Nday(i, year.Add(toBig(1)))));
            //		System.out.println(d);
            d = d.Mod(toBig(7)).Add(toBig(2));
            return Convert.ToInt32(d.ToString());
            //Cong them 2 de lay ra ten thu luon
            //return getDay(month, year) % 7 + 2;
        }
        public void reset()
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                {
                    btn[i, j].BackColor = Color.White;
                    btn[i, j].ForeColor = Color.White;
                    dTime[i, j] = "";
                }
        }
        public int[,] update(int month, BigInteger year)
        {
            reset();
            int[,] a = new int[6, 7];
            int thu = getThu(month, year);
            int day = Nday(month, year);
            //Previous day
            int pday = 0;
            if (month > 1)
                pday = Nday(month - 1, year);
            else
                pday = Nday(12, year.Subtract(toBig(1)));
            int start = thu - 1;
            if (start == 7)
                start = 0;
            int I = 0, J = start;
            for (int i = 1; i <= day; i++)
            {
                btn[I, J].Text = i.ToString();
                btn[I, J].ForeColor = Color.Black;
                dTime[I, J] = leng2(i + "") + "-" + leng2(month + "") + "-" + year;
                if (year.CompareTo(toBig(YEAR)) == 0 && MONTH == month + 1 && i == day)
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
            //Determine phần ngày của tháng trước đó
            for (int i = start - 1; i >= 0; i--)
            {
                btn[0, i].Text = (pday-- + "");
                btn[0, i].BackColor = Color.Gray;
            }
            //Determine phần ngày của tháng sau đó
            int st = 1;
            while (!(I == 6 && J == 0))
            {
                btn[I, J].Text = (st++ + "");
                btn[I, J].BackColor = Color.Gray;
                J++;
                if (J == 7)
                {
                    J = 0;
                    I++;
                }
            }
            return a;
        }
        private void LoadDays()
        {
            BigInteger Year_new = toBig(YEAR);
            int[,] a = update(MONTH, Year_new);
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
                        if(j != 6)
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
                    if(check == 0 || check == 2)
                    {
                        UserControlBlank ucBlank = new UserControlBlank();
                        ucBlank.Days(a[i, j]);
                        //dayContainer.Controls.Add(ucBlank);
                    }
                    else
                    {
                        UserControlDays ucDays = new UserControlDays();
                        ucDays.Days(a[i, j]);
                        //dayContainer.Controls.Add(ucDays);
                    }
                }
            }
        }
        /*private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname + " " + year;
            //Lay ngay dau tien trong thang
            DateTime startOfMonth = new DateTime(year, month, 1);
            //Lay so ngay trong thang
            int days = DateTime.DaysInMonth(year, month);
            //convert the startOfMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
            }
        }*/
        #endregion
        //Events
        #region Events
        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MONTH = now.Month;
            YEAR = now.Year;
            LoadDays();
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            MONTH++;
            if(MONTH == 13)
            {
                YEAR++;
                MONTH = 1;
            }
            //dayContainer.Controls.Clear();
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(MONTH);
            lbDate.Text = monthname + " " + YEAR;
            LoadDays();
            //Lay ngay dau tien trong thang
            /*DateTime startOfMonth = new DateTime(year, month, 1);
            //Lay so ngay trong thang
            int days = DateTime.DaysInMonth(year, month);
            //convert the startOfMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            MONTH--;
            if (MONTH == 0)
            {
                YEAR--;
                MONTH = 12;
            }
            //dayContainer.Controls.Clear();
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(MONTH);
            lbDate.Text = monthname + " " + YEAR;
            LoadDays();
            //Lay ngay dau tien trong thang
            /*DateTime startOfMonth = new DateTime(year, month, 1);
            //Lay so ngay trong thang
            int days = DateTime.DaysInMonth(year, month);
            //convert the startOfMonth to integer
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucBlank = new UserControlBlank();
                dayContainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucDays = new UserControlDays();
                ucDays.Days(i);
                dayContainer.Controls.Add(ucDays);
            }*/
        }
        #endregion
    }
}
