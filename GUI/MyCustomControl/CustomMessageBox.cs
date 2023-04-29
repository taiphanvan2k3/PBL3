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
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, string nameYes, string nameNo, string nameCancel)
        {
            DialogResult result;
            using (var frm = new frmMessageBox(text, caption, buttons, nameYes, nameNo, nameCancel))
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
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog();
            return result;
        }

        /*-> IWin32Window Owner:
            *      Displays a message box in front of the specified object and with the other specified parameters.
            *      An implementation of IWin32Window that will own the modal dialog box.*/
        public static DialogResult Show(IWin32Window owner, string text)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, string nameYes, string nameNo, string nameCancel)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons , nameYes, nameNo, nameCancel))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons, icon))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new frmMessageBox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog(owner);
            return result;
        }

    }
}
