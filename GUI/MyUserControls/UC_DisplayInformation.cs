using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace GUI.MyUserControls
{
    public partial class UC_DisplayInformation : UserControl
    {
        public UC_DisplayInformation()
        {
            InitializeComponent();
            loadData();
        }
        public Image coverByteArrayToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        public void loadData()
        {
            DataRow dt = frmLogin.dataUser;

            lbIDGV.Text = dt["MaGV"].ToString();
            lbFirstName.Text = dt["Ho"].ToString();
            lbName.Text = dt["Ten"].ToString();
            circularPictureBox1.Image = coverByteArrayToImage((byte[])dt["AnhCaNhan"]);
            lbBirthDay.Text = dt["NgaySinh"].ToString();
            lbSex.Text = dt["GioiTinh"].ToString();
            lbAddress.Text = dt["DiaChi"].ToString();
            lbEmailCaNhan.Text = dt["EmailCaNhan"].ToString();
            labelPhone.Text = dt["Sdt"].ToString();
            lbLevel.Text = dt["TrinhDo"].ToString();
            lbWage.Text = dt["Luong"].ToString();
            lbIDFaculty.Text = dt["MaKhoa"].ToString();
        }
    }
}
