using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin1 : Form
    {
        public frmLogin1()
        {

            InitializeComponent();
            btnDoNotShow.BringToFront();
        }

        // Custom Minisize and Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Ẩn hiện pasword
        private void btnDoNotShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar)
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = false;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(!txtPassword.PasswordChar)
            {
                btnDoNotShow.BringToFront();
                txtPassword.PasswordChar = true;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = true;
            btnDoNotShow.BringToFront();
        }
        // Nút quên mật khẩu
        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quên mật khẩu");
        }

        private void btnForgetPass_MouseHover(object sender, EventArgs e)
        {
            btnForgetPass.Font = new Font(btnForgetPass.Font, FontStyle.Underline);
            btnForgetPass.ForeColor = Color.HotPink;
        }

        private void btnForgetPass_MouseLeave(object sender, EventArgs e)
        {
            btnForgetPass.Font = new Font(btnForgetPass.Font, FontStyle.Regular);
            btnForgetPass.ForeColor = Color.Black;
        }
        // Đăng nhập
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=THANHNGAN13\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True");
            string pass = txtPassword.Texts.ToString();
            string query = "SELECT * FROM dbo.THONG_TIN_DANG_NHAP WHERE dbo.THONG_TIN_DANG_NHAP.TaiKhoan = '" + txtUsername.Texts.ToString() + /*"'AND dbo.THONG_TIN_DANG_NHAP.MkUngDung = '" + txtPassword.Texts.ToString() + */"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1 && BCrypt.Net.BCrypt.Verify(pass, dtbl.Rows[0]["MkUngDung"].ToString()) == true)
            {
                if (dtbl.Rows[0]["VaiTro"].ToString() == "GV")
                {
                    MessageBox.Show("Đăng nhập với tư cách giáo viên");
                }
                else if (dtbl.Rows[0]["VaiTro"].ToString() == "SV")
                {
                    MessageBox.Show("Đăng nhập với tư cách sinh viên");

                }
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void frmLogin1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=THANHNGAN13\SQLEXPRESS;Initial Catalog=PBL3;Integrated Security=True");
            cnn.Open();
        }
    }
}
