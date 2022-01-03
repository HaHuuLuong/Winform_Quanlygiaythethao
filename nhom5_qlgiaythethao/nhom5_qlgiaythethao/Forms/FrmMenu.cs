using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom5_qlgiaythethao
{
    public partial class FrmMenu : Form
    {
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

    }
}
