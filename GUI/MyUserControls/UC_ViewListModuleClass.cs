using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UC_ViewListModuleClass : UserControl
    {
        public UC_ViewListModuleClass()
        {
            InitializeComponent();
        }
        private void UC_XemThongTinLopHocPhan_Load(object sender, EventArgs e)
        {
            //Danh sách cột này tạo ra để test, trong thực tế làm thì sẽ không làm như vậy
            dataGridView1.Rows.Add("TRR21.13", "Toán rời rạc", "Nguyễn Văn Hiệu", 2021, 2, 46);
            dataGridView1.Rows.Add("CSDL21.13", "Cơ sở dữ liệu", "Võ Đức Hoàng", 2022, 3, 46);
            dataGridView1.Rows.Add("OOP21.13", "Lập trình hướng đối tượng", "Lê Thị Mỹ Hạnh", 2022, 3, 46);
            dataGridView1.Rows.Add("OOAD21.13", "Phân tích thiết kế hướng đối tượng", "Lê Thị Mỹ Hạnh", 2023, 4, 46);
            dataGridView1.Rows.Add("CNPM21.13", "Công nghệ phần mềm", "Thỉnh giảng", 2023, 3, 46);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                MessageBox.Show("Hê");
            }
        }
    }
}
