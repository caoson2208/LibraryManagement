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
    public partial class FormSearchReaders : Form
    {
        public FormSearchReaders()
        {
            InitializeComponent();
        }

        private DataTable dataTable = new DataTable();
        private void FormTimKiemDocGia_Load(object sender, EventArgs e)
        {
            FormReaders f = new FormReaders();
            dataTable = (DataTable)f.dataGridView1.DataSource;
            dataGridView2.DataSource = dataTable;
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            //if (rdMaDocGia.Checked)
            //{
            //    DataView dv = dataTable.DefaultView;
            //    dv.RowFilter = "[Mã độc giả] LIKE '" + txtTimKiem.Text + "%'";
            //    dataGridView1.DataSource = dv;
            //}
            //if (rdTenDocGia.Checked)
            //{
            //    DataView dv = dataTable.DefaultView;
            //    dv.RowFilter = "[Họ và tên] LIKE '" + txtTimKiem.Text + "%'";
            //    dataGridView1.DataSource = dv;
            //}
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdCodeReader.Checked)
            {
                DataView dv = dataTable.DefaultView;
                if (dv != null)
                {
                    dv.RowFilter = "[Mã độc giả] LIKE '" + txtSearch.Text + "%'";
                    dataGridView2.DataSource = dv;
                    txtSearch.Text = "";
                }
            }
            if (rdNameReader.Checked)
            {
                DataView dv = dataTable.DefaultView;
                if (dv != null)
                {
                    dv.RowFilter = "[Họ và tên] LIKE '" + txtSearch.Text + "%'";
                    dataGridView2.DataSource = dv;
                    txtSearch.Text = "";
                }
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
