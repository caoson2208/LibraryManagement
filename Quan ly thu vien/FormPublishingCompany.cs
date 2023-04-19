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
    public partial class FormPublishingCompany : Form
    {
        public FormPublishingCompany()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private DataTable dataTable = new DataTable();
        void LoadDataGridView()
        {

            dataTable.Columns.Add("Mã xuất bản", typeof(string));
            dataTable.Columns.Add("Tên xuất bản", typeof(string));
            dataTable.Columns.Add("Địa chỉ", typeof(string));
            dataTable.Columns.Add("Điện thoại", typeof(int));

            dataTable.Rows.Add("XB01", "Cao Ngọc Sơn", "Q.12", 0799399003);
            dataTable.Rows.Add("XB02", "Đặng Trung Thắng", "Q.Gò Vấp", 0889828186);
            dataTable.Rows.Add("XB03", "Huỳnh Ngọc Như", "Q.7", 0789107986);
            //dataTable.Rows.Add("XB04", "Hà Phúc Thiện", "Q,12", 0832999972);
            //dataTable.Rows.Add("XB05", "Huỳnh Nguyên Chương", "Q.Tân Bình", 0832999972);
            //dataTable.Rows.Add("XB06", "Huỳnh Nguyên Chương", "Q.Tân Bình", 0832999972);
            //dataTable.Rows.Add("XB07", "Huỳnh Nguyên Chương", "Q.Tân Bình", 0832999972);
            //dataTable.Rows.Add("XB08", "Huỳnh Nguyên Chương", "Q.Tân Bình", 0832999972);


            dataGridView1.DataSource = dataTable;
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                // Column Title
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorkSheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();

                for (int i = excelWorkSheet.Dimension.Start.Column; i <= excelWorkSheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorkSheet.Cells[1, i].Value.ToString());
                }
                for (int i = excelWorkSheet.Dimension.Start.Row + 1; i <= excelWorkSheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorkSheet.Dimension.Start.Column; j <= excelWorkSheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorkSheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dataGridView1.DataSource = dataTable;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Export Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thàng công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thàng công!\n" + ex.Message);
                }
            }
        }

        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtMaNhaXB.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtTenNhaXB.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtDienThoai.Text = dataGridViewRow.Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            if (dataGridViewRow.Index >= 0)
            {
                dataGridViewRow.Cells[0].Value = txtMaNhaXB.Text;
                dataGridViewRow.Cells[1].Value = txtTenNhaXB.Text;
                dataGridViewRow.Cells[2].Value = txtDiaChi.Text;
                dataGridViewRow.Cells[3].Value = txtDienThoai.Text;
            }
            MessageBox.Show("Cập nhật dữ liệu thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa mã xuất bản " + txtMaNhaXB.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
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

        private void FormNhaXB_Load(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtMaNhaXB.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtTenNhaXB.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtDienThoai.Text = dataGridViewRow.Cells[3].Value.ToString();
        }
    }
}
