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
using System.IO; // Doc file
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Reflection;

namespace Quan_ly_thu_vien
{
    public partial class FormStatisticalReaders : Form
    {
        public FormStatisticalReaders()
        {
            InitializeComponent();
        }
        private DataTable dataTable1 = new DataTable();

        void LoadDataGridView()
        {
            dataTable1.Columns.Add("Mã độc giả", typeof(string));
            dataTable1.Columns.Add("Họ và tên", typeof(string));
            dataTable1.Columns.Add("Ngày sinh", typeof(string));
            dataTable1.Columns.Add("Giới tính", typeof(string));
            dataTable1.Columns.Add("Lớp", typeof(string));


            dataTable1.Rows.Add("DG02", "Đặng Trung Thắng", "06/12/2003", "Nam", "DH21IT02");
            dataTable1.Rows.Add("DG03", "Hà Phúc Thiện", "03/23/2003", "Nam", "DH21IT02");
            dataTable1.Rows.Add("DG06", "Lưu Văn Phúc", "11/21/2002", "Nam", "DH21IT01");

            dataGridView2.DataSource = dataTable1;
        }

        private DataTable dataTable = new DataTable();

        private void FormThongKeDocGia_Load(object sender, EventArgs e)
        {
            FormReaders f = new FormReaders();
            dataTable = (DataTable)f.dataGridView1.DataSource;
            dataGridView2.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comSearch.Text == "Tất cả sách")
            {
                FormReaders f = new FormReaders();
                dataTable = (DataTable)f.dataGridView1.DataSource;
                dataGridView2.DataSource = dataTable;
            }
            else
                LoadDataGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }
    }
}
