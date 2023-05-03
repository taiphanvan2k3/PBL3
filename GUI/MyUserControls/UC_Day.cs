using DTO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_Day : UserControl
    {
        public UC_Day()
        {
            InitializeComponent();
            listExams = new List<BaiKiemTra_DTO>();
        }
        #region Properties
        public List<BaiKiemTra_DTO> listExams;
        public string DateValue { get; set; }
        public int NumberOfExam { get; set; } = 0;
        public string Day
        {
            get => btnDay.Text;
            set
            {
                //Mỗi khi thay đổi Day thì cập nhật lại số lượng Exam trong ngày đó, tên Exam đầu tiên
                btnDay.Text = value;
                NumberOfExam = 0;
                ExamName = "";
                IfMore = "";
                PanelEventColor = Color.Transparent;
                listExams.Clear();
            }
        }
        public Color BoderDay
        {
            get => btnDay.BorderColor;
            set => btnDay.BorderColor = value;
        }
        public Color ColorDay
        {
            get => btnDay.BackColor;
            set => btnDay.BackColor = value;
        }
        public Color ColorTextDay
        {
            get => btnDay.ForeColor;
            set => btnDay.ForeColor = value;
        }
        public string ExamName
        {
            get => lbExam.Text;
            set
            {
                if (value == "Giữa kỳ")
                    this.PanelEventColor = Color.FromArgb(255, 192, 128);
                else if (value == "Cuối kỳ")
                    this.PanelEventColor = Color.SpringGreen;
                else if (value == "Test")
                    this.PanelEventColor = Color.Gold;
                lbExam.Text = value;

            }
        }
        public string IfMore
        {
            get => lbIfMore.Text;
            set => lbIfMore.Text = value;
        }
        public Color PanelEventColor
        {
            get => pnlEvent.BackColor;
            set => pnlEvent.BackColor = value;
        }
        #endregion
        public void SeeMore()
        {
            if (!string.IsNullOrEmpty(DateValue))
            {
                MessageBox.Show("Số bài kiểm tra trong ngày:" + listExams.Count);
                Form frmExam = this.ParentForm;
                frmShowEventInDay frm = new frmShowEventInDay();
                frm.Date = DateValue;
                frm.listExams = listExams;
                frm.Location = new Point(frmExam.Location.X + (frmExam.Width - frm.Width) / 2, frmExam.Location.Y + 100);
                frm.ShowDialog();
            }
        }
        private void pblEvent_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(DateValue))
            {
                MessageBox.Show("Số bài kiểm tra trong ngày:" + listExams.Count);
                Form frmExam = this.ParentForm;
                frmShowEventInDay frm = new frmShowEventInDay();
                frm.Date = DateValue;
                frm.listExams = listExams;
                frm.Location = new Point(frmExam.Location.X + (frmExam.Width - frm.Width) / 2, frmExam.Location.Y + 100);
                frm.ShowDialog();
            }
        }
    }
}
