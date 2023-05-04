using BLL;
using Microsoft.Office.Interop.Excel;
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
            chartStudentByYear.DataSource = GetInformationAcc_BLL.Instance.StuentByYearList();
            chartStudentByYear.Series[0].XValueMember = "Key";
            chartStudentByYear.Series[0].YValueMembers = "Value";
            chartStudentByYear.DataBind();
            dgvStudentByFacluty.DataSource = GetInformationAcc_BLL.Instance.StudentCountByFaculty();
            dgvStudentByFacluty.Columns[0].HeaderText = "Khoa";
            dgvStudentByFacluty.Columns[1].HeaderText = "Số lượng";
            charLevelOfTeacher.DataSource = GetInformationAcc_BLL.Instance.LevelOfTeacherList();
            charLevelOfTeacher.Series[0].XValueMember = "Key";
            charLevelOfTeacher.Series[0].YValueMembers = "Value";
            charLevelOfTeacher.DataBind();


        }
    }
}
