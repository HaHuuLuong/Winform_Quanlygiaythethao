using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nhom5_qlgiaythethao;

namespace nhom5_qlgiaythethao.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public void DangNhap()
        {
            string user = "We Run";
            string pass = "yeu co Tu";

            if (txtTenDangNhap.Text.Length == 0 && txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Username và Password");
                txtTenDangNhap.Focus();
            }
            else if (txtTenDangNhap.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Username");
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Password");
                txtMatKhau.Focus();
            }
            else if (user == txtTenDangNhap.Text && pass == txtMatKhau.Text)
            {
                //Lưu mật khẩu
                if (chkLuuMatKhau.Checked)
                {
                    Properties.Settings.Default.TenDangNhap = txtTenDangNhap.Text;
                    Properties.Settings.Default.MatKhau = txtMatKhau.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.TenDangNhap = "";
                    Properties.Settings.Default.MatKhau = "";
                    Properties.Settings.Default.Save();
                };

                this.Hide();     //ẩn form đăng nhập           
                FrmMenu f = new FrmMenu();
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
                txtTenDangNhap.Focus();
            }
        }

       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            DangNhap();
           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Properties.Settings.Default.TenDangNhap;
            txtMatKhau.Text = Properties.Settings.Default.MatKhau;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
