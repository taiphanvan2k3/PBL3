using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuiz : Form
    {
        #region Tài làm
        private List<CauHoi_DTO> questions;

        //Số thứ tự câu hỏi hiện tại (đếm từ 1, khi nào cần truy cập vào mảng questions thì giảm 1 đi)
        private int CurrentIndex = 1;
        private int AnsweredQuestion = 0;


        public SinhVien_DTO SinhVien { get; set; }

        //Thời gian hoàn thành bài của sinh viên này
        private DateTime StartTime;
        private DateTime SubmitTime;
        public int Time { get; set; }
        #endregion

        //Mạnh làm
        [DllImport("user32.dll")]
        static extern bool SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

        const uint WDA_NONE = 0x00000000;
        const uint WDA_MONITOR = 0x00000001;
        private Stopwatch stopwatch = new Stopwatch();
        private TimeSpan targetTime = TimeSpan.FromMinutes(50);

        public List<SelectedAnswer> selectedAnswers;
        public frmQuiz()
        {
            InitializeComponent();
            questions = new List<CauHoi_DTO>();
            SetWindowDisplayAffinity(this.Handle, WDA_MONITOR);
            selectedAnswers = new List<SelectedAnswer>();
        }

        private void testGiaoDien()
        {
            string TenCauHoi = "Hãy trả lời câu hỏi siêu dễ sau: 1+1=?";
            string DapAnA = "Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi." +
                "Tất nhiên là bằng 2 rồi. Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi." +
                "Tất nhiên là bằng 2 rồi. Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi. \nEnd A.";
            DapAnA += DapAnA;
            string DapAnB = "Dễ quá, bằng 2 chứ nhiêu.";
            DapAnB += "\n" + DapAnA + "\nEndB";
            string DapAnC = "Câu hỏi gì dễ thế, bằng 3?" +
                "Câu hỏi gì dễ thế, bằng 3?" +
                "Câu hỏi gì dễ thế, bằng 3?\nEndC";
            DapAnC += "\n" + DapAnB;
            string DapAnD = "Chắc là 0 :)";
            lblTenCauHoi.Text = DapAnB + "\n" + DapAnB + "\n" + DapAnB + "\nx3";
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rand = r.Next(2);
                CauHoi_DTO c = new CauHoi_DTO(TenCauHoi, DapAnA, DapAnB, DapAnC, DapAnD, "AB");
                if (rand == 1)
                    c.IsSingleQuestion = true;
                else c.IsSingleQuestion = false;
                questions.Add(c);
            }
        }
        private void LoadCauHoi()
        {
            testGiaoDien();
        }
        private void frmQuiz_Load(object sender, EventArgs e)
        {
            //Load tất cả câu hỏi của bộ đề và hiển thị
            LoadCauHoi();
            HienThiCauHoi(1);
            StartTime = DateTime.Now;
            lbTime.Text = targetTime.ToString(@"mm\:ss\:ff");
            stopwatch.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = stopwatch.Elapsed;
            TimeSpan remainingTime = targetTime - elapsedTime;

            if (remainingTime <= TimeSpan.Zero)
            {
                timer1.Stop();
                lbTime.Text = "00:00:00";
                CustomMessageBox.Show("Hết giờ");
            }
            else
            {
                lbTime.Text = remainingTime.ToString(@"mm\:ss\:ff");
            }
        }

        private void ResetChecked(FlowLayoutPanel panel)
        {
            //Reset check 
            foreach (Control c in panel.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = c as RadioButton;
                    rd.Checked = false;
                }
                else
                {
                    CheckBox cb = c as CheckBox;
                    cb.Checked = false;
                }
            }
        }

        private FlowLayoutPanel GetPanelIsVisible()
        {
            //Lấy ra panel single hay multi đang được visible
            FlowLayoutPanel panel = null;
            if (panelSingle.Visible)
                panel = panelSingle;
            else
                panel = panelMulti;
            return panel;
        }

        private void HienThiDapAnDaChon()
        {
            FlowLayoutPanel panel = GetPanelIsVisible();
            int idx = 0;
            List<int> IndexSelection = questions[CurrentIndex - 1].IndexSelection;
            if (panel == panelSingle)
            {
                foreach (RadioButton rd in panel.Controls)
                {
                    if (IndexSelection.Contains(idx))
                    {
                        rd.Checked = true;
                        break;
                    }
                    idx++;
                }
            }
            else
            {
                foreach (CheckBox cb in panel.Controls)
                {
                    if (IndexSelection.Contains(idx))
                        cb.Checked = true;
                    idx++;
                }
            }
        }

        private void HienThiCauHoi(int STT)
        {
            lblSTTCauHoi.Text = "Câu " + STT + "/" + questions.Count;
            CauHoi_DTO question = questions[STT - 1];
            FlowLayoutPanel panel = null;
            if (question.IsSingleQuestion)
            {
                panelSingle.Visible = true;
                panelMulti.Visible = false;
                panel = panelSingle;
            }
            else
            {
                panelSingle.Visible = false;
                panelMulti.Visible = true;
                panel = panelMulti;
            }

            //Vì dùng chung panel cho các câu hỏi nên trước khi hiển thị ra màn hình
            //phải uncheck tất cả đáp án đã chọn trước đó rồi hiển thị đáp án đã chọn của câu hiện tại
            ResetChecked(panel);
            HienThiDapAnDaChon();

            lblTenCauHoi.Height = UtilityClass.CalculateHeightOfControl(lblTenCauHoi) + 10;
            panel.Location = new System.Drawing.Point(panel.Location.X, lblTenCauHoi.Bounds.Bottom + 10);

            int idx = 0;
            int TotalHeight = 0;
            foreach (Control control in panel.Controls)
            {
                control.Text = question.DapAnHienThi[idx++];
                control.Height = UtilityClass.CalculateHeightOfControl(control) + 10;
                if (control == checkBoxD || control == radioButtonD)
                {
                    //Tính toán tổng chiều cao cần thiết của panel để chứa đủ 4 checkbox/radiobutton đó
                    TotalHeight = control.Location.Y + control.Height + control.Padding.Bottom + 10;
                }
            }

            panel.Height = TotalHeight;
            btnPreious.Location = new System.Drawing.Point(btnPreious.Location.X, panel.Bounds.Bottom + 40);
            btnNext.Location = new System.Drawing.Point(btnNext.Location.X, panel.Bounds.Bottom + 40);
            panelMain.Height = btnPreious.Bounds.Bottom + 100;
        }
        private void CheckAnswered()
        {
            bool check = false;
            FlowLayoutPanel panel = GetPanelIsVisible();

            List<int> IndexSelection = new List<int>();
            int idx = 0;
            foreach (Control c in panel.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rd = c as RadioButton;
                    if (rd.Checked)
                    {
                        check = true;
                        IndexSelection.Add(idx);
                        break;
                    }
                }
                else if (c is CheckBox)
                {
                    CheckBox cb = c as CheckBox;
                    if (cb.Checked)
                    {
                        check = true;
                        IndexSelection.Add(idx);
                    }
                }
                idx++;
            }

            if (check == true)
            {
                if (!questions[CurrentIndex - 1].Checked)
                {
                    //Nếu là câu hỏi 1 lựa chọn. Trước đây chưa lựa chọn đáp án nhưng bây giờ đã chọn
                    AnsweredQuestion++;
                }
            }
            else
            {
                //Nếu trước đây đã chọn nhưng giờ không chọn nữa (check == false) thì giảm câu hỏi đã chọn xuống
                //Chỉ rơi vào trường hợp panelMulti (panel này chọn xong có thể bỏ chọn được)
                if (questions[CurrentIndex - 1].Checked)
                    AnsweredQuestion--;
            }

            lbSoCauDaLam.Text = AnsweredQuestion + "";

            //Cập nhật trạng thái đã chọn hay chưa chọn cho câu hỏi này, đồng thời cập nhật lại thứ tự đáp án
            //đã chọn để lát hiển thị lại
            questions[CurrentIndex - 1].IndexSelection = IndexSelection;
            questions[CurrentIndex - 1].Checked = check;
        }

        private void btnPreious_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 1)
            {
                //Trước khi di chuyển qua câu hỏi khác thì phải kiểm tra câu hiện tại có được chọn
                //hay chưa để cập nhật lại trạng thái
                CheckAnswered();
                CurrentIndex--;
                HienThiCauHoi(CurrentIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < questions.Count)
            {
                //Trước khi di chuyển qua câu hỏi khác thì phải kiểm tra câu hiện tại có được chọn
                //hay chưa để cập nhật lại trạng thái
                CheckAnswered();
                CurrentIndex++;
                HienThiCauHoi(CurrentIndex);
            }
        }

        private int SoCauDung()
        {
            int res = 0;
            foreach (CauHoi_DTO cauHoi in questions)
                res += (cauHoi.CheckCorrectAnswer()) ? 1 : 0;
            return res;
        }
        private void btnNopBai_Click(object sender, EventArgs e)
        {
            CheckAnswered();
            timer1.Stop();
            MessageBox.Show(SoCauDung() + "");
            SubmitTime = DateTime.Now;
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
