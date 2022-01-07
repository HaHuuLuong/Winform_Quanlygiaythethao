namespace nhom5_qlgiaythethao.Forms
{
    partial class FrmSanPham
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
            this.dtgvsp = new System.Windows.Forms.DataGridView();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonluu = new System.Windows.Forms.Button();
            this.buttonboqua = new System.Windows.Forms.Button();
            this.buttondong = new System.Windows.Forms.Button();
            this.buttonthem = new System.Windows.Forms.Button();
            this.buttonopen = new System.Windows.Forms.Button();
            this.comboBoxmaloai = new System.Windows.Forms.ComboBox();
            this.comboBoxmachatlieu = new System.Windows.Forms.ComboBox();
            this.comboBoxmamau = new System.Windows.Forms.ComboBox();
            this.comboBoxmanuoc = new System.Windows.Forms.ComboBox();
            this.textBoxhinhanh = new System.Windows.Forms.TextBox();
            this.textBoxgianhap = new System.Windows.Forms.TextBox();
            this.textBoxgiaban = new System.Windows.Forms.TextBox();
            this.textBoxsoluong = new System.Windows.Forms.TextBox();
            this.textBoxtensp = new System.Windows.Forms.TextBox();
            this.txtMasanpham = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvsp
            // 
            this.dtgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvsp.Location = new System.Drawing.Point(273, 393);
            this.dtgvsp.Name = "dtgvsp";
            this.dtgvsp.RowHeadersWidth = 62;
            this.dtgvsp.Size = new System.Drawing.Size(672, 134);
            this.dtgvsp.TabIndex = 58;
            this.dtgvsp.Click += new System.EventHandler(this.dtgvsp_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(380, 553);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(89, 33);
            this.buttonxoa.TabIndex = 57;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.Location = new System.Drawing.Point(501, 553);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(81, 33);
            this.buttonsua.TabIndex = 56;
            this.buttonsua.Text = "Sửa";
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonluu
            // 
            this.buttonluu.Location = new System.Drawing.Point(629, 553);
            this.buttonluu.Name = "buttonluu";
            this.buttonluu.Size = new System.Drawing.Size(86, 33);
            this.buttonluu.TabIndex = 55;
            this.buttonluu.Text = "Lưu";
            this.buttonluu.UseVisualStyleBackColor = true;
            this.buttonluu.Click += new System.EventHandler(this.buttonluu_Click);
            // 
            // buttonboqua
            // 
            this.buttonboqua.Location = new System.Drawing.Point(747, 553);
            this.buttonboqua.Name = "buttonboqua";
            this.buttonboqua.Size = new System.Drawing.Size(83, 33);
            this.buttonboqua.TabIndex = 54;
            this.buttonboqua.Text = "Bỏ qua";
            this.buttonboqua.UseVisualStyleBackColor = true;
            this.buttonboqua.Click += new System.EventHandler(this.buttonboqua_Click);
            // 
            // buttondong
            // 
            this.buttondong.Location = new System.Drawing.Point(867, 553);
            this.buttondong.Name = "buttondong";
            this.buttondong.Size = new System.Drawing.Size(89, 37);
            this.buttondong.TabIndex = 53;
            this.buttondong.Text = "Đóng";
            this.buttondong.UseVisualStyleBackColor = true;
            this.buttondong.Click += new System.EventHandler(this.buttondong_Click);
            // 
            // buttonthem
            // 
            this.buttonthem.Location = new System.Drawing.Point(276, 553);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(80, 33);
            this.buttonthem.TabIndex = 52;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // buttonopen
            // 
            this.buttonopen.Location = new System.Drawing.Point(870, 334);
            this.buttonopen.Name = "buttonopen";
            this.buttonopen.Size = new System.Drawing.Size(89, 35);
            this.buttonopen.TabIndex = 51;
            this.buttonopen.Text = "Open";
            this.buttonopen.UseVisualStyleBackColor = true;
            this.buttonopen.Click += new System.EventHandler(this.buttonopen_Click);
            // 
            // comboBoxmaloai
            // 
            this.comboBoxmaloai.FormattingEnabled = true;
            this.comboBoxmaloai.Location = new System.Drawing.Point(671, 250);
            this.comboBoxmaloai.Name = "comboBoxmaloai";
            this.comboBoxmaloai.Size = new System.Drawing.Size(121, 28);
            this.comboBoxmaloai.TabIndex = 49;
            // 
            // comboBoxmachatlieu
            // 
            this.comboBoxmachatlieu.FormattingEnabled = true;
            this.comboBoxmachatlieu.Location = new System.Drawing.Point(671, 317);
            this.comboBoxmachatlieu.Name = "comboBoxmachatlieu";
            this.comboBoxmachatlieu.Size = new System.Drawing.Size(121, 28);
            this.comboBoxmachatlieu.TabIndex = 48;
            // 
            // comboBoxmamau
            // 
            this.comboBoxmamau.FormattingEnabled = true;
            this.comboBoxmamau.Location = new System.Drawing.Point(671, 220);
            this.comboBoxmamau.Name = "comboBoxmamau";
            this.comboBoxmamau.Size = new System.Drawing.Size(121, 28);
            this.comboBoxmamau.TabIndex = 47;
            // 
            // comboBoxmanuoc
            // 
            this.comboBoxmanuoc.FormattingEnabled = true;
            this.comboBoxmanuoc.Location = new System.Drawing.Point(671, 284);
            this.comboBoxmanuoc.Name = "comboBoxmanuoc";
            this.comboBoxmanuoc.Size = new System.Drawing.Size(121, 28);
            this.comboBoxmanuoc.TabIndex = 46;
            // 
            // textBoxhinhanh
            // 
            this.textBoxhinhanh.Location = new System.Drawing.Point(671, 192);
            this.textBoxhinhanh.Name = "textBoxhinhanh";
            this.textBoxhinhanh.Size = new System.Drawing.Size(121, 26);
            this.textBoxhinhanh.TabIndex = 45;
            // 
            // textBoxgianhap
            // 
            this.textBoxgianhap.Location = new System.Drawing.Point(383, 258);
            this.textBoxgianhap.Name = "textBoxgianhap";
            this.textBoxgianhap.Size = new System.Drawing.Size(121, 26);
            this.textBoxgianhap.TabIndex = 44;
            this.textBoxgianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxgianhap_KeyPress);
            // 
            // textBoxgiaban
            // 
            this.textBoxgiaban.Location = new System.Drawing.Point(383, 285);
            this.textBoxgiaban.Name = "textBoxgiaban";
            this.textBoxgiaban.Size = new System.Drawing.Size(121, 26);
            this.textBoxgiaban.TabIndex = 43;
            this.textBoxgiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxgiaban_KeyPress);
            // 
            // textBoxsoluong
            // 
            this.textBoxsoluong.Location = new System.Drawing.Point(383, 317);
            this.textBoxsoluong.Name = "textBoxsoluong";
            this.textBoxsoluong.Size = new System.Drawing.Size(121, 26);
            this.textBoxsoluong.TabIndex = 42;
            this.textBoxsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsoluong_KeyPress);
            // 
            // textBoxtensp
            // 
            this.textBoxtensp.Location = new System.Drawing.Point(383, 221);
            this.textBoxtensp.Name = "textBoxtensp";
            this.textBoxtensp.Size = new System.Drawing.Size(121, 26);
            this.textBoxtensp.TabIndex = 41;
            // 
            // txtMasanpham
            // 
            this.txtMasanpham.Location = new System.Drawing.Point(383, 192);
            this.txtMasanpham.Name = "txtMasanpham";
            this.txtMasanpham.Size = new System.Drawing.Size(121, 26);
            this.txtMasanpham.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Mã loại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Giá nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mã màu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Hình ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã nước";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mã chất liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã sản phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(833, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 715);
            this.Controls.Add(this.dtgvsp);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonluu);
            this.Controls.Add(this.buttonboqua);
            this.Controls.Add(this.buttondong);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.buttonopen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxmaloai);
            this.Controls.Add(this.comboBoxmachatlieu);
            this.Controls.Add(this.comboBoxmamau);
            this.Controls.Add(this.comboBoxmanuoc);
            this.Controls.Add(this.textBoxhinhanh);
            this.Controls.Add(this.textBoxgianhap);
            this.Controls.Add(this.textBoxgiaban);
            this.Controls.Add(this.textBoxsoluong);
            this.Controls.Add(this.textBoxtensp);
            this.Controls.Add(this.txtMasanpham);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSanPham";
            this.Text = "FrmSanPham";
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvsp;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonluu;
        private System.Windows.Forms.Button buttonboqua;
        private System.Windows.Forms.Button buttondong;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Button buttonopen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxmaloai;
        private System.Windows.Forms.ComboBox comboBoxmachatlieu;
        private System.Windows.Forms.ComboBox comboBoxmamau;
        private System.Windows.Forms.ComboBox comboBoxmanuoc;
        private System.Windows.Forms.TextBox textBoxhinhanh;
        private System.Windows.Forms.TextBox textBoxgianhap;
        private System.Windows.Forms.TextBox textBoxgiaban;
        private System.Windows.Forms.TextBox textBoxsoluong;
        private System.Windows.Forms.TextBox textBoxtensp;
        public System.Windows.Forms.TextBox txtMasanpham;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}