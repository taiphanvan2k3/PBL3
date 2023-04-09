using System.Net.Mail;
using System.Net;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace BLL
{
    /// <summary>
    /// Lớp này đi xử lí các vấn đề lặp đi lặp lại
    /// </summary>
    public class UtilityClass
    {
        public static void OpenNewForm(Form oldForm, Form newForm)
        {
            oldForm.Close();
            Thread t = new Thread(() =>
            {
                Application.Run(newForm);
            });
            //Thiết lập trạng thái của tiến trình mới là STA (Single-Threaded Apartment)
            //để yêu cầu tiến trình mới được chạy trên một luồng riêng biệt, do đó nó không
            //bị ảnh hưởng bởi việc đóng form hiện tại
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public static string[] SplitAddress(string address)
        {
            return Regex.Split(address, " - ");
        }

        public static void sendEmail(string addressEmail, string digitcode)
        {
            string senderEmail = "nngann2402@gmail.com";
            string receiverEmail = addressEmail;
            string subject = "Digit code";
            string body = digitcode;
            string senderPassword = "yagelshriaicnfvn";

            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

            MailMessage mailMessage = new MailMessage(senderEmail, receiverEmail, subject, body);
            mailMessage.IsBodyHtml = true;
            try
            {
                smtpClient.Send(mailMessage);
                MessageBox.Show("Đã gửi email thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi email thất bại: " + ex.Message);
            }
        }
    }
}
