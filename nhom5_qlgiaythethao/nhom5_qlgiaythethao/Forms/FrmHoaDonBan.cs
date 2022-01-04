using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using nhom5_qlgiaythethao.Class;
namespace nhom5_qlgiaythethao.Forms
{
    public partial class FrmHoaDonBan : Form
    {
        public FrmHoaDonBan()
        {
            InitializeComponent();
        }
        DataTable tblHDB;
        
        
        
        private void ResetValues()
        {
            txtmahoadonban.Text = "";
            txtngayban.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtsoluong.Text = "";
            txtkhuyenmai.Text = "0";
            txtthanhtien.Text = "0";
            txttennhanvien.Text = "";
            txttensanpham.Text = "";
            txtgiaban.Text = "";
            cbomanhanvien.Text = "";
            cbomakhachhang.Text = "";
            txttongtien.Text = "0";
            lblbangchu.Text = "Bằng chữ: ";
            cbomasanpham.Text = "";
            txtdiachikhachhang.Text = "";
        }

       
        private void ResetValuesHang()
        {
            cbomasanpham.Text = "";
            txtsoluong.Text = "";
            txtkhuyenmai.Text = "0";
            txtthanhtien.Text = "0";
        }

        
        private void DelHang(string Mahoadon, string Mahang)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT SoLuong FROM tblChiTietHoaDonBan WHERE MaHoaDonBan = N'" + Mahoadon + "' AND MaSanPham = N'" + Mahang + "'";
            s = Convert.ToDouble(Functions.GetFieldValues(sql));
            sql = "DELETE tblChiTietHoaDonBan WHERE MaHoaDonBan =N'" + Mahoadon + "' AND MaSanPham = N'" + Mahang + "'";
            Functions.RunSqlDel(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT SoLuong FROM tblSanPham WHERE MaSanPham = N'" + Mahang + "'";
            sl = Convert.ToDouble(Functions.GetFieldValues(sql));
            SLcon = sl + s;
            sql = "UPDATE tblSanPham SET SoLuong =" + SLcon + " WHERE MaSanPham= N'" + Mahang + "'";
            Functions.RunSql(sql);
        }
        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT TongTien FROM tblHoaDonBan WHERE MaHoaDonBan = N'" + Mahoadon + "'";
            Tong = Convert.ToDouble(Functions.GetFieldValues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblHoaDonBan SET TongTien =" + Tongmoi + " WHERE MaHoaDonBan = N'" + Mahoadon + "'";
            Functions.RunSql(sql);
            txttongtien.Text = Tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
        }
     
     
        private void groupSp_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHoaDonBan_Load(object sender, EventArgs e)
        {
            btnthemmoi.Enabled = true;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            txtmahoadonban.ReadOnly = true;
            txttennhanvien.ReadOnly = true;
            txtdiachikhachhang.ReadOnly = true;
            txttensanpham.ReadOnly = true;
            txtgiaban.ReadOnly = true;
            txtthanhtien.ReadOnly = true;
            txttongtien.ReadOnly = true;
            txtkhuyenmai.Text = "0";
            txttongtien.Text = "0";
            Functions.FillCombo("SELECT MaKhachHang FROM tblKhachHang", cbomakhachhang, "MaKhachHang", "MaKhachHang");
            cbomakhachhang.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNhanVien FROM tblNhanvien", cbomanhanvien, "MaNhanVien", "MaNhanVien");
            cbomanhanvien.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaSanPham FROM tblSanPham", cbomasanpham, "MaSanPham", "MaSanPham");
            cbomasanpham.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHoaDonBan FROM tblChiTietHoaDonBan", cbomahoadonban, "MaHoaDonBan", "MaHoaDonBan");
            cbomahoadonban.SelectedIndex = -1;
            if (txtmahoadonban.Text != "")
            {
                ThongtinHD();
                btnhuy.Enabled = true;
            }
            Load_DataGridViewChitiet();
        }
        private void Load_DataGridViewChitiet()
        {
            string sql;
            sql = "SELECT b.MaSanPham, b.TenSanPham, a.SoLuong, b.GiaBan, a.KhuyenMai, a.ThanhTien FROM tblChiTietHoaDonBan AS a JOIN tblSanPham AS b ON a.MaSanPham=b.MaSanPham WHERE a.MaHoaDonBan = N'" + txtmahoadonban.Text + "'";
            tblHDB = Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblHDB;
            DataGridView.Columns[0].HeaderText = "Mã sản phẩm";
            DataGridView.Columns[1].HeaderText = "Tên sản phẩm";
            DataGridView.Columns[2].HeaderText = "Số lượng";
            DataGridView.Columns[3].HeaderText = "Giá bán";
            DataGridView.Columns[4].HeaderText = "Khuyến mại";
            DataGridView.Columns[5].HeaderText = "Thành tiền";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ThongtinHD()
        {
            string str;
            str = "SELECT NgayBan FROM tblHoaDonBan WHERE MaHoaDonBan = N'" + txtmahoadonban.Text + "'";
            txtngayban.Text = Functions.GetFieldValues(str);
            str = "SELECT MaNhanVien FROM tblHoaDonBan WHERE MaHoaDonBan = N'" + txtmahoadonban.Text + "'";
            cbomanhanvien.Text = Functions.GetFieldValues(str);

            str = "SELECT MaKhachHang FROM tblHoaDonBan WHERE MaHoaDonBan = N'" + txtmahoadonban.Text + "'";
            cbomakhachhang.Text = Functions.GetFieldValues(str);

            str = "SELECT TongTien FROM tblHoaDonBan WHERE MaHoaDonBan = N'" + txtmahoadonban.Text + "'";
            txttongtien.Text = Functions.GetFieldValues(str);


            lblbangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txttongtien.Text);
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            //groupThongtinchung.Enabled = true;
            btnboqua.Enabled = true;
            btnhuy.Enabled = false;
            btnluu.Enabled = true;
            btnthemmoi.Enabled = false;
            cbomasanpham.Enabled = true;
            cbomakhachhang.Enabled = true;
            ResetValues();
            txtmahoadonban.Text = Functions.CreateKey("HDB");
            Load_DataGridViewChitiet();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHoaDonBan FROM tblHoaDonBan WHERE MaHoaDonBan=N'" + txtmahoadonban.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (txtngayban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtngayban.Focus();
                    return;
                }
                if (cbomanhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomanhanvien.Focus();
                    return;
                }
                if (cbomakhachhang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomakhachhang.Focus();
                    return;
                }
                sql = "INSERT INTO tblHoaDonBan(MaHoaDonBan, Ngayban, MaNhanVien, MaKhachHang, TongTien) " +
                    "VALUES(N'" + txtmahoadonban.Text.Trim() + "', '" +
                        Functions.ConvertDateTime(txtngayban.Text.Trim()) + "',N'" + cbomanhanvien.SelectedValue + "',N'" +
                        cbomakhachhang.SelectedValue + "'," + txttongtien.Text + ")";
                Functions.RunSql(sql);
            }

