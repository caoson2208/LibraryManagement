using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class FormUpdateCategoryBook : Form
    {
        public FormUpdateCategoryBook()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private DataTable dataTable = new DataTable();
        void LoadDataGridView()
        {
            dataTable.Columns.Add("Mã thể loại", typeof(string));
            dataTable.Columns.Add("Tên thể loại", typeof(string));


            dataTable.Rows.Add("TL01", "Chính tri - Pháp luật");
            dataTable.Rows.Add("TL02", "Sách giáo khoa");
            //dataTable.Rows.Add("TL03", "Sách văn học");
            //dataTable.Rows.Add("TL04", "Khoa học viễn tưởng");
            //dataTable.Rows.Add("TL04", "Văn học nghệ thuật");
            //dataTable.Rows.Add("TL05", "Khoa học công nghệ");

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
            openFileDialog.Title = "Import Excel";
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

        private void btnLuu_Click_1(object sender, EventArgs e)
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

        int index;
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
             index = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
             txtCodeCategory.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtNameCategory.Text = dataGridViewRow.Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            if (dataGridViewRow.Index >= 0)
            {
                dataGridViewRow.Cells[0].Value = txtCodeCategory.Text;
                dataGridViewRow.Cells[1].Value = txtNameCategory.Text;
            }
            MessageBox.Show("Cập nhật dữ liệu thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa mã sách " + txtCodeCategory.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("Xóa thành công");
            }
        }

        private void FormCapNhatTheLoaiSach_Load(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtCodeCategory.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtNameCategory.Text = dataGridViewRow.Cells[1].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }
    }
}
