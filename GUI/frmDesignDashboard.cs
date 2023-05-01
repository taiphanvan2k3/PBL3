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
    public partial class frmDesignDashboard : Form
    {
        public frmDesignDashboard()
        {
            InitializeComponent();
        }

        private void frmDesignDashboard_Load(object sender, EventArgs e)
        {
            lbCountAcc.Text = GetInformationAcc_BLL.Instance.CountNGUOI_DUNG().ToString();
            lblNumberStudent.Text = GetInformationAcc_BLL.Instance.CountSINH_VIEN().ToString();
            lbNumberTeacher.Text = GetInformationAcc_BLL.Instance.CountGIANG_VIEN().ToString();
            lbNumberPrograming.Text = GetInformationAcc_BLL.Instance.CountCHUONG_TRINH_DAO_TAO().ToString();
            lbFaculty.Text = GetInformationAcc_BLL.Instance.CountKHOA().ToString();

        }
    }
}