            // Kiểm tra ràng buộc để lưu thông tin của các mặt hàng
            if (cbomasanpham.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomasanpham.Focus();
                return;
            }
            if ((txtsoluong.Text.Trim().Length == 0) || (txtsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            if (txtkhuyenmai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khuyến mãi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkhuyenmai.Focus();
                return;
            }
            sql = "SELECT MaSanPham FROM tblChiTietHoaDonBan WHERE MaSanPham=N'" + cbomasanpham.SelectedValue + "' AND mahoadonban = N'" + txtmahoadonban.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesHang();
                cbomasanpham.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanPham WHERE MaSanPham = N'" + cbomasanpham.SelectedValue + "'"));
            if (Convert.ToDouble(txtsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            sql = "INSERT INTO tblChiTietHoaDonBan(MaHoaDonBan,MaSanPham, SoLuong, KhuyenMai, ThanhTien) VALUES(N'" + txtmahoadonban.Text.Trim() + "', N'" + cbomasanpham.SelectedValue + "'," + txtsoluong.Text + "," + txtkhuyenmai.Text + "," + txtthanhtien.Text + ")";

            Functions.RunSql(sql);
            Load_DataGridViewChitiet();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblsanpham
            SLcon = sl - Convert.ToDouble(txtsoluong.Text);
            sql = "UPDATE tblSanPham SET SoLuong =" + SLcon + " WHERE MaSanPham= N'" + cbomasanpham.SelectedValue + "'";
            Functions.RunSql(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán

            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblHoaDonBan WHERE MaHoaDonBan = N'" + txtmahoadonban.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
            sql = "UPDATE tblHoaDonBan SET TongTien =" + Tongmoi + " WHERE MaHoaDonBan = N'" + txtmahoadonban.Text + "'";
            Functions.RunSql(sql);
            txttongtien.Text = Tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btnhuy.Enabled = true;
            btnthemmoi.Enabled = true;
            groupThongtinchung.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthemmoi.Enabled = true;
            btnhuy.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = true;
            txtmahoadonban.Enabled = false;
            txtngayban.Text = "";
            DataGridView.DataSource = null;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT MaSanPham FROM tblChiTietHoaDonBan WHERE MaHoaDonBan = N'" + txtmahoadonban.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Functions.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                //Xóa danh sách các mặt hàng của hóa đơn
                for (i = 0; i <= n - 1; i++)
                    DelHang(txtmahoadonban.Text, Mahang[i]);
                //Xóa hóa đơn
                sql = "DELETE tblHoaDonBan WHERE MaHoaDonBan =N'" + txtmahoadonban.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                Load_DataGridViewChitiet();
                btnhuy.Enabled = false;
                txttensanpham.Text = "";
                txttennhanvien.Text = "";
                txtngayban.Text = "";
                txtgiaban.Text = "";
                txtdiachikhachhang.Text = "";

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtmahoadonban.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bảng ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbomanhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbomasanpham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql;
            sql = "UPDATE tblHoaDonBan SET NgayBan = N'" + Functions.ConvertDateTime(txtngayban.Text) + "', manhanvien = N'" + cbomanhanvien.SelectedValue.ToString() + "' WHERE mahoadonban = N'" + txtmahoadonban.Text + "'";
            Functions.RunSql(sql);
            double sl;
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblSanPham WHERE MaSanPham = N'" + cbomasanpham.Text + "'"));
            // MessageBox.Show(Functions.GetFieldValues("SELECT soluong FROM tblsanpham WHERE masanpham = N'" + cbomasanpham.Text + "'"));
            //xử lý lại tổng số sản phẩm (tính cả hàng có trong tblsanpham vs tblchitiethoadonban) vì sửa nên phải cộng số lượng lại để ra số lượng ban đầu
            double sl1, sl2;
            sl1 = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblChiTietHoaDonBan WHERE MaSanPham = N'" + cbomasanpham.Text + "'AND MaHoaDonBan = N'" + txtmahoadonban.Text + "'"));
            //  MessageBox.Show(Functions.GetFieldValues("SELECT soluong FROM tblchitiethoadonban WHERE masanpham = N'" + cbomasanpham.Text + "'AND mahoadonban = N'" + txtmahoadonban.Text + "'"));

            sl2 = sl1 + sl;

            if (Convert.ToDouble(txtsoluong.Text) > sl2)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl2, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }

            double SLcon;
            double slmoi;
            slmoi = Convert.ToDouble(txtsoluong.Text);
            SLcon = sl2 - slmoi;

            sql = "UPDATE tblChiTietHoaDonBan SET MaSanPham = N'" + cbomasanpham.Text + "', SoLuong = " + Convert.ToSingle(txtsoluong.Text) + ", khuyenmai = " + Convert.ToSingle(txtkhuyenmai.Text) + ", ThanhTien = " + Convert.ToSingle(txtthanhtien.Text) + " WHERE MaSanPham = N'" + cbomasanpham.Text + "'AND MaHoaDonBan = N'" + txtmahoadonban.Text + "'";
            Functions.RunSql(sql);


            // Cập nhật lại số lượng của mặt hàng vào bảng tblsanpham
            sql = "UPDATE tblSanPham SET SoLuong =" + SLcon + " WHERE MaSanPham= N'" + cbomasanpham.Text + "'";
            //MessageBox.Show(SLcon.ToString());
            Functions.RunSql(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán            
            string thanhtien;
            thanhtien = "SELECT SUM(ThanhTien) FROM tblChiTietHoaDonBan WHERE MaHoaDonBan = N'" + txtmahoadonban.Text + "'  GROUP BY MaHoaDonBan";
            string tt;
            tt = Functions.GetFieldValues(thanhtien);
            sql = "UPDATE tblHoaDonBan SET TongTien =" + Convert.ToSingle(tt) + " WHERE MaHoaDonBan = N'" + txtmahoadonban.Text + "'";
            Functions.RunSql(sql);
            txttongtien.Text = tt.ToString();
            lblbangchu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tt.ToString());
            ResetValuesHang();
            btnhuy.Enabled = true;
            btnthemmoi.Enabled = true;
            Load_DataGridViewChitiet();
            btnboqua.Enabled = true;
        }


        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahang;
            Double Thanhtien;
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                mahang = DataGridView.CurrentRow.Cells["MaSanPham"].Value.ToString();
                DelHang(txtmahoadonban.Text, mahang);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                Thanhtien = Convert.ToDouble(DataGridView.CurrentRow.Cells["ThanhTien"].Value.ToString());
                DelUpdateTongtien(txtmahoadonban.Text, Thanhtien);
                Load_DataGridViewChitiet();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbomahoadonban.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahoadonban.Focus();
                return;
            }
            txtmahoadonban.Text = cbomahoadonban.Text;
            ThongtinHD();
            Load_DataGridViewChitiet();
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            cbomahoadonban.SelectedIndex = -1;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            cbomakhachhang.Enabled = false;
            groupThongtinchung.Enabled = false;
            cbomasanpham.Enabled = false;
            if (btnthemmoi.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahoadonban.Focus();
                return;
            }
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ma;
            ma = DataGridView.CurrentRow.Cells["MaSanPham"].Value.ToString();
            cbomasanpham.Text = Functions.GetFieldValues("SELECT MaSanPham FROM tblChiTietHoaDonBan WHERE MaSanPham = N'" + ma + "'");
            txtsoluong.Text = DataGridView.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtkhuyenmai.Text = DataGridView.CurrentRow.Cells["KhuyenMai"].Value.ToString();
            string s = "SELECT TenNhanVien FROM tblNhanvien WHERE MaNhanVien = N'" + cbomanhanvien.Text + "'";
            txttennhanvien.Text = Functions.GetFieldValues(s);
            btnboqua.Enabled = true;
        }

        private void cbomanhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomanhanvien.Text == "")
                txttennhanvien.Text = "";
            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra
            str = "Select TenNhanVien from tblNhanvien where MaNhanVien =N'" + cbomanhanvien.SelectedValue + "'";
            txttennhanvien.Text = Functions.GetFieldValues(str);
        }

        private void cbomakhachhang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomakhachhang.Text == "")
            {
                txtdiachikhachhang.Text = "";
            }
            //Khi kich chon Ma khach thi  dia chi se tu dong hien ra

            str = "Select DiaChi from tblKhachHang where MaKhachHang = N'" + cbomakhachhang.SelectedValue + "'";
            txtdiachikhachhang.Text = Functions.GetFieldValues(str);
        }

        private void cbomasanpham_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomasanpham.Text == "")
            {
                txttensanpham.Text = "";
                txtgiaban.Text = "";
            }
            // Khi kich chon Ma hang thi ten hang va gia ban se tu dong hien ra
            str = "SELECT TenSanPham FROM tblSanPham WHERE MaSanPham =N'" + cbomasanpham.SelectedValue + "'";
            txttensanpham.Text = Functions.GetFieldValues(str);
            str = "SELECT GiaBan FROM tblSanPham WHERE MaSanPham =N'" + cbomasanpham.SelectedValue + "'";
            txtgiaban.Text = Functions.GetFieldValues(str);
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtkhuyenmai.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtkhuyenmai.Text);
            if (txtgiaban.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtgiaban.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void txtkhuyenmai_TextChanged(object sender, EventArgs e)
        {
            //Khi thay doi So luong, Giam gia thi Thanh tien tu dong cap nhat lai gia tri
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtkhuyenmai.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtkhuyenmai.Text);
            if (txtgiaban.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtgiaban.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void cbomahoadonban_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaHoaDonBan FROM tblHoaDonBan", cbomahoadonban, "MaHoaDonBan", "MaHoaDonBan");
            cbomahoadonban.SelectedIndex = -1;
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
    
}
