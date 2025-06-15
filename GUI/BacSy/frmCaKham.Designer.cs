namespace AppDatLichKham.GUI.BacSy
{
    partial class frmCaKham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbcTrangthaiden = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonThuoc = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtGhiChu = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.dtpGioDen = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.pnlThongtin = new System.Windows.Forms.Panel();
            this.txtGioHen = new System.Windows.Forms.TextBox();
            this.txtLichhenid = new System.Windows.Forms.TextBox();
            this.pnlTrong = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.txtTenBacSi = new System.Windows.Forms.TextBox();
            this.txtbenhnhanid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlThongtin.SuspendLayout();
            this.pnlTrong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.pnlTrong);
            this.panel1.Controls.Add(this.txtLichhenid);
            this.panel1.Controls.Add(this.txtTenBacSi);
            this.panel1.Controls.Add(this.txtbenhnhanid);
            this.panel1.Controls.Add(this.txtTenBenhNhan);
            this.panel1.Controls.Add(this.txtGioHen);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.pnlThongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1577, 887);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeight = 44;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(770, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(807, 887);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneButton2.BorderRadius = 20;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(256, 630);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(166, 45);
            this.siticoneButton2.TabIndex = 10;
            this.siticoneButton2.Text = "Cập nhật";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // cbcTrangthaiden
            // 
            this.cbcTrangthaiden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbcTrangthaiden.BackColor = System.Drawing.Color.Transparent;
            this.cbcTrangthaiden.BorderRadius = 20;
            this.cbcTrangthaiden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbcTrangthaiden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcTrangthaiden.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbcTrangthaiden.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbcTrangthaiden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbcTrangthaiden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbcTrangthaiden.ItemHeight = 30;
            this.cbcTrangthaiden.Items.AddRange(new object[] {
            "Đến sớm",
            "Đến đúng giờ",
            "Đến muộn"});
            this.cbcTrangthaiden.Location = new System.Drawing.Point(247, 231);
            this.cbcTrangthaiden.Name = "cbcTrangthaiden";
            this.cbcTrangthaiden.Size = new System.Drawing.Size(266, 36);
            this.cbcTrangthaiden.TabIndex = 8;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneButton1.BorderRadius = 19;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.LightCoral;
            this.siticoneButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(528, 146);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(57, 45);
            this.siticoneButton1.TabIndex = 7;
            this.siticoneButton1.Text = "Now";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(58, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn thuốc :";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(58, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ghi chú:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(58, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trạng thái đến :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Coiny", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(136, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thông Tin Ca Khám";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(58, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thời gian đến :";
            // 
            // txtDonThuoc
            // 
            this.txtDonThuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDonThuoc.BorderRadius = 20;
            this.txtDonThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonThuoc.DefaultText = "";
            this.txtDonThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonThuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonThuoc.ForeColor = System.Drawing.Color.Black;
            this.txtDonThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonThuoc.Location = new System.Drawing.Point(243, 470);
            this.txtDonThuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonThuoc.Multiline = true;
            this.txtDonThuoc.Name = "txtDonThuoc";
            this.txtDonThuoc.PasswordChar = '\0';
            this.txtDonThuoc.PlaceholderText = "";
            this.txtDonThuoc.SelectedText = "";
            this.txtDonThuoc.Size = new System.Drawing.Size(342, 140);
            this.txtDonThuoc.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGhiChu.BorderRadius = 20;
            this.txtGhiChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhiChu.DefaultText = "";
            this.txtGhiChu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGhiChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGhiChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGhiChu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGhiChu.Location = new System.Drawing.Point(243, 295);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.PasswordChar = '\0';
            this.txtGhiChu.PlaceholderText = "";
            this.txtGhiChu.SelectedText = "";
            this.txtGhiChu.Size = new System.Drawing.Size(342, 140);
            this.txtGhiChu.TabIndex = 2;
            // 
            // dtpGioDen
            // 
            this.dtpGioDen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGioDen.BackColor = System.Drawing.Color.LightCyan;
            this.dtpGioDen.BorderRadius = 20;
            this.dtpGioDen.CausesValidation = false;
            this.dtpGioDen.Checked = true;
            this.dtpGioDen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpGioDen.FillColor = System.Drawing.Color.LightBlue;
            this.dtpGioDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpGioDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioDen.Location = new System.Drawing.Point(247, 146);
            this.dtpGioDen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpGioDen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpGioDen.Name = "dtpGioDen";
            this.dtpGioDen.ShowUpDown = true;
            this.dtpGioDen.Size = new System.Drawing.Size(266, 47);
            this.dtpGioDen.TabIndex = 0;
            this.dtpGioDen.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dtpGioDen.Value = new System.DateTime(2025, 6, 12, 14, 50, 0, 0);
            this.dtpGioDen.ValueChanged += new System.EventHandler(this.siticoneDateTimePicker1_ValueChanged);
            // 
            // pnlThongtin
            // 
            this.pnlThongtin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlThongtin.Controls.Add(this.label5);
            this.pnlThongtin.Controls.Add(this.siticoneButton2);
            this.pnlThongtin.Controls.Add(this.dtpGioDen);
            this.pnlThongtin.Controls.Add(this.cbcTrangthaiden);
            this.pnlThongtin.Controls.Add(this.txtGhiChu);
            this.pnlThongtin.Controls.Add(this.siticoneButton1);
            this.pnlThongtin.Controls.Add(this.txtDonThuoc);
            this.pnlThongtin.Controls.Add(this.label4);
            this.pnlThongtin.Controls.Add(this.label1);
            this.pnlThongtin.Controls.Add(this.label3);
            this.pnlThongtin.Controls.Add(this.label2);
            this.pnlThongtin.Location = new System.Drawing.Point(78, 135);
            this.pnlThongtin.Name = "pnlThongtin";
            this.pnlThongtin.Size = new System.Drawing.Size(616, 701);
            this.pnlThongtin.TabIndex = 12;
            this.pnlThongtin.Visible = false;
            // 
            // txtGioHen
            // 
            this.txtGioHen.Location = new System.Drawing.Point(584, 29);
            this.txtGioHen.Name = "txtGioHen";
            this.txtGioHen.Size = new System.Drawing.Size(100, 20);
            this.txtGioHen.TabIndex = 13;
            this.txtGioHen.Visible = false;
            this.txtGioHen.TextChanged += new System.EventHandler(this.txtGioHen_TextChanged);
            // 
            // txtLichhenid
            // 
            this.txtLichhenid.Location = new System.Drawing.Point(627, 67);
            this.txtLichhenid.Name = "txtLichhenid";
            this.txtLichhenid.Size = new System.Drawing.Size(100, 20);
            this.txtLichhenid.TabIndex = 13;
            this.txtLichhenid.Visible = false;
            // 
            // pnlTrong
            // 
            this.pnlTrong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTrong.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlTrong.Controls.Add(this.label7);
            this.pnlTrong.Controls.Add(this.label6);
            this.pnlTrong.Location = new System.Drawing.Point(0, 0);
            this.pnlTrong.Name = "pnlTrong";
            this.pnlTrong.Size = new System.Drawing.Size(1577, 887);
            this.pnlTrong.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Coiny", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(408, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(760, 64);
            this.label6.TabIndex = 0;
            this.label6.Text = " hẹn vào ngày hôm nay";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Coiny", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(544, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(461, 64);
            this.label7.TabIndex = 0;
            this.label7.Text = "Không có lịch";
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Location = new System.Drawing.Point(491, 67);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(100, 20);
            this.txtTenBenhNhan.TabIndex = 13;
            this.txtTenBenhNhan.Visible = false;
            this.txtTenBenhNhan.TextChanged += new System.EventHandler(this.txtGioHen_TextChanged);
            // 
            // txtTenBacSi
            // 
            this.txtTenBacSi.Location = new System.Drawing.Point(381, 29);
            this.txtTenBacSi.Name = "txtTenBacSi";
            this.txtTenBacSi.Size = new System.Drawing.Size(100, 20);
            this.txtTenBacSi.TabIndex = 13;
            this.txtTenBacSi.Visible = false;
            this.txtTenBacSi.TextChanged += new System.EventHandler(this.txtGioHen_TextChanged);
            // 
            // txtbenhnhanid
            // 
            this.txtbenhnhanid.Location = new System.Drawing.Point(345, 67);
            this.txtbenhnhanid.Name = "txtbenhnhanid";
            this.txtbenhnhanid.Size = new System.Drawing.Size(100, 20);
            this.txtbenhnhanid.TabIndex = 13;
            this.txtbenhnhanid.Visible = false;
            this.txtbenhnhanid.TextChanged += new System.EventHandler(this.txtGioHen_TextChanged);
            // 
            // frmCaKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1577, 887);
            this.Controls.Add(this.panel1);
            this.Name = "frmCaKham";
            this.Text = "frmCaKham";
            this.Load += new System.EventHandler(this.frmCaKham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlThongtin.ResumeLayout(false);
            this.pnlThongtin.PerformLayout();
            this.pnlTrong.ResumeLayout(false);
            this.pnlTrong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDonThuoc;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbcTrangthaiden;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpGioDen;
        private System.Windows.Forms.Panel pnlThongtin;
        private System.Windows.Forms.TextBox txtGioHen;
        private System.Windows.Forms.TextBox txtLichhenid;
        private System.Windows.Forms.Panel pnlTrong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenBacSi;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.TextBox txtbenhnhanid;
    }
}