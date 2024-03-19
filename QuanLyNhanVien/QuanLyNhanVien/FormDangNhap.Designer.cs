namespace QuanLyNhanVien
{
    partial class FormDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbTaiKhoan = new TextBox();
            tbMatKhau = new TextBox();
            btDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(411, 20);
            label1.Name = "label1";
            label1.Size = new Size(247, 59);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 140);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 1;
            label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 235);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu";
            // 
            // tbTaiKhoan
            // 
            tbTaiKhoan.Location = new Point(351, 140);
            tbTaiKhoan.Name = "tbTaiKhoan";
            tbTaiKhoan.Size = new Size(499, 39);
            tbTaiKhoan.TabIndex = 3;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(351, 235);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(499, 39);
            tbMatKhau.TabIndex = 4;
            // 
            // btDangNhap
            // 
            btDangNhap.BackColor = SystemColors.GradientActiveCaption;
            btDangNhap.Location = new Point(439, 332);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(185, 68);
            btDangNhap.TabIndex = 5;
            btDangNhap.Text = "Đăng Nhập";
            btDangNhap.UseVisualStyleBackColor = false;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 469);
            Controls.Add(btDangNhap);
            Controls.Add(tbMatKhau);
            Controls.Add(tbTaiKhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDangNhap";
            Text = "Đăng Nhập";
            Load += FormDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbTaiKhoan;
        private TextBox tbMatKhau;
        private Button btDangNhap;
    }
}