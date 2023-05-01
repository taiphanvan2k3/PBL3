using BLL;
using DTO;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTestExam : Form
    {
        public frmTestExam()
        {
            InitializeComponent();
        }

        private void frmTestExam_Load(object sender, EventArgs e)
        {
            //string TenCauHoi = "Hãy trả lời câu hỏi siêu dễ sau: 1+1=?";
            //string DapAnA = "Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi." +
            //    "Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi." +
            //    "Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.Tất nhiên là bằng 2 rồi.End.";
            //DapAnA += DapAnA;
            //string DapAnB = "Dễ quá, bằng 2 chứ nhiêu.";
            //string DapAnC = "Câu hỏi gì dễ thế, bằng 3?" +
            //    "Câu hỏi gì dễ thế, bằng 3?" +
            //    "Câu hỏi gì dễ thế, bằng 3?";
            //string DapAnD = "Chắc là 0 :)";
            //CauHoi_DTO c = new CauHoi_DTO(TenCauHoi, DapAnA, DapAnB, DapAnC, DapAnD, "AB");
            //int idx = 0;
            //foreach (RadioButton rd in panelSingle.Controls)
            //{
            //    rd.Text = c.DapAnHienThi[idx++];
            //    Size txtSize = TextRenderer.MeasureText(rd.Text, rd.Font, rd.ClientRectangle.Size, TextFormatFlags.WordBreak);
            //    // Get the height of a single line of text
            //    int lineHeight = radioButtonD.Font.Height;

            //    // Calculate the number of lines required to display the text
            //    int numLines = (int)Math.Ceiling((double)txtSize.Height / lineHeight);

            //    // Calculate the height required to display the text
            //    int textHeight = numLines * lineHeight;

            //    rd.Height = textHeight + 10;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = SinhVien_BLL.GetKetQuaHocTap("102210043");
        }
    }
}
