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

namespace Quan_ly_thu_vien
{
    public partial class FormUpdateAuthor : Form
    {
        public FormUpdateAuthor()
        {
            InitializeComponent(); 
            LoadDataGridView();
        }
        private DataTable dataTable = new DataTable();
        void LoadDataGridView()
        {
            dataTable.Columns.Add("Mã tác giả", typeof(string));
            dataTable.Columns.Add("Họ và tên", typeof(string));


            dataTable.Rows.Add("TG01", "Cao Ngọc Sơn");
            dataTable.Rows.Add("TG02", "Đặng Trung Thắng");
            dataTable.Rows.Add("TG03", "Hà Phúc Thiện");
            dataTable.Rows.Add("TG04", "Huỳnh Nguyên Chương");
            dataTable.Rows.Add("TG05", "Nguyễn Huỳnh Ngọc Như");
            //dataTable.Rows.Add("TG06", "Lưu Văn Phúc");
            //dataTable.Rows.Add("TG07", "Nguyễn Hoàng Duy");
            //dataTable.Rows.Add("TG08", "Nguyễn Song Hậu");
            //dataTable.Rows.Add("TG09", "Nguyễn Thanh Hiệp");

            dataGridView1.DataSource = dataTable;
        }

        private void btnThen_Click(object sender, EventArgs e)
        {
            //dataTable.Rows.Add(txtMaTacGia.Text, txtTenTacGia.Text);
            //dataGridView1.DataSource = dataTable;
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

        private void ExportExcel(string path)
        {
            Excel.Application application= new Excel.Application();
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
                catch(Exception ex) 
                {
                    MessageBox.Show("Xuất file không thàng công!\n" + ex.Message);
                }
            }
        }

        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index  = e.RowIndex;       

            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtCodeAuthor.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtNameAuthor.Text = dataGridViewRow.Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            if (dataGridViewRow.Index >= 0)
            {
                dataGridViewRow.Cells[0].Value = txtCodeAuthor.Text;
                dataGridViewRow.Cells[1].Value = txtNameAuthor.Text;
            }
            MessageBox.Show("Cập nhật dữ liệu thành công");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa mã sách " + txtCodeAuthor.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("Xóa thành công");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }

        private void FormCapNhatTacGia_Load(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtCodeAuthor.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtNameAuthor.Text = dataGridViewRow.Cells[1].Value.ToString();
        }
    }
}
