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
    public partial class FormManageBook : Form
    {
        public FormManageBook()
        {
            InitializeComponent(); 
            LoadDataGridView();
        }

        private DataTable dataTable = new DataTable();
        void LoadDataGridView()
        {
            dataTable.Columns.Add("Mã sách", typeof(string));
            dataTable.Columns.Add("Tên sách", typeof(string));
            dataTable.Columns.Add("Năm xuất bản", typeof(string));
            dataTable.Columns.Add("Mã nhà xuất bản", typeof(string));
            dataTable.Columns.Add("Mã thể loại", typeof(string));
            dataTable.Columns.Add("Mã tác giả", typeof(string));

            dataTable.Rows.Add("A01", "Vật Lý", "2003", "XB01", "TL01", "TG06");
            dataTable.Rows.Add("A02", "Hóa học", "2002", "XB04", "TL03", "TG02");
            dataTable.Rows.Add("A03", "Tin Học", "2001", "XB02", "TL04", "TG04");
            dataTable.Rows.Add("A04", "Tiếng Anh", "2003", "XB03", "TL05", "TG04");
            dataTable.Rows.Add("A05", "Ngử Văn", "2004", "XB03", "TL06", "TG03");
            dataTable.Rows.Add("A06", "Toán", "2000", "XB05", "TL06", "TG03");
            //dataTable.Rows.Add("A06", "Toán", "2000", "XB05", "TL06", "TG03");
            //dataTable.Rows.Add("A06", "Toán", "2000", "XB05", "TL06", "TG03");
            //dataTable.Rows.Add("A06", "Toán", "2000", "XB05", "TL06", "TG03");
            //dataTable.Rows.Add("A06", "Toán", "2000", "XB05", "TL06", "TG03");
            //dataTable.Rows.Add("A06", "Toán", "2000", "XB05", "TL06", "TG03");
            //dataTable.Rows.Add("A06", "Toán", "2000", "XB05", "TL06", "TG03");


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

        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtCodeBook.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtNameBook.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtPublishingYear.Text = dataGridViewRow.Cells[2].Value.ToString();
            comCodepublishingCompany.Text = dataGridViewRow.Cells[3].Value.ToString();
            comCodeCategory.Text = dataGridViewRow.Cells[4].Value.ToString();
            comCodeAuthor.Text = dataGridViewRow.Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            if (dataGridViewRow.Index >= 0)
            {
                dataGridViewRow.Cells[0].Value = txtCodeBook.Text;
                dataGridViewRow.Cells[1].Value = txtNameBook.Text;
                dataGridViewRow.Cells[2].Value = txtPublishingYear.Text;
                dataGridViewRow.Cells[3].Value = comCodepublishingCompany.Text;
                dataGridViewRow.Cells[4].Value = comCodeCategory.Text;
                dataGridViewRow.Cells[5].Value = comCodeAuthor.Text;


                MessageBox.Show("Cập nhật dữ liệu thành công");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa mã sách " + txtCodeBook.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void FormQuanLySach_Load(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtCodeBook.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtNameBook.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtPublishingYear.Text = dataGridViewRow.Cells[2].Value.ToString();
            comCodepublishingCompany.Text = dataGridViewRow.Cells[3].Value.ToString();
            comCodeCategory.Text = dataGridViewRow.Cells[4].Value.ToString();
            comCodeAuthor.Text = dataGridViewRow.Cells[5].Value.ToString();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (rdCodeBook.Checked)
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = "[Mã sách] LIKE '" + txtSearch.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            if (rdNameBook.Checked)
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = "[Tên sách] LIKE '" + txtSearch.Text + "%'";
                dataGridView1.DataSource = dv;
            }
        }
    }
}
