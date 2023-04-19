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
    public partial class FormSearchBook : Form
    {
        public FormSearchBook()
        {
            InitializeComponent();
        }

        private DataTable dataTable = new DataTable();

        private void FormTimKiemSach_Load(object sender, EventArgs e)
        {
            FormManageBook f = new FormManageBook();
            dataTable = (DataTable)f.dataGridView1.DataSource;
            dataGridView2.DataSource = dataTable;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //if (rdMaSach.Checked)
            //{
            //    DataView dv = dataTable.DefaultView;
            //    dv.RowFilter = "[Mã sách] LIKE '" + txtTimKiem.Text + "%'";
            //    dataGridView2.DataSource = dv;
            //}
            //if (rdTenSach.Checked)
            //{
            //    DataView dv = dataTable.DefaultView;
            //    dv.RowFilter = "[Tên sách] LIKE '" + txtTimKiem.Text + "%'";
            //    dataGridView2.DataSource = dv;
            //}
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdCodeBook.Checked)
            {
                DataView dv = dataTable.DefaultView;
                if (dv != null)
                {
                  
                    dv.RowFilter = "[Mã sách] LIKE '" + txtSearch.Text + "%'";
                    dataGridView2.DataSource = dv;
                    txtSearch.Text = "";
                }
            }
            if (rdNameBook.Checked)
            {
                DataView dv = dataTable.DefaultView;
                if (dv != null)
                { 
                    dv.RowFilter = "[Tên sách] LIKE '" + txtSearch.Text + "%'";
                    dataGridView2.DataSource = dv;
                    txtSearch.Text = "";
                }
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                btnSearch.PerformClick();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }

    }
}
