using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            /*string path = @"Data Source=THANHNGAN13\SQLEXPRESS;Initial Catalog=testPbl;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(path);
            cnn.Open();*/
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //PHẦN NÀY T KẾT NỐI VỚI DATABASE CỦA T 
            string path = @"Data Source=THANHNGAN13\SQLEXPRESS;Initial Catalog=testPbl;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(path);
            cnn.Open();
            string userValid = txtUserName.Text.ToString();
            string passwordValid = txtPassword.Text.ToString();
            string requried = "SELECT Account.ID, Account.Passwords, Account.Flag FROM Account WHERE Account.ID = '" + userValid + "'AND Account.Passwords = '" + passwordValid + "'";
            SqlCommand cmd = new SqlCommand(requried, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
               
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            cnn.Close();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
