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

        private string ID_User = "";
        private string MaKhoa = "";
        private string MaCTDT = "";

        private string Email = "";

        private string passID = "";
        private string passEmai = "";

        private int role;
        public frmAddAccStudent(int role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void LoadData()
        {

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
            if (cmbList.SelectedIndex != -1)
            {
                MaKhoa = "";
                MaCTDT = "";
                if (role == 0)
                {
                    foreach (var item in GetInformationAcc_BLL.Instance.GetListEducationProgram())
                    {
                        if (cmbList.SelectedItem.ToString() == item.TenCTDT.ToString())
                        {
                            MaKhoa += item.MaKhoa;
                            MaCTDT += item.MaCTDT;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var item in GetInformationAcc_BLL.Instance.GetListFaculty())
                    {
                        if (cmbList.SelectedItem.ToString() == item.TenKhoa.ToString())
                        {
                            MaKhoa += item.MaKhoa;
                            break;
                        }
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
            if (cmbList.SelectedIndex == -1 || cmbYearOrLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }

            else
            {
                if (role == 0)
                {

                    ID_User = MaKhoa + cmbYearOrLevel.SelectedItem.ToString().Substring(2) + (GetInformationAcc_BLL.Instance.GetCountStudent() + 1).ToString();
                    Email = ID_User + "SV@emailling.xyz";
                }
                else
                {
                    ID_User = MaKhoa + "BK" + (GetInformationAcc_BLL.Instance.GetCountTeacher() + 1).ToString();
                    Email = ID_User + "GV@emailling.xyz";
                }
            }

            int pass1 = random.Next(100000, 999999);
            int pass2 = random.Next(100000, 999999);
            passID = pass1.ToString();
            passEmai = pass2.ToString();
            MessageBox.Show(ID_User + "\n" + passID + "\n" + Email + "\n" + passEmai);
        }

        private void frmAddAccStudent_Load(object sender, EventArgs e)
        {
            if (role == 0)
            {
                List<string> list = new List<string>()
                {
                    "2020", "2021", "2022", "2023"
                };
                cmbYearOrLevel.Items.AddRange(list.ToArray());
                foreach (var item in GetInformationAcc_BLL.Instance.GetListEducationProgram())
                {
                    cmbList.Items.Add(item.TenCTDT);
                }
            }
            else
            {
                lbFacultyOrProgram.Text = "Tên khoa";
                lbYearOrLevel.Text = "Trình độ";
                List<string> trinhDo = new List<string>()
                {
                    "Tiến sĩ", "Thạc Sĩ", "Phó Giáo Sư - Tiến sĩ", "Giáo sư - Tiến sĩ"
                };
                cmbYearOrLevel.Items.AddRange(trinhDo.ToArray());
                foreach (var item in GetInformationAcc_BLL.Instance.GetListFaculty())
                {
                    cmbList.Items.Add(item.TenKhoa);
                }
            }
        }
    }
}
