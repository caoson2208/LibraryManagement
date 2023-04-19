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
    public partial class FormReaders : Form
    {
        public FormReaders()
        {
            InitializeComponent();
            LoadDataGridView();

        }

        private DataTable dataTable = new DataTable();
        void LoadDataGridView()
        {
            dataTable.Columns.Add("Mã độc giả", typeof(string));
            dataTable.Columns.Add("Họ và tên", typeof(string));
            dataTable.Columns.Add("Ngày sinh", typeof(string));
            dataTable.Columns.Add("Giới tính", typeof(string));
            dataTable.Columns.Add("Lớp", typeof(string));


            dataTable.Rows.Add("DG01", "Cao Ngọc Sơn", "08/22/2003", "Nam", "DH21IT01");
            dataTable.Rows.Add("DG02", "Đặng Trung Thắng", "06/12/2003", "Nam", "DH21IT02");
            dataTable.Rows.Add("DG03", "Hà Phúc Thiện", "03/23/2003", "Nam", "DH21IT02");
            dataTable.Rows.Add("DG04", "Huỳnh Nguyên Chương", "01/01/2002", "Nữ", "DH21IT03");
            dataTable.Rows.Add("DG05", "Nguyễn Huỳnh Ngọc Như", "02/05/2002", "Nữ", "DH21IT03");
            dataTable.Rows.Add("DG06", "Lưu Văn Phúc", "11/21/2002", "Nam", "DH21IT01");
            //dataTable.Rows.Add("DG07", "Nguyễn Hoàng Duy", "20/10/2002", "Nam", "DH21IT02");
            //dataTable.Rows.Add("DG08", "Nguyễn Song Hậu", "10/02/2002", "Nữ", "DH21IT03");
            //dataTable.Rows.Add("DG09", "Nguyễn Thanh Hiệp", "05/12/2002", "Nam", "DH21IT01");

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
            lbTotal.Text = $"{dataGridView1.RowCount }";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            if (dataGridViewRow.Index >= 0)
            {
                dataGridViewRow.Cells[0].Value = txtMaDocGia.Text;
                dataGridViewRow.Cells[1].Value = txtTenDocGia.Text;
                dataGridViewRow.Cells[2].Value = ngaysinh.Value.ToString("MM/dd/yyyy");
                dataGridViewRow.Cells[3].Value = comGioiTinh.Text;
                dataGridViewRow.Cells[4].Value = txtLop.Text;
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }

        int index;
        private void FormDocGia_Load(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtMaDocGia.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtTenDocGia.Text = dataGridViewRow.Cells[1].Value.ToString();
            ngaysinh.Text = dataGridViewRow.Cells[2].Value.ToString();
            comGioiTinh.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtLop.Text = dataGridViewRow.Cells[4].Value.ToString();

            lbTotal.Text = $"{dataGridView1.RowCount}";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa độc giá " + txtMaDocGia.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("Xóa thành công");
            }
            lbTotal.Text = $"{dataGridView1.RowCount - 1}";

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtMaDocGia.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtTenDocGia.Text = dataGridViewRow.Cells[1].Value.ToString();  
            ngaysinh.Text = dataGridViewRow.Cells[2].Value.ToString();
            comGioiTinh.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtLop.Text = dataGridViewRow.Cells[4].Value.ToString();
        }
    }
}
