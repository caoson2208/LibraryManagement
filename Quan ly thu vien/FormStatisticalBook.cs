using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
    public partial class FormStatisticalBook : Form
    {
        public FormStatisticalBook()
        {
            InitializeComponent();
        }

        private void FormThongKeSach_Load(object sender, EventArgs e)
        {
            FormManageBook f = new FormManageBook();
            dataTable1 = (DataTable)f.dataGridView1.DataSource;
            dataGridView2.DataSource = dataTable1;
        }


        private DataTable dataTable1 = new DataTable();
        private DataTable dataTable2 = new DataTable();
        private DataTable dataTable3 = new DataTable();


        void LoadDataGridView2()
        {
            dataTable2.Columns.Add("Mã sách", typeof(string));
            dataTable2.Columns.Add("Tên sách", typeof(string));
            dataTable2.Columns.Add("Năm xuất bản", typeof(string));
            dataTable2.Columns.Add("Mã nhà xuất bản", typeof(string));
            dataTable2.Columns.Add("Mã thể loại", typeof(string));
            dataTable2.Columns.Add("Mã tác giả", typeof(string));

            dataTable2.Rows.Add("A01", "Vật Lý", "2003", "XB01", "TL01", "TG06");
            dataTable2.Rows.Add("A02", "Hóa học", "2002", "XB04", "TL03", "TG02");
            dataTable2.Rows.Add("A06", "Toán", "2000", "XB05", "TL06", "TG03");


            dataGridView2.DataSource = dataTable2;

        }

        void LoadDataGridView3()
        {
            dataTable3.Columns.Add("Mã sách", typeof(string));
            dataTable3.Columns.Add("Tên sách", typeof(string));
            dataTable3.Columns.Add("Năm xuất bản", typeof(string));
            dataTable3.Columns.Add("Mã nhà xuất bản", typeof(string));
            dataTable3.Columns.Add("Mã thể loại", typeof(string));
            dataTable3.Columns.Add("Mã tác giả", typeof(string));

            dataTable3.Rows.Add("A03", "Tin Học", "2001", "XB02", "TL04", "TG04");
            dataTable3.Rows.Add("A04", "Tiếng Anh", "2003", "XB03", "TL05", "TG04");
            dataTable3.Rows.Add("A05", "Ngử Văn", "2004", "XB03", "TL06", "TG03");

            dataGridView2.DataSource = dataTable3;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (comStatistical.Text == "Tất cả sách")
            {
                FormManageBook f = new FormManageBook();
                dataTable1 = (DataTable)f.dataGridView1.DataSource;
                dataGridView2.DataSource = dataTable1;
            }
            else if (comStatistical.Text == "Sách đang mượn")
                LoadDataGridView2();
            else
                LoadDataGridView3();
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                // Column Title
                application.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }


        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thàng công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thàng công!\n" + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }

        private void comTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
