using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_thu_vien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormLogin();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormReaders();
            f.Show();
        }

      
        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormManageBook();
            f.Show();
        }

        private void danhMụcSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormUpdateCategoryBook();
            f.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormUpdateAuthor();
            f.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormPublishingCompany();
            f.Show();
        }

        private void tìmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormSearchBook();
            f.Show();
        }

        private void tìmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormSearchReaders();
            f.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormPayment();
            f.Show();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            lbName.Text = "         Chương Trình Quản Lý Thư Viện          ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(lbName.Text.Length - 1)
                + lbName.Text.Substring(0, lbName.Text.Length - 1);
        }

        private void thốngKêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormStatisticalBook();
            f.Show();
        }

        private void thốngKêĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormStatisticalReaders();
            f.Show();
        }
    }
}
