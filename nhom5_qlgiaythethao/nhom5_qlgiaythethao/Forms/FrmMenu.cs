﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nhom5_qlgiaythethao.Forms;
using System.Data;

namespace nhom5_qlgiaythethao
{
    public partial class FrmMenu : Form
    {
        bool isLogout = true;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if(isLogout)
            {
                Class.Functions.Disconnect();
                Application.Exit();
            }    
            
        }

        public void Logout()
        {
            isLogout = false;
            this.Close();
            FrmLogin f = new FrmLogin();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            

        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {

            Logout();
            


        }

        private void mnuHoadonban_Click(object sender, EventArgs e)
        {
            Forms.FrmHoaDonBan f = new Forms.FrmHoaDonBan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuBCHoadonban_Click(object sender, EventArgs e)
        {
            Forms.FrmBaoCaoHoaDonBan f = new Forms.FrmBaoCaoHoaDonBan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }

        private void mnuFindHoadonnhap_Click(object sender, EventArgs e)
        {
            /*Forms.FrmTimKiemHoaDonNhap f = new Forms.FrmTimKiemHoaDonNhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();*/
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            FrmDanhMucNhanVien f = new FrmDanhMucNhanVien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            Forms.FrmDanhMucKhachHang f = new FrmDanhMucKhachHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuNhacungcap_Click(object sender, EventArgs e)
        {
            Forms.FrmDanhMucNhaCungCap f = new FrmDanhMucNhaCungCap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }

        private void mnuque_Click(object sender, EventArgs e)
        {
            FrmQue f = new FrmQue();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }
    }
}
