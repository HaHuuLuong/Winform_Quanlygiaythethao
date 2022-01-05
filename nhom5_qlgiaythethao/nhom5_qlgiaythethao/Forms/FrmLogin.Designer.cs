namespace nhom5_qlgiaythethao.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkLuuMatKhau = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkLuuMatKhau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(333, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 375);
            this.panel1.TabIndex = 16;
            // 
            // chkLuuMatKhau
            // 
            this.chkLuuMatKhau.AutoSize = true;
            this.chkLuuMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.chkLuuMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLuuMatKhau.Location = new System.Drawing.Point(405, 197);
            this.chkLuuMatKhau.Name = "chkLuuMatKhau";
            this.chkLuuMatKhau.Size = new System.Drawing.Size(88, 29);
            this.chkLuuMatKhau.TabIndex = 23;
            this.chkLuuMatKhau.Text = "Save";
            this.chkLuuMatKhau.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(175, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Đăng nhập";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Lime;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(117, 270);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(120, 42);
            this.btnlogin.TabIndex = 18;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(269, 270);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(120, 42);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(225, 200);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(134, 26);
            this.txtMatKhau.TabIndex = 21;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username: ";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(225, 138);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(134, 26);
            this.txtTenDangNhap.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Passwork: ";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 617);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkLuuMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label3;
    }
}