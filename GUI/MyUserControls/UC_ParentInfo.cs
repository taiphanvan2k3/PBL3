using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_ParentInfo : UserControl
    {
        public string MSSV { get; set; }
        public UC_StudentInfoNew previousPage { get; set; }
        public UC_ParentInfo()
        {
            InitializeComponent();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            Panel pnl = Parent as Panel;
            pnl.Controls.Clear();
            previousPage.Dock = DockStyle.Fill;
            pnl.Controls.Add(previousPage);
        }

        private void UC_ParentInfo_Load(object sender, EventArgs e)
        {
            List<PhuHuynh_DTO> li = PhuHuynh_BLL.GetPhuHuynhByIdStudent(MSSV);
            if (li != null)
            {
                PhuHuynh_DTO Cha = null;
                PhuHuynh_DTO Me = null;
                if (li.Count == 2)
                {
                    Cha = li[0];
                    Me = li[1];
                    txtTenCha.Text = Cha.TenPH;
                    txtSDTCha.Text = Cha.Sdt;
                    ngsinhCha.Value = Cha.NgaySinh;

                    txtTenMe.Text = Me.TenPH;
                    txtSDTMe.Text = Me.Sdt;
                    ngsinhMe.Value = Me.NgaySinh;

                    uC_AddressSelection.SetDiaChi(Cha.DiaChi);
                }
                else
                {
                    if (li[0].MoiQuanHe == "Cha - con")
                        Cha = li[0];
                    else Me = li[0];
                }
            }
        }
    }
}
