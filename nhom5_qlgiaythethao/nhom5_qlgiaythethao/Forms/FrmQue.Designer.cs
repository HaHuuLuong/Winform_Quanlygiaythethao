namespace nhom5_qlgiaythethao.Forms
{
    partial class FrmQue
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
            this.txttenque = new System.Windows.Forms.TextBox();
            this.txtmaque = new System.Windows.Forms.TextBox();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txttenque
            // 
            this.txttenque.Location = new System.Drawing.Point(294, 164);
            this.txttenque.Name = "txttenque";
            this.txttenque.Size = new System.Drawing.Size(134, 26);
            this.txttenque.TabIndex = 21;
            // 
            // txtmaque
            // 
            this.txtmaque.Location = new System.Drawing.Point(294, 123);
            this.txtmaque.Name = "txtmaque";
            this.txtmaque.Size = new System.Drawing.Size(134, 26);
            this.txtmaque.TabIndex = 20;
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(618, 210);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(74, 38);
            this.btnboqua.TabIndex = 19;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(618, 281);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(74, 38);
            this.btnluu.TabIndex = 18;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(618, 354);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(74, 38);
            this.btndong.TabIndex = 17;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(508, 354);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(74, 38);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(508, 281);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(74, 38);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(508, 210);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(74, 38);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(180, 214);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(292, 178);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên quê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã quê";
            // 
            // FrmQue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 514);
            this.Controls.Add(this.txttenque);
            this.Controls.Add(this.txtmaque);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQue";
            this.Text = "FrmQue";
            this.Load += new System.EventHandler(this.FrmQue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttenque;
        private System.Windows.Forms.TextBox txtmaque;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}