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
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
            LoadDataGridView1(); LoadDataGridView2();
        }

        private DataTable dataTable1 = new DataTable();

        void LoadDataGridView1()
        {
            dataTable1.Columns.Add("Mã phiếu ", typeof(int));
            dataTable1.Columns.Add("Mã độc giả", typeof(string));
            dataTable1.Columns.Add("Người lập phiếu", typeof(string));



            dataTable1.Rows.Add(1, "DG01", "NV01");
            dataTable1.Rows.Add(2, "DG02", "NV02");
            dataTable1.Rows.Add(3, "DG03", "NV03");
            dataTable1.Rows.Add(4, "DG04", "NV04");
            dataTable1.Rows.Add(5, "DG03", "NV05");
            dataTable1.Rows.Add(6, "DG05", "NV02");


            dataGridView1.DataSource = dataTable1;
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
            lbTotal.Text = $"{dataGridView1.RowCount - 1}";

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            txtMaPhieu.Text = dataGridViewRow.Cells[0].Value.ToString();
            comDocGia.Text = dataGridViewRow.Cells[1].Value.ToString();
            comNhanVien.Text = dataGridViewRow.Cells[2].Value.ToString();
        }

        int index;

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            if (dataGridViewRow.Index >= 0)
            {
                dataGridViewRow.Cells[0].Value = txtMaPhieu.Text;
                dataGridViewRow.Cells[1].Value = comDocGia.Text;
                dataGridViewRow.Cells[2].Value = comNhanVien.Text;
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa mã phiếu " + txtMaPhieu.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
                MessageBox.Show("Xóa thành công");
            }
            lbTotal.Text = $"{dataGridView1.RowCount - 1}";
        }

        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow1 = dataGridView1.Rows[index];
            txtMaPhieu.Text = dataGridViewRow1.Cells[0].Value.ToString();
            comDocGia.Text = dataGridViewRow1.Cells[1].Value.ToString();
            comNhanVien.Text = dataGridViewRow1.Cells[1].Value.ToString();
            lbTotal.Text = $"{dataGridView1.RowCount - 1}";

            DataGridViewRow dataGridViewRow2 = dataGridView2.Rows[index];
            comMaPhieuMuon.Text = dataGridViewRow2.Cells[0].Value.ToString();
            comMaSach.Text = dataGridViewRow2.Cells[1].Value.ToString();
            ngayMuon.Text = dataGridViewRow2.Cells[2].Value.ToString();
            ngayTra.Text = dataGridViewRow2.Cells[3].Value.ToString();
            ghiChu.Text = dataGridViewRow2.Cells[4].Value.ToString();


            lbTotal2.Text = $"{dataGridView2.RowCount - 1}";
        }

        private DataTable dataTable2 = new DataTable();

        void LoadDataGridView2()
        {
            dataTable2.Columns.Add("Mã phiếu mượn", typeof(int));
            dataTable2.Columns.Add("Mã sách", typeof(string));
            dataTable2.Columns.Add("Ngày mượn", typeof(string));
            dataTable2.Columns.Add("Ngày trả", typeof(string));
            dataTable2.Columns.Add("Tình trạng ", typeof(string));


            dataTable2.Rows.Add(1, "A01", "3/12/2023", "3/16/2023", "Đang mượn");
            dataTable2.Rows.Add(2, "A03", "3/10/2023", "3/15/2023", "Quá hạn");
            dataTable2.Rows.Add(3, "A04", "3/20/2023", "3/28/2023", "Quá hạn");
            dataTable2.Rows.Add(4, "A06", "2/11/2023", "3/14/2023", "Đang mượn");
            dataTable2.Rows.Add(5, "A02", "3/15/2023", "3/18/2023", "Đang mượn");
            dataTable2.Rows.Add(6, "A05", "3/16/2023", "3/20/2023", "Quá hạn");


            dataGridView2.DataSource = dataTable2;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView2.Rows[index];
            comMaPhieuMuon.Text = dataGridViewRow.Cells[0].Value.ToString();
            comMaSach.Text = dataGridViewRow.Cells[1].Value.ToString();
            ngayMuon.Text = dataGridViewRow.Cells[2].Value.ToString();
            ngayTra.Text = dataGridViewRow.Cells[3].Value.ToString();
            ghiChu.Text = dataGridViewRow.Cells[4].Value.ToString();
        }

        private void btnLuu1_Click(object sender, EventArgs e)
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

        private void btnThem1_Click(object sender, EventArgs e)
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

        private void btnSua1_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView2.Rows[index];
            if (dataGridViewRow.Index >= 0)
            {
                dataGridViewRow.Cells[2].Value = ngayMuon.Text;
                dataGridViewRow.Cells[3].Value = ngayTra.Text;
                dataGridViewRow.Cells[4].Value = ghiChu.Text;

                MessageBox.Show("Gia hạn thành công!");
            }
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn trả sách " + comMaSach.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int index = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows.RemoveAt(index);
                MessageBox.Show("Trả sách thành công");
            }
        }

        private void comNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
