using BLL;
using DTO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_DapAnPhucKhao : UserControl
    {
        public enum StateAnswer
        {
            Correct,
            InCorrect,
            DoNot
        }

        public StateAnswer state
        {
            set
            {
                if (value == StateAnswer.Correct)
                    BackColor = Color.LightGreen;
                else if (value == StateAnswer.InCorrect)
                    BackColor = Color.LightCoral;
                else
                    BackColor = Color.LightSalmon;
            }
        }

        public void SetAnswers(string soThuTu, CauHoi_DTO cauHoi)
        {
            if (string.IsNullOrEmpty(cauHoi.maDapAnChon))
            {
                this.state = StateAnswer.DoNot;
                lblSTT.Text = "Câu " + soThuTu + " (Chưa làm)";
            }
            else if (cauHoi.maDapAnChon != cauHoi.maDapAnDung)
            {
                this.state = StateAnswer.InCorrect;
                lblSTT.Text = "Câu " + soThuTu + " (Sai)";
            }
            else
            {
                this.state = StateAnswer.Correct;
                lblSTT.Text = "Câu " + soThuTu + " (Đúng)";
            }
            lblTenCauHoi.Location = new Point(lblTenCauHoi.Location.X, lblSTT.Bottom + 5);
            lblTenCauHoi.Text = cauHoi.TenCauHoi;
            int originalHeightCauHoi = lblTenCauHoi.Height;
            lblTenCauHoi.Height = UtilityClass.CalculateHeightOfControl(lblTenCauHoi) + 10;
            flowPanelAnswer.Location = new System.Drawing.Point(flowPanelAnswer.Location.X, lblTenCauHoi.Bounds.Bottom);
            this.Height += lblTenCauHoi.Height - originalHeightCauHoi;
            bool isSingleQuestion = cauHoi.maDapAnDung.Length == 1;
            int totalHeight = 0;
            if (isSingleQuestion)
            {
                int index = -1;
                if (!string.IsNullOrEmpty(cauHoi.maDapAnChon))
                    index = cauHoi.maDapAnChon[0] - 'A';
                for(int i = 0;i < 4;i++)
                {
                    bool isSelectedAnswer = i == index;
                    RadioButton rd = new RadioButton()
                    {
                        Text = cauHoi.DapAnHienThi[i],
                        Enabled = false,
                        Checked = isSelectedAnswer,
                        Width = flowPanelAnswer.Width - 10
                    };
                    rd.Height = UtilityClass.CalculateHeightOfControl(rd);
                    totalHeight += rd.Height;
                    flowPanelAnswer.Controls.Add(rd);
                }
                
            }
            else
            {
                List<int> listIndex = new List<int>();
                foreach(char c in cauHoi.maDapAnChon)
                    listIndex.Add(c - 'A');
                for(int i = 0;i < 4;i++)
                {
                    bool isSelectedAnswer = listIndex.Contains(i);
                    CheckBox cb = new CheckBox()
                    {
                        Text = cauHoi.DapAnHienThi[i],
                        Enabled = false,
                        Checked = isSelectedAnswer,
                        Width = flowPanelAnswer.Width - 10
                    };
                    cb.Height = UtilityClass.CalculateHeightOfControl(cb);
                    totalHeight += cb.Height;
                    flowPanelAnswer.Controls.Add(cb);
                }
            }
            flowPanelAnswer.Height = totalHeight + 50;
            if (this.BackColor == Color.LightGreen)
            {
                label1.Text = "";
                this.Height = flowPanelAnswer.Bottom + 10;
            }
            else
            {
                label1.Location = new Point(label1.Location.X, flowPanelAnswer.Bottom + 5);
                lbDapAnDung.Location = new Point(lbDapAnDung.Location.X, flowPanelAnswer.Bottom + 5);
                if(cauHoi.maDapAnDung.Length == 1)
                    lbDapAnDung.Text = cauHoi.maDapAnDung;
                else
                {
                    string dapAnDung = "";
                    for(int i = 0;i < cauHoi.maDapAnDung.Length;i++)
                    {
                        dapAnDung += cauHoi.maDapAnDung[i];
                        if(i < cauHoi.maDapAnDung.Length - 1)
                            dapAnDung += ", ";
                    }
                    lbDapAnDung.Text = dapAnDung;
                }
                this.Height = label1.Bottom + 10;
            }
        }

        public UC_DapAnPhucKhao()
        {
            InitializeComponent();
        }

        private void flowPanelAnswer_SizeChanged(object sender, System.EventArgs e)
        {
            foreach(Control control in flowPanelAnswer.Controls)
            {
                control.Width = flowPanelAnswer.Width - 10;
            }
        }
    }
}
