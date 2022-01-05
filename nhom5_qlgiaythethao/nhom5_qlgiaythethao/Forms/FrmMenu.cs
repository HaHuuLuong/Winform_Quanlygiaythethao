using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nhom5_qlgiaythethao.Forms;

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
            Class.Functions.Disconnect();
            Application.Exit();
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
            Forms.FrmTimKiemHoaDonNhap f = new Forms.FrmTimKiemHoaDonNhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
