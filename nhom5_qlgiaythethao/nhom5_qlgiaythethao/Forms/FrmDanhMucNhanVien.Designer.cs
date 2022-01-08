namespace nhom5_qlgiaythethao.Forms
{
    partial class FrmDanhMucNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.mskngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msksđt = new System.Windows.Forms.MaskedTextBox();
            this.ckhgioitinh = new System.Windows.Forms.CheckBox();
            this.cbomaque = new System.Windows.Forms.ComboBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(362, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btndong.Image = global::nhom5_qlgiaythethao.Properties.Resources.Custom_Icon_Design_Flatastic_9_Login;
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndong.Location = new System.Drawing.Point(869, 526);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(105, 61);
            this.btndong.TabIndex = 49;
            this.btndong.Text = "Đóng";
            this.btndong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnboqua.Image = global::nhom5_qlgiaythethao.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Skip_forward;
            this.btnboqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboqua.Location = new System.Drawing.Point(610, 527);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(119, 61);
            this.btnboqua.TabIndex = 48;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = global::nhom5_qlgiaythethao.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(498, 529);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(98, 58);
            this.btnluu.TabIndex = 47;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Teal;
            this.btnxoa.Image = global::nhom5_qlgiaythethao.Properties.Resources.Hopstarter_Soft_Scraps_File_Delete;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(738, 529);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(108, 58);
            this.btnxoa.TabIndex = 46;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Red;
            this.btnsua.Image = global::nhom5_qlgiaythethao.Properties.Resources.Bokehlicia_Captiva_Edit_tomboy1;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(368, 527);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(108, 59);
            this.btnsua.TabIndex = 45;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // mskngaysinh
            // 
            this.mskngaysinh.Location = new System.Drawing.Point(396, 247);
            this.mskngaysinh.Mask = "00/00/0000";
            this.mskngaysinh.Name = "mskngaysinh";
            this.mskngaysinh.Size = new System.Drawing.Size(135, 26);
            this.mskngaysinh.TabIndex = 44;
            this.mskngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(709, 189);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(137, 26);
            this.txtdiachi.TabIndex = 43;
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(396, 191);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(135, 26);
            this.txttennhanvien.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Số Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Mã quê";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // msksđt
            // 
            this.msksđt.Location = new System.Drawing.Point(709, 253);
            this.msksđt.Mask = "(999) 000-0000";
            this.msksđt.Name = "msksđt";
            this.msksđt.Size = new System.Drawing.Size(137, 26);
            this.msksđt.TabIndex = 34;
            // 
            // ckhgioitinh
            // 
            this.ckhgioitinh.AutoSize = true;
            this.ckhgioitinh.Location = new System.Drawing.Point(426, 292);
            this.ckhgioitinh.Name = "ckhgioitinh";
            this.ckhgioitinh.Size = new System.Drawing.Size(68, 24);
            this.ckhgioitinh.TabIndex = 33;
            this.ckhgioitinh.Text = "Nam";
            this.ckhgioitinh.UseVisualStyleBackColor = true;
            // 
            // cbomaque
            // 
            this.cbomaque.FormattingEnabled = true;
            this.cbomaque.Location = new System.Drawing.Point(709, 137);
            this.cbomaque.Name = "cbomaque";
            this.cbomaque.Size = new System.Drawing.Size(137, 28);
            this.cbomaque.TabIndex = 32;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(396, 137);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(135, 26);
            this.txtmanhanvien.TabIndex = 31;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnthem.Image = global::nhom5_qlgiaythethao.Properties.Resources.Hopstarter_Soft_Scraps_Folder_Add;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(222, 527);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(124, 59);
            this.btnthem.TabIndex = 29;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(319, 330);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(564, 161);
            this.dataGridView.TabIndex = 28;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // FrmDanhMucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1184, 685);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.mskngaysinh);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msksđt);
            this.Controls.Add(this.ckhgioitinh);
            this.Controls.Add(this.cbomaque);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "FrmDanhMucNhanVien";
            this.Text = "FrmDanhMucNhanVien";
            this.Load += new System.EventHandler(this.FrmDanhMucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.MaskedTextBox mskngaysinh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msksđt;
        private System.Windows.Forms.CheckBox ckhgioitinh;
        private System.Windows.Forms.ComboBox cbomaque;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}