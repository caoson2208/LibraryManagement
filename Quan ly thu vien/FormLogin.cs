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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        string userName = "admin";
        string passWord = "123";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txtUser.Focus();


            }
            else if (txtPassWord.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtPassWord.Focus();
            }
            else if (userName.Equals(txtUser.Text) && passWord.Equals(txtPassWord.Text))
            {

                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                Form f = new FormMain();
                f.Show();
            }
            else { MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai"); }
        }

        // Show passWord
        private void ckbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiMK.Checked)
                txtPassWord.UseSystemPasswordChar = false;
            else
                txtPassWord.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FromDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
