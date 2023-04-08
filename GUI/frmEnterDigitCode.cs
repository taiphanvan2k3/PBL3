using BLL;
using DTO;
using GUI.MyCustomControl;
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
    public partial class frmEnterDigitCode : Form
    {
        private THONG_TIN_DANG_NHAP_DTO acc;

        public frmEnterDigitCode(THONG_TIN_DANG_NHAP_DTO acc)
        {
            InitializeComponent();
            setTextChanged();
            this.acc = acc;
        }


        

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Visible = false;
            frm.ShowDialog();
            this.Dispose();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string token = txtNumber1.Texts.ToString() + txtNumber2.Texts.ToString() + txtNumber3.Texts.ToString() +
                txtNumber4.Texts.ToString() + txtNumber5.Texts.ToString() + txtNumber6.Texts.ToString();
            if (token.Length != 6 )
            {
                MessageBox.Show("Hãy nhập đủ 6 số");
            }
            else
            {
                if (ForgetPass_BLL.Instance.CheckValid(acc.TaiKhoan, token))
                {
                    frmValidPass frm = new frmValidPass(acc);
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai");

                }
            }
        }


        private void setTextChanged()
        {
            HandleTextBox(txtNumber1, txtNumber2);
            HandleTextBox(txtNumber2, txtNumber3);
            HandleTextBox(txtNumber3, txtNumber4);
            HandleTextBox(txtNumber4, txtNumber5);
            HandleTextBox(txtNumber5, txtNumber6);
            txtNumber6._TextChanged += (s, e) =>
            {
                if (txtNumber6.Texts.Length == 1)
                {
                    btnSend.Focus();
                }
            };
        }

        private void HandleTextBox(CustomTextBox currentTextBox, CustomTextBox nextTextBox)
        {
            currentTextBox.MaxLength = 1;
            currentTextBox.KeyPress += TextBoxOnlyAllowNumeric;
            currentTextBox._TextChanged += (s, e) =>
            {
                if (currentTextBox.Texts.Length == 1)
                {
                    nextTextBox.Focus();
                }
            };
        }
        private void TextBoxOnlyAllowNumeric(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
