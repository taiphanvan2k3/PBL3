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

        //Các thuộc tính phục vụ cho việc di chuyển trang
        private const int HeightOfNotification = 92;
        private int MaxRow;
        private int MaxPage;
        private int CurrentPage = 1;
        private SplitPageHelper<ThongBao_DTO> helper;
        public UC_ViewListNotifications(string MaSV)
        {
            InitializeComponent();
            MaxRow = flowPanel.Height / HeightOfNotification;
            this.MaSV = MaSV;
        }

        private void ShowNotificationsOnPanel(List<ThongBao_DTO> li)
        {
            for (int i = 0; i < li.Count; i++)
            {
                ThongBao_DTO tb = li[i];
                flowPanel.Controls.Add(new UC_Notification()
                {
                    Width = flowPanel.Width - 10,
                    MaLopHP = tb.MaLopHP,
                    TenMH = tb.TenMonHoc,
                    GioiTinhGV = tb.CheckGender,
                    TenGV = tb.TenGV,
                    NgayTao = tb.NgayTao.ToShortDateString(),
                    TieuDeTB = tb.TieuDe,
                    NoiDungTB = tb.NoiDung
                });
            }
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime StartDateFiler = default(DateTime);
            int idx = combobox.SelectedIndex;
            if (idx == 1)
                StartDateFiler = DateTime.Now;
            else if (idx == 2)
                StartDateFiler = DateTime.Now.AddDays(-7);
            else if (idx == 3)
                StartDateFiler = DateTime.Now.AddDays(-30);
            flowPanel.Controls.Clear();
            li = LopHocPhan_BLL.Instance.GetNotificationsInSpecificBound(MaSV, StartDateFiler);
            if (li.Count != 0)
            {
                MaxPage = (int)Math.Ceiling(li.Count * 1.0 / MaxRow);
                helper = new SplitPageHelper<ThongBao_DTO>(MaxRow, li);
                ShowNotificationsOnPanel(helper.GetRecords(1));
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage != 1)
            {
                CurrentPage = 1;
                ShowNotificationsOnPanel(helper.GetRecords(CurrentPage));
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                ShowNotificationsOnPanel(helper.GetRecords(CurrentPage));
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < MaxPage)
            {
                CurrentPage++;
                ShowNotificationsOnPanel(helper.GetRecords(CurrentPage));
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (CurrentPage != MaxPage)
            {
                CurrentPage = MaxPage;
                ShowNotificationsOnPanel(helper.GetRecords(CurrentPage));
            }
        }

        private void UC_ViewListNotifications_Load(object sender, EventArgs e)
        {
            combobox_SelectedIndexChanged(sender, e);
        }
    }
}
