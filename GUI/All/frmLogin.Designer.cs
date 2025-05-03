namespace AppDatLichKham.GUI.All
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbHienthimatkhau = new System.Windows.Forms.CheckBox();
            this.txtTai_khoan = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtMat_khau = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.btnsign = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppDatLichKham.Properties.Resources.Ảnh_hành_tinh_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ckbHienthimatkhau);
            this.panel1.Controls.Add(this.txtTai_khoan);
            this.panel1.Controls.Add(this.txtMat_khau);
            this.panel1.Controls.Add(this.btnsign);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 621);
            this.panel1.TabIndex = 1;
            // 
            // ckbHienthimatkhau
            // 
            this.ckbHienthimatkhau.AutoSize = true;
            this.ckbHienthimatkhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbHienthimatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbHienthimatkhau.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHienthimatkhau.Location = new System.Drawing.Point(155, 335);
            this.ckbHienthimatkhau.Name = "ckbHienthimatkhau";
            this.ckbHienthimatkhau.Size = new System.Drawing.Size(107, 18);
            this.ckbHienthimatkhau.TabIndex = 8;
            this.ckbHienthimatkhau.Text = "Hiển thị mật khẩu";
            this.ckbHienthimatkhau.UseVisualStyleBackColor = false;
            // 
            // txtTai_khoan
            // 
            this.txtTai_khoan.BackColor = System.Drawing.SystemColors.Window;
            this.txtTai_khoan.BorderRadius = 19;
            this.txtTai_khoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTai_khoan.DefaultText = "";
            this.txtTai_khoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTai_khoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTai_khoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTai_khoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTai_khoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTai_khoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTai_khoan.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTai_khoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTai_khoan.Location = new System.Drawing.Point(146, 242);
            this.txtTai_khoan.Margin = new System.Windows.Forms.Padding(2);
            this.txtTai_khoan.Name = "txtTai_khoan";
            this.txtTai_khoan.PasswordChar = '\0';
            this.txtTai_khoan.PlaceholderText = "";
            this.txtTai_khoan.SelectedText = "";
            this.txtTai_khoan.Size = new System.Drawing.Size(236, 29);
            this.txtTai_khoan.TabIndex = 0;
            this.txtTai_khoan.Enter += new System.EventHandler(this.txtTai_khoan_Enter);
            this.txtTai_khoan.Leave += new System.EventHandler(this.txtTai_khoan_Leave);
            // 
            // txtMat_khau
            // 
            this.txtMat_khau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMat_khau.BorderRadius = 19;
            this.txtMat_khau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMat_khau.DefaultText = "";
            this.txtMat_khau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMat_khau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMat_khau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMat_khau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMat_khau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMat_khau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMat_khau.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMat_khau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMat_khau.Location = new System.Drawing.Point(146, 290);
            this.txtMat_khau.Margin = new System.Windows.Forms.Padding(2);
            this.txtMat_khau.Name = "txtMat_khau";
            this.txtMat_khau.PasswordChar = '*';
            this.txtMat_khau.PlaceholderText = "";
            this.txtMat_khau.SelectedText = "";
            this.txtMat_khau.Size = new System.Drawing.Size(236, 29);
            this.txtMat_khau.TabIndex = 1;
            this.txtMat_khau.Enter += new System.EventHandler(this.txtMat_khau_Enter);
            this.txtMat_khau.Leave += new System.EventHandler(this.txtMat_khau_Leave);
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.White;
            this.btnsign.BorderRadius = 19;
            this.btnsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsign.FillColor = System.Drawing.Color.MediumBlue;
            this.btnsign.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsign.ForeColor = System.Drawing.Color.White;
            this.btnsign.Location = new System.Drawing.Point(282, 368);
            this.btnsign.Margin = new System.Windows.Forms.Padding(2);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(100, 37);
            this.btnsign.TabIndex = 3;
            this.btnsign.Text = "Register";
            this.btnsign.Click += new System.EventHandler(this.btnsign_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 19;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(155, 368);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Coiny", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLogin.Location = new System.Drawing.Point(209, 188);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(112, 35);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppDatLichKham.Properties.Resources.Ảnh_hành_tinh_plus;
            this.pictureBox1.Location = new System.Drawing.Point(537, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JT APP";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtTai_khoan;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtMat_khau;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnsign;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.CheckBox ckbHienthimatkhau;
    }
}