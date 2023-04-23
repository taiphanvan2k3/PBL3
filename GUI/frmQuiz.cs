using DTO;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Management;
using System.Windows.Threading;
using System.Runtime.InteropServices;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class frmQuiz : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

        const uint WDA_NONE = 0x00000000;
        const uint WDA_MONITOR = 0x00000001;
        private Stopwatch stopwatch = new Stopwatch();
        private TimeSpan targetTime = TimeSpan.FromMinutes(50);
        public List<CauHoi_DTO1> questions;
        public List<SelectedAnswer> selectedAnswers;
        public frmQuiz()
        {
            InitializeComponent();
            SetWindowDisplayAffinity(this.Handle, WDA_MONITOR);
            questions = new List<CauHoi_DTO1>();
            selectedAnswers = new List<SelectedAnswer>();
        }
        #region Properties
        public SinhVien_DTO SinhVien { get; set; }
        public int Time { get; set; }

        #endregion
        private void frmQuiz_Load(object sender, EventArgs e)
        {
            
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

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
