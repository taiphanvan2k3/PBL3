using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAssignTeacher : Form
    {
        public frmAssignTeacher()
        {
            InitializeComponent();
            MoveFormHelper helper = new MoveFormHelper(this, panelTitle, labelTitle);
        }

        #region Properties
        public string MaHP
        {
            get => tbMaHP.Text;
            set => tbMaHP.Text = value;
        }
        public string TenHP
        {
            get => tbTenHP.Text;
            set => tbTenHP.Text = value;
        }
        public string MaGV
        {
            get => tbMaGV.Text;
            set => tbMaGV.Text = value;
        }
        public string TenGV
        {
            get => tbTenGV.Text; 
            set => tbTenGV.Text = value;
        }
        public string Thu
        {
            get => tbThu.Text;
            set => tbThu.Text = value;
        }
        public string TietBatDau
        {
            get => tbTietBD.Text;
            set => tbTietBD.Text = value;
        }
        public string TietKetThuc
        {
            get => tbTietKT.Text;
            set => tbTietKT.Text = value;
        }
        public string Phong
        {
            get => tbPhong.Text; 
            set => tbPhong.Text = value;
        }
        #endregion
        #region Events
        private void frm_AssignTeacher_Load(object sender, EventArgs e)
        {
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
