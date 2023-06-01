using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_ViewListNotifications : UserControl
    {
        private string MaSV;

        private List<ThongBao_DTO> li;

        //Lưu lại chiều cao hiện tại của panel, chỉ khi nào chiều cao của panel thay đổi thì mới đi tính
        //toán lại số trang hiển thị của các thông báo
        private int CurrentHeightOfFlowPanel;

        private int MaxPage;
        private int CurrentPage = 1;

        public UC_ViewListNotifications(string MaSV)
        {
            InitializeComponent();
            CurrentHeightOfFlowPanel = flowPanel.Height;
            this.MaSV = MaSV;
        }

        /// <summary>
        /// Đi tính toán số trang của từng thông báo, để lát dựa vào số trang
        /// này mà đi hiển thị lên panel
        /// </summary>
        private void CalculatePageOfEachNotification()
        {
            int pageCurrent = 1;
            int totalHeightCurrentPage = 0;
            int HeightOfPanel = flowPanel.Height;
            for (int i = 0; i < li.Count; i++)
            {
                ThongBao_DTO tb = li[i];
                UC_Notification notification = new UC_Notification() { NoiDungTB = tb.NoiDung };
                int heightUC = notification.HeightText;
                if (totalHeightCurrentPage + heightUC + 50 < HeightOfPanel)
                {
                    totalHeightCurrentPage += heightUC;
                    tb.AtPage = pageCurrent;
                }
                else
                {
                    tb.AtPage = ++pageCurrent;
                    totalHeightCurrentPage = heightUC;
                }
            }
            MaxPage = pageCurrent;
        }

        /// <summary>
        /// Dựa vào số trang ở thuộc tính AtPage đã lưu trong từng thông báo mà ta sẽ
        /// hiển thị tương ứng lên panel
        /// </summary>
        /// <param name="Page"></param>
        private void ShowNotificationsOnPanel(int Page)
        {
            lblCurrentPage.Text = $"Trang {Page}/{MaxPage}";
            flowPanel.Controls.Clear();
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].AtPage == Page)
                {
                    ThongBao_DTO tb = li[i];
                    UC_Notification notification = new UC_Notification()
                    {
                        Width = flowPanel.Width - 10,
                        MaLopHP = tb.MaLopHP,
                        TenMH = tb.TenMonHoc,
                        GioiTinhGV = tb.CheckGender,
                        TenGV = tb.TenGV,
                        NgayTao = tb.NgayTao.ToShortDateString(),
                        TieuDeTB = tb.TieuDe,
                        NoiDungTB = tb.NoiDung
                    };
                    flowPanel.Controls.Add(notification);
                }
            }
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime StartDateFiler = default;
            int idx = combobox.SelectedIndex;
            if (idx == 1)
                StartDateFiler = DateTime.Now;
            else if (idx == 2)
                StartDateFiler = DateTime.Now.AddDays(-7);
            else if (idx == 3)
                StartDateFiler = DateTime.Now.AddDays(-30);
            li = LopHocPhan_BLL.Instance.GetNotificationsInSpecificBound(MaSV, StartDateFiler);
            if (li.Count > 0)
            {
                CalculatePageOfEachNotification();
                CurrentPage = 1;
                ShowNotificationsOnPanel(CurrentPage);
            }
            else
            {
                flowPanel.Controls.Clear();
                CurrentPage = 0;
                MaxPage = 0;
                lblCurrentPage.Text = "Số thông báo: 0";
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage != 1)
            {
                CurrentPage = 1;
                ShowNotificationsOnPanel(CurrentPage);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                ShowNotificationsOnPanel(CurrentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < MaxPage)
            {
                CurrentPage++;
                ShowNotificationsOnPanel(CurrentPage);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage != MaxPage)
            {
                CurrentPage = MaxPage;
                ShowNotificationsOnPanel(CurrentPage);
            }
        }

        private void UC_ViewListNotifications_Load(object sender, EventArgs e)
        {
            combobox_SelectedIndexChanged(sender, e);
        }

        private void flowPanel_SizeChanged(object sender, EventArgs e)
        {
            //Chỉ tính toán lại số trang của các thông báo nếu flowPanel thay đổi về chiều cao
            if (flowPanel.Height != CurrentHeightOfFlowPanel)
            {
                CurrentHeightOfFlowPanel = flowPanel.Height;
                CalculatePageOfEachNotification();
                if (CurrentPage > MaxPage)
                    CurrentPage--;
                ShowNotificationsOnPanel(CurrentPage);
            }
        }
    }
}
