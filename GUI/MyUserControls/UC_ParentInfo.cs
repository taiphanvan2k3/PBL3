using BLL;
using DTO;
using GUI.MyCustomControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_ParentInfo : UserControl
    {
        public string MSSV { get; set; }
        public UC_StudentInfoNew previousPage { get; set; }

        //Lưu lại tên cha, mẹ của lần cũ trước khi thực hiện lưu
        private string oldFatherName, oldMotherName;
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
            //Không dùng event Load vì giả sử sinh viên chỉ thay đổi trên giao diện nhưng chưa bấm
            //lưu thì phải Load lại dữ liệu cũ mỗi khi control này được hiển thị lại trên giao diện
        }

        private void LoadFatherInfo(PhuHuynh_DTO Cha)
        {
            txtTenCha.Text = Cha.TenPH;
            oldFatherName = txtTenCha.Text;
            txtSDTCha.Text = Cha.Sdt;
            ngsinhCha.Value = Cha.NgaySinh;
            if (!string.IsNullOrEmpty(Cha.DiaChi))
            {
                txtSoDuong.Text = Cha.DiaChi.Substring(0, Cha.DiaChi.IndexOf(" - "));
                uC_AddressSelection.SetDiaChi(Cha.DiaChi);
            }
        }

        private void LoadMotherInfo(PhuHuynh_DTO Me)
        {
            txtTenMe.Text = Me.TenPH;
            oldMotherName = txtTenMe.Text;
            txtSDTMe.Text = Me.Sdt;
            ngsinhMe.Value = Me.NgaySinh;
            if (!string.IsNullOrEmpty(Me.DiaChi))
            {
                txtSoDuong.Text = Me.DiaChi.Substring(0, Me.DiaChi.IndexOf(" - "));
                uC_AddressSelection.SetDiaChi(Me.DiaChi);
            }

        }
        public void LoadData()
        {
            List<PhuHuynh_DTO> li = PhuHuynh_BLL.GetPhuHuynhByIdStudent(MSSV);
            if (li != null)
            {
                uC_AddressSelection.Init();
                if (li.Count == 2)
                {
                    PhuHuynh_DTO Cha = null;
                    PhuHuynh_DTO Me = null;
                    if (li[0].GioiTinh)
                    {
                        Cha = li[0];
                        Me = li[1];
                    }
                    else
                    {
                        Cha = li[1];
                        Me = li[0];
                    }
                    LoadFatherInfo(Cha);
                    LoadMotherInfo(Me);
                }
                else if (li.Count == 1)
                {
                    if (li[0].GioiTinh)
                        LoadFatherInfo(li[0]);
                    else LoadMotherInfo(li[0]);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string address = UtilityClass.GetAddressFromUCAddressSelection(txtSoDuong.Text, uC_AddressSelection.TinhThanhPho,
                uC_AddressSelection.QuanHuyen, uC_AddressSelection.XaPhuong);
            string resultOfSave = "";
            if (txtTenCha.Text != "")
            {
                PhuHuynh_DTO Cha = new PhuHuynh_DTO();
                Cha.MaSV = MSSV;
                Cha.GioiTinh = true;
                Cha.TenPH = txtTenCha.Text;
                if (txtSDTCha.Text != "")
                    Cha.Sdt = txtSDTCha.Text;
                else Cha.Sdt = "";
                Cha.NgaySinh = ngsinhCha.Value;
                Cha.DiaChi = address;
                Cha.MoiQuanHe = "Cha - con";
                if (PhuHuynh_BLL.UpdateParentInfo(Cha, oldFatherName))
                {
                    oldFatherName = Cha.TenPH;
                    resultOfSave = "Cập nhật thành công thông tin cha";
                }         
            }

            if (txtTenMe.Text != "")
            {
                PhuHuynh_DTO Me = new PhuHuynh_DTO();
                Me.MaSV = MSSV;
                Me.GioiTinh = false;
                Me.TenPH = txtTenMe.Text;
                if (txtSDTMe.Text != "")
                    Me.Sdt = txtSDTMe.Text;
                else Me.Sdt = "";
                Me.NgaySinh = ngsinhMe.Value;
                Me.DiaChi = address;
                Me.MoiQuanHe = "Mẹ - con";
                if (PhuHuynh_BLL.UpdateParentInfo(Me, oldMotherName))
                {
                    if (resultOfSave == "")
                        resultOfSave = "Cập nhật thành công thông tin mẹ";
                    else resultOfSave = "Cập nhật thành công thông tin cha,mẹ";
                    oldMotherName = Me.TenPH;
                }
            }
            if (resultOfSave != "")
                CustomMessageBox.Show(resultOfSave, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
