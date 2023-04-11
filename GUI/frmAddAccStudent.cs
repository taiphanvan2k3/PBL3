using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAddAccStudent : Form
    {

        private string MSSV = "";
        private string MaKhoa = "";
        private string MaCTDT = "";

        private string Email = "";

        private string passID = "";
        private string passEmai = "";
        public frmAddAccStudent()
        {
            InitializeComponent();
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void LoadData()
        {
            foreach (var item in GetInformationAcc_BLL.Instance.GetListEducationProgram())
            {
                cmbList.Items.Add(item.TenCTDT);
            }
        }
        #region Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void cmbList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbList.SelectedIndex != -1) {
                MaKhoa = "";
                MaCTDT = "";
                foreach (var item in GetInformationAcc_BLL.Instance.GetListEducationProgram())
                {
                    if(cmbList.SelectedItem.ToString() == item.TenCTDT.ToString())
                    {
                        MaKhoa += item.MaKhoa;
                        MaCTDT += item.MaCTDT;
                        break;
                    }
                }
            }
        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {
            Email = "";
            passID = "";
            passEmai = "";
            Random random = new Random();
            int year = dtpBirthday.Value.Year;
            if (year < 2000)
            {
                year = year % 100 - 82;
            }
            else
            {
                year = year % 2000 + 18;
            }
            MSSV = MaKhoa + year.ToString() + (GetInformationAcc_BLL.Instance.GetCountStudent() + 1).ToString();
            Email = MSSV + "SV@emailling.xyz";
            MessageBox.Show(MSSV + "-" + Email);
        }
    }
}
