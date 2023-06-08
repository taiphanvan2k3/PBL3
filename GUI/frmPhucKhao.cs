using GUI.MyUserControls;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPhucKhao : Form
    {
        public frmPhucKhao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_DapAnPhucKhao uc = new UC_DapAnPhucKhao() { state = UC_DapAnPhucKhao.StateAnswer.Correct };
            flowLayoutPanel.Controls.Add(uc);
            flowLayoutPanel.Height += uc.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_DapAnPhucKhao uc = new UC_DapAnPhucKhao() { state = UC_DapAnPhucKhao.StateAnswer.InCorrect };
            flowLayoutPanel.Controls.Add(uc);
            flowLayoutPanel.Height += uc.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_DapAnPhucKhao uc = new UC_DapAnPhucKhao() { state = UC_DapAnPhucKhao.StateAnswer.DoNot };
            flowLayoutPanel.Controls.Add(uc);
            flowLayoutPanel.Height += uc.Height;
        }

        private void flowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            //foreach(UC_DapAnPhucKhao uc in flowLayoutPanel.Controls)
            //{
            //    uc.Width = flowLayoutPanel.Width;
            //}    
        }
    }
}
