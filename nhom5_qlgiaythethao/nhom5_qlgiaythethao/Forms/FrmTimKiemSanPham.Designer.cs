﻿namespace nhom5_qlgiaythethao.Forms
{
    partial class FrmTimKiemSanPham
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvTimsp = new System.Windows.Forms.DataGridView();
            this.buttltimlai = new System.Windows.Forms.Button();
            this.buttdong = new System.Windows.Forms.Button();
            this.buttontimkie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsoluong = new System.Windows.Forms.TextBox();
            this.comboBoxmachatlieu = new System.Windows.Forms.ComboBox();
            this.comboBoxmaloai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimsp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(316, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "click đúp để hiện thông tin chi tiết sản phẩm";
            // 
            // dtgvTimsp
            // 
            this.dtgvTimsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTimsp.Location = new System.Drawing.Point(304, 340);
            this.dtgvTimsp.Name = "dtgvTimsp";
            this.dtgvTimsp.RowHeadersWidth = 62;
            this.dtgvTimsp.Size = new System.Drawing.Size(686, 126);
            this.dtgvTimsp.TabIndex = 11;
            this.dtgvTimsp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTimsp_CellDoubleClick);
            // 
            // buttltimlai
            // 
            this.buttltimlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttltimlai.Location = new System.Drawing.Point(568, 541);
            this.buttltimlai.Name = "buttltimlai";
            this.buttltimlai.Size = new System.Drawing.Size(105, 40);
            this.buttltimlai.TabIndex = 10;
            this.buttltimlai.Text = "Tìm lại";
            this.buttltimlai.UseVisualStyleBackColor = true;
            this.buttltimlai.Click += new System.EventHandler(this.buttltimlai_Click);
            // 
            // buttdong
            // 
            this.buttdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttdong.Location = new System.Drawing.Point(723, 541);
            this.buttdong.Name = "buttdong";
            this.buttdong.Size = new System.Drawing.Size(99, 40);
            this.buttdong.TabIndex = 9;
            this.buttdong.Text = "Đóng";
            this.buttdong.UseVisualStyleBackColor = true;
            this.buttdong.Click += new System.EventHandler(this.buttdong_Click);
            // 
            // buttontimkie
            // 
            this.buttontimkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontimkie.Location = new System.Drawing.Point(418, 541);
            this.buttontimkie.Name = "buttontimkie";
            this.buttontimkie.Size = new System.Drawing.Size(93, 40);
            this.buttontimkie.TabIndex = 8;
            this.buttontimkie.Text = "Tìm kiếm";
            this.buttontimkie.UseVisualStyleBackColor = true;
            this.buttontimkie.Click += new System.EventHandler(this.buttontimkie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxsoluong);
            this.groupBox1.Controls.Add(this.comboBoxmachatlieu);
            this.groupBox1.Controls.Add(this.comboBoxmaloai);
            this.groupBox1.Location = new System.Drawing.Point(443, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 239);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã chất liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã loại";
            // 
            // textBoxsoluong
            // 
            this.textBoxsoluong.Location = new System.Drawing.Point(150, 103);
            this.textBoxsoluong.Name = "textBoxsoluong";
            this.textBoxsoluong.Size = new System.Drawing.Size(121, 26);
            this.textBoxsoluong.TabIndex = 2;
            this.textBoxsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsoluong_KeyPress);
            // 
            // comboBoxmachatlieu
            // 
            this.comboBoxmachatlieu.FormattingEnabled = true;
            this.comboBoxmachatlieu.Location = new System.Drawing.Point(150, 68);
            this.comboBoxmachatlieu.Name = "comboBoxmachatlieu";
            this.comboBoxmachatlieu.Size = new System.Drawing.Size(121, 28);
            this.comboBoxmachatlieu.TabIndex = 1;
            // 
            // comboBoxmaloai
            // 
            this.comboBoxmaloai.FormattingEnabled = true;
            this.comboBoxmaloai.Location = new System.Drawing.Point(150, 29);
            this.comboBoxmaloai.Name = "comboBoxmaloai";
            this.comboBoxmaloai.Size = new System.Drawing.Size(121, 28);
            this.comboBoxmaloai.TabIndex = 0;
            // 
            // FrmTimKiemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1299, 704);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvTimsp);
            this.Controls.Add(this.buttltimlai);
            this.Controls.Add(this.buttdong);
            this.Controls.Add(this.buttontimkie);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTimKiemSanPham";
            this.Text = "FrmTimKiemSanPham";
            this.Load += new System.EventHandler(this.FrmTimKiemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTimsp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvTimsp;
        private System.Windows.Forms.Button buttltimlai;
        private System.Windows.Forms.Button buttdong;
        private System.Windows.Forms.Button buttontimkie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsoluong;
        private System.Windows.Forms.ComboBox comboBoxmachatlieu;
        private System.Windows.Forms.ComboBox comboBoxmaloai;
    }
}