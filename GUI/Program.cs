using BLL;
using System;
using System.Windows.Forms;
namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            foreach (var form in Application.OpenForms)
            {
                var currentForm = form as Form;
                currentForm.FormClosing += Form_FormClosing;
            }
            Application.Run(new frmLogin());
        }

        private static void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            ValidLogin_BLL.Instance.UpdateAllCodesToNull_BLL();
        }
    }
}
