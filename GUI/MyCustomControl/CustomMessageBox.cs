using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyCustomControl
{
    public class CustomMessageBox
    {
        public static DialogResult Show(string text)
        {
            DialogResult result;
            using (var frm = new frmMessageBox(text))
                result = frm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption)
        {
            DialogResult result;
            using (var frm = new frmMessageBox(text, caption))
                result = frm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var frm = new frmMessageBox(text, caption, buttons))
                result = frm.ShowDialog();
            return result;
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icons)
        {
            DialogResult result;
            using (var frm = new frmMessageBox(text, caption, buttons, icons))
                result = frm.ShowDialog();
            return result;
        }
    }
}
