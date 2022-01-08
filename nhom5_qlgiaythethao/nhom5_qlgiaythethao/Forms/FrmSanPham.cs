using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nhom5_qlgiaythethao.Forms
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }
        DataTable tblsp;
        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            txtMasanpham.Enabled = false;
            buttonluu.Enabled = false;
            buttonboqua.Enabled = false;
            Class.Functions.FillCombo("SELECT MaLoai, TenLoai FROM tblTheLoai", comboBoxmaloai, "MaLoai", "TenLoai");
            comboBoxmaloai.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaNuoc, TenNuoc FROM tblNuocSanXuat", comboBoxmanuoc, "MaNuoc", "TenNuoc");
            comboBoxmanuoc.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaChatLieu, TenChatLieu FROM tblChatLieu", comboBoxmachatlieu, "MaChatLieu", "TenChatLieu");
            comboBoxmachatlieu.SelectedIndex = -1;
            Class.Functions.FillCombo("SELECT MaMau, TenMau FROM tblMauSac", comboBoxmamau, "MaMau", "TenMau");
            comboBoxmamau.SelectedIndex = -1;

            buttonsua.Enabled = false;
            buttonxoa.Enabled = false;
            buttonboqua.Enabled = false;
            buttonopen.Enabled = false;
            Load_DataGridView();
        }
        //
       // string sql;
        public string sql = "SELECT MaSanPham, TenSanPham, GiaNhap, GiaBan, SoLuong, HinhAnh, MaLoai, MaNuoc, MaChatLieu, MaMau FROM tblSanPham ";
        private void Load_DataGridView()
        {
             //where MaSanPham=N'" + txtMasanpham.Text + "' 
            tblsp = Class.Functions.GetDataToTable(sql);
            dtgvsp.DataSource = tblsp;
            dtgvsp.Columns[0].HeaderText = "Mã sản phẩm";
            dtgvsp.Columns[1].HeaderText = "Tên sản phẩm";
            dtgvsp.Columns[2].HeaderText = "Giá nhập";
            dtgvsp.Columns[3].HeaderText = "Giá bán";
            dtgvsp.Columns[4].HeaderText = "Số lượng";
            dtgvsp.Columns[5].HeaderText = "Hình ảnh";
            dtgvsp.Columns[6].HeaderText = "Mã loại";
            dtgvsp.Columns[7].HeaderText = "Mã nước";
            dtgvsp.Columns[8].HeaderText = "Mã chất liệu";
            dtgvsp.Columns[9].HeaderText = "Mã màu";
            dtgvsp.Columns[0].Width = 80;
            dtgvsp.Columns[1].Width = 100;
            dtgvsp.Columns[2].Width = 80;
            dtgvsp.Columns[3].Width = 80;
            dtgvsp.Columns[4].Width = 80;
            dtgvsp.Columns[5].Width = 200;
            dtgvsp.Columns[6].Width = 80;
            dtgvsp.Columns[7].Width = 80;
            dtgvsp.Columns[8].Width = 80;
            dtgvsp.Columns[9].Width = 80;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dtgvsp.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dtgvsp.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMasanpham.Text = "";
            comboBoxmaloai.Text = "";
            comboBoxmanuoc.Text = "";
            comboBoxmachatlieu.Text = "";
            comboBoxmamau.Text = "";
            textBoxtensp.Text = "";
            textBoxgianhap.Text = "";
            textBoxgiaban.Text = "";
            textBoxsoluong.Text = "";
            textBoxhinhanh.Text = "";
            pictureBox1.Image = null;

        }

        private void dtgvsp_Click(object sender, EventArgs e)
        {
            string ma;
            if (buttonthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            if (tblsp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMasanpham.Text = dtgvsp.CurrentRow.Cells["MaSanPham"].Value.ToString();
            ma = dtgvsp.CurrentRow.Cells["MaLoai"].Value.ToString();
            comboBoxmaloai.Text = Class.Functions.GetFieldValues("select TenLoai from tblTheLoai where MaLoai = N'" + ma + "'");
            ma = dtgvsp.CurrentRow.Cells["MaNuoc"].Value.ToString();
            comboBoxmanuoc.Text = Class.Functions.GetFieldValues("select TenNuoc from tblNuocSanXuat where manuoc = N'" + ma + "'");
            ma = dtgvsp.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            comboBoxmachatlieu.Text = Class.Functions.GetFieldValues("select TenChatLieu from tblChatLieu where MaChatLieu = N'" + ma + "'");
            ma = dtgvsp.CurrentRow.Cells["MaMau"].Value.ToString();
            comboBoxmamau.Text = Class.Functions.GetFieldValues("select TenMau from tblMauSac where MaMau = N'" + ma + "'");
            textBoxtensp.Text = dtgvsp.CurrentRow.Cells["TenSanPham"].Value.ToString();
            textBoxgianhap.Text = dtgvsp.CurrentRow.Cells["GiaNhap"].Value.ToString();
            textBoxgiaban.Text = dtgvsp.CurrentRow.Cells["GiaBan"].Value.ToString();
            textBoxsoluong.Text = dtgvsp.CurrentRow.Cells["SoLuong"].Value.ToString();
            textBoxhinhanh.Text = Class.Functions.GetFieldValues("SELECT HinhAnh FROM tblSanPham WHERE MaSanPham = N'" + txtMasanpham.Text + "'");
            //picAnh.Image = Image.FromFile(txtHinhanh.Text);

            if (textBoxhinhanh.Text != "")
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(textBoxhinhanh.Text);
            }
            else
            {
                pictureBox1.Visible = false;
            }
            buttonsua.Enabled = true;
            buttonxoa.Enabled = true;
            buttonboqua.Enabled = true;
            buttonopen.Enabled = true;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            buttonsua.Enabled = false;
            buttonxoa.Enabled = false;
            buttonboqua.Enabled = true;
            buttonluu.Enabled = true;
            buttonthem.Enabled = false;
            buttonopen.Enabled = true;
            ResetValues();
            txtMasanpham.Enabled = true;
            txtMasanpham.Focus();
        }

        private void buttonluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMasanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasanpham.Focus();
                return;
            }
            if (textBoxtensp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxtensp.Focus();
                return;
            }
            if (textBoxgianhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá nhập cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxgianhap.Focus();
                return;
            }
            if (textBoxgiaban.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá bán cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxgiaban.Focus();
                return;
            }
            if (textBoxsoluong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxsoluong.Focus();
                return;
            }
            if (textBoxhinhanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxhinhanh.Focus();
                return;
            }
            if (comboBoxmaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxmaloai.Focus();
                return;
            }
            if (comboBoxmanuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxmanuoc.Focus();
                return;
            }
            if (comboBoxmachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxmachatlieu.Focus();
                return;
            }
            if (comboBoxmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxmamau.Focus();
                return;
            }



            sql = "SELECT MaSanPham FROM tblSanPham WHERE MaSanPham = N'" + txtMasanpham.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasanpham.Focus();
                txtMasanpham.Text = "";
                return;
            }
            sql = "insert into dbo.tblSanPham values(N'" + txtMasanpham.Text.Trim() + "',N'" + textBoxtensp.Text.Trim() + "'," + textBoxgianhap.Text.Trim() + "," + textBoxgiaban.Text.Trim() + "," + textBoxsoluong.Text.Trim() + ",N'" + textBoxhinhanh.Text.Trim() + "',N'" + comboBoxmaloai.SelectedValue + "',N'" + comboBoxmanuoc.SelectedValue + "',N'" + comboBoxmachatlieu.SelectedValue + "',N'" + comboBoxmamau.SelectedValue + "')";
            SqlCommand them = new SqlCommand(sql, Class.Functions.Conn);
            them.ExecuteNonQuery();
            MessageBox.Show("Thêm dữ liệu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Load_DataGridView();
            ResetValues();
            buttonxoa.Enabled = false;
            buttonthem.Enabled = true;
            buttonsua.Enabled = false;
            buttonboqua.Enabled = true;
            buttonluu.Enabled = false;
            txtMasanpham.Enabled = false;
        }

        private void buttonopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = @"D:\picture123";
            dlgOpen.FilterIndex = 4;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
                textBoxhinhanh.Text = dlgOpen.FileName;
            }
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblsp.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxtensp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxtensp.Focus();
                return;
            }
            if (textBoxgianhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá nhập cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxgianhap.Focus();
                return;
            }
            if (textBoxgiaban.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá bán cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxgiaban.Focus();
                return;
            }
            if (textBoxsoluong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxsoluong.Focus();
                return;
            }
            if (textBoxhinhanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxhinhanh.Focus();
                return;
            }
            if (comboBoxmaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxmaloai.Focus();
                return;
            }
            if (comboBoxmanuoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxmanuoc.Focus();
                return;
            }
            if (comboBoxmachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxmachatlieu.Focus();
                return;
            }
            if (comboBoxmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxmamau.Focus();
                return;
            }

            sql = "UPDATE tblSanPham SET  TenSanPham=N'" + textBoxtensp.Text.Trim().ToString() + "',GiaNhap= " + textBoxgianhap.Text.Trim() + ",GiaBan=" + textBoxgiaban.Text.Trim() + ",SoLuong=" + textBoxsoluong.Text.Trim() + ",HinhAnh=N'" + textBoxhinhanh.Text.Trim() + "',MaLoai=N'" + comboBoxmaloai.SelectedValue + "',MaNuoc=N'" + comboBoxmanuoc.SelectedValue + "',MaChatLieu=N'" + comboBoxmachatlieu.SelectedValue + "',MaMau=N'" + comboBoxmamau.SelectedValue + "' where MaSanPham=N'" + txtMasanpham.Text.Trim() + "'"; ;
            Class.Functions.RunSql(sql);
            MessageBox.Show("Đã sửa dữ liệu");
            Load_DataGridView();
            ResetValues();
            buttonboqua.Enabled = false;
            buttonopen.Enabled = false;
            buttonluu.Enabled = false;
        }

        private void buttonboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            buttonboqua.Enabled = true;
            buttonthem.Enabled = true;
            buttonxoa.Enabled = true;
            buttonsua.Enabled = true;
            buttonluu.Enabled = false;
            txtMasanpham.Enabled = false;
            buttonopen.Enabled = false;
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblsp.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblSanPham WHERE MaSanPham = N'" + txtMasanpham.Text + "'";
                Class.Functions.RunSqlDel(sql);
                MessageBox.Show("Đã xóa dữ liệu");
                Load_DataGridView();
                ResetValues();
            }

        }

        private void textBoxgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxgiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void buttondong_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn thoát? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
