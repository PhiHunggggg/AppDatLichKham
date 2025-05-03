namespace AppDatLichKham.GUI.BacSy
{
    partial class frmXemLichDat
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemLichDat));
            this.chuyenKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyLichKhamDataSet = new AppDatLichKham.QuanLyLichKhamDataSet();
            this.chuyenKhoaTableAdapter = new AppDatLichKham.QuanLyLichKhamDataSetTableAdapters.ChuyenKhoaTableAdapter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDatLichid = new System.Windows.Forms.TextBox();
            this.txtGiohen = new System.Windows.Forms.TextBox();
            this.txtNgayhen = new System.Windows.Forms.TextBox();
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btn17h = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn7h = new System.Windows.Forms.Button();
            this.btn7h15 = new System.Windows.Forms.Button();
            this.btn11h = new System.Windows.Forms.Button();
            this.btn7h30 = new System.Windows.Forms.Button();
            this.btn10h45 = new System.Windows.Forms.Button();
            this.btn7h45 = new System.Windows.Forms.Button();
            this.btn10h30 = new System.Windows.Forms.Button();
            this.btn8h = new System.Windows.Forms.Button();
            this.btn10h15 = new System.Windows.Forms.Button();
            this.btn8h15 = new System.Windows.Forms.Button();
            this.btn8h30 = new System.Windows.Forms.Button();
            this.btn8h45 = new System.Windows.Forms.Button();
            this.btn16h45 = new System.Windows.Forms.Button();
            this.btn9h = new System.Windows.Forms.Button();
            this.btn16h30 = new System.Windows.Forms.Button();
            this.btn9h15 = new System.Windows.Forms.Button();
            this.btn16h15 = new System.Windows.Forms.Button();
            this.btn9h30 = new System.Windows.Forms.Button();
            this.btn16h = new System.Windows.Forms.Button();
            this.btn9h45 = new System.Windows.Forms.Button();
            this.btn15h45 = new System.Windows.Forms.Button();
            this.btn10h = new System.Windows.Forms.Button();
            this.btn15h30 = new System.Windows.Forms.Button();
            this.btn14h = new System.Windows.Forms.Button();
            this.btn15h15 = new System.Windows.Forms.Button();
            this.btn14h15 = new System.Windows.Forms.Button();
            this.btn15h = new System.Windows.Forms.Button();
            this.btn14h30 = new System.Windows.Forms.Button();
            this.btn14h45 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblKhancap = new System.Windows.Forms.Label();
            this.lblGhichu = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.btnDangKi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaycheck = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.siticoneCircleButton2 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenKhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBtn.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chuyenKhoaBindingSource
            // 
            this.chuyenKhoaBindingSource.DataMember = "ChuyenKhoa";
            this.chuyenKhoaBindingSource.DataSource = this.quanLyLichKhamDataSet;
            // 
            // quanLyLichKhamDataSet
            // 
            this.quanLyLichKhamDataSet.DataSetName = "QuanLyLichKhamDataSet";
            this.quanLyLichKhamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chuyenKhoaTableAdapter
            // 
            this.chuyenKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QuanLyLichKhamConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = "SELECT * FROM ChuyenKhoa";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.siticoneCircleButton2);
            this.panel1.Controls.Add(this.siticoneCircleButton1);
            this.panel1.Controls.Add(this.txtDatLichid);
            this.panel1.Controls.Add(this.txtGiohen);
            this.panel1.Controls.Add(this.txtNgayhen);
            this.panel1.Controls.Add(this.pnlBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpNgaycheck);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1762, 1017);
            this.panel1.TabIndex = 0;
            // 
            // txtDatLichid
            // 
            this.txtDatLichid.Location = new System.Drawing.Point(1635, 170);
            this.txtDatLichid.Name = "txtDatLichid";
            this.txtDatLichid.Size = new System.Drawing.Size(100, 20);
            this.txtDatLichid.TabIndex = 70;
            this.txtDatLichid.Visible = false;
            // 
            // txtGiohen
            // 
            this.txtGiohen.Location = new System.Drawing.Point(1635, 144);
            this.txtGiohen.Name = "txtGiohen";
            this.txtGiohen.Size = new System.Drawing.Size(100, 20);
            this.txtGiohen.TabIndex = 69;
            this.txtGiohen.Visible = false;
            // 
            // txtNgayhen
            // 
            this.txtNgayhen.Location = new System.Drawing.Point(1635, 118);
            this.txtNgayhen.Name = "txtNgayhen";
            this.txtNgayhen.Size = new System.Drawing.Size(100, 20);
            this.txtNgayhen.TabIndex = 68;
            this.txtNgayhen.Visible = false;
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.btn17h);
            this.pnlBtn.Controls.Add(this.label10);
            this.pnlBtn.Controls.Add(this.label11);
            this.pnlBtn.Controls.Add(this.btn7h);
            this.pnlBtn.Controls.Add(this.btn7h15);
            this.pnlBtn.Controls.Add(this.btn11h);
            this.pnlBtn.Controls.Add(this.btn7h30);
            this.pnlBtn.Controls.Add(this.btn10h45);
            this.pnlBtn.Controls.Add(this.btn7h45);
            this.pnlBtn.Controls.Add(this.btn10h30);
            this.pnlBtn.Controls.Add(this.btn8h);
            this.pnlBtn.Controls.Add(this.btn10h15);
            this.pnlBtn.Controls.Add(this.btn8h15);
            this.pnlBtn.Controls.Add(this.btn8h30);
            this.pnlBtn.Controls.Add(this.btn8h45);
            this.pnlBtn.Controls.Add(this.btn16h45);
            this.pnlBtn.Controls.Add(this.btn9h);
            this.pnlBtn.Controls.Add(this.btn16h30);
            this.pnlBtn.Controls.Add(this.btn9h15);
            this.pnlBtn.Controls.Add(this.btn16h15);
            this.pnlBtn.Controls.Add(this.btn9h30);
            this.pnlBtn.Controls.Add(this.btn16h);
            this.pnlBtn.Controls.Add(this.btn9h45);
            this.pnlBtn.Controls.Add(this.btn15h45);
            this.pnlBtn.Controls.Add(this.btn10h);
            this.pnlBtn.Controls.Add(this.btn15h30);
            this.pnlBtn.Controls.Add(this.btn14h);
            this.pnlBtn.Controls.Add(this.btn15h15);
            this.pnlBtn.Controls.Add(this.btn14h15);
            this.pnlBtn.Controls.Add(this.btn15h);
            this.pnlBtn.Controls.Add(this.btn14h30);
            this.pnlBtn.Controls.Add(this.btn14h45);
            this.pnlBtn.Location = new System.Drawing.Point(855, 118);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(710, 319);
            this.pnlBtn.TabIndex = 67;
            // 
            // btn17h
            // 
            this.btn17h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn17h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn17h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn17h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn17h.FlatAppearance.BorderSize = 0;
            this.btn17h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn17h.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn17h.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn17h.Location = new System.Drawing.Point(494, 268);
            this.btn17h.Margin = new System.Windows.Forms.Padding(0);
            this.btn17h.Name = "btn17h";
            this.btn17h.Size = new System.Drawing.Size(74, 33);
            this.btn17h.TabIndex = 40;
            this.btn17h.Text = "17:00";
            this.btn17h.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(223)))), ((int)(((byte)(163)))));
            this.label10.Location = new System.Drawing.Point(5, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(664, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ca sáng                                                                          " +
    "                      ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(223)))), ((int)(((byte)(163)))));
            this.label11.Location = new System.Drawing.Point(5, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(669, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ca chiều                                                                         " +
    "                       ";
            // 
            // btn7h
            // 
            this.btn7h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn7h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn7h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7h.FlatAppearance.BorderSize = 0;
            this.btn7h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7h.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7h.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7h.Location = new System.Drawing.Point(9, 42);
            this.btn7h.Margin = new System.Windows.Forms.Padding(0);
            this.btn7h.Name = "btn7h";
            this.btn7h.Size = new System.Drawing.Size(74, 33);
            this.btn7h.TabIndex = 11;
            this.btn7h.Text = "07:00";
            this.btn7h.UseVisualStyleBackColor = false;
            // 
            // btn7h15
            // 
            this.btn7h15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7h15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn7h15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn7h15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7h15.FlatAppearance.BorderSize = 0;
            this.btn7h15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7h15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7h15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7h15.Location = new System.Drawing.Point(104, 42);
            this.btn7h15.Margin = new System.Windows.Forms.Padding(0);
            this.btn7h15.Name = "btn7h15";
            this.btn7h15.Size = new System.Drawing.Size(74, 33);
            this.btn7h15.TabIndex = 12;
            this.btn7h15.Text = "07:15";
            this.btn7h15.UseVisualStyleBackColor = false;
            // 
            // btn11h
            // 
            this.btn11h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn11h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn11h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn11h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn11h.FlatAppearance.BorderSize = 0;
            this.btn11h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn11h.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11h.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn11h.Location = new System.Drawing.Point(203, 139);
            this.btn11h.Margin = new System.Windows.Forms.Padding(0);
            this.btn11h.Name = "btn11h";
            this.btn11h.Size = new System.Drawing.Size(74, 33);
            this.btn11h.TabIndex = 39;
            this.btn11h.Text = "11:00";
            this.btn11h.UseVisualStyleBackColor = false;
            // 
            // btn7h30
            // 
            this.btn7h30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7h30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn7h30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn7h30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7h30.FlatAppearance.BorderSize = 0;
            this.btn7h30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7h30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7h30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7h30.Location = new System.Drawing.Point(203, 42);
            this.btn7h30.Margin = new System.Windows.Forms.Padding(0);
            this.btn7h30.Name = "btn7h30";
            this.btn7h30.Size = new System.Drawing.Size(74, 33);
            this.btn7h30.TabIndex = 13;
            this.btn7h30.Text = "07:30";
            this.btn7h30.UseVisualStyleBackColor = false;
            // 
            // btn10h45
            // 
            this.btn10h45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn10h45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn10h45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn10h45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10h45.FlatAppearance.BorderSize = 0;
            this.btn10h45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10h45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10h45.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn10h45.Location = new System.Drawing.Point(108, 139);
            this.btn10h45.Margin = new System.Windows.Forms.Padding(0);
            this.btn10h45.Name = "btn10h45";
            this.btn10h45.Size = new System.Drawing.Size(74, 33);
            this.btn10h45.TabIndex = 38;
            this.btn10h45.Text = "10:45";
            this.btn10h45.UseVisualStyleBackColor = false;
            // 
            // btn7h45
            // 
            this.btn7h45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7h45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn7h45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn7h45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7h45.FlatAppearance.BorderSize = 0;
            this.btn7h45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7h45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7h45.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7h45.Location = new System.Drawing.Point(300, 42);
            this.btn7h45.Margin = new System.Windows.Forms.Padding(0);
            this.btn7h45.Name = "btn7h45";
            this.btn7h45.Size = new System.Drawing.Size(74, 33);
            this.btn7h45.TabIndex = 14;
            this.btn7h45.Text = "07:45";
            this.btn7h45.UseVisualStyleBackColor = false;
            // 
            // btn10h30
            // 
            this.btn10h30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn10h30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn10h30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn10h30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10h30.FlatAppearance.BorderSize = 0;
            this.btn10h30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10h30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10h30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn10h30.Location = new System.Drawing.Point(10, 139);
            this.btn10h30.Margin = new System.Windows.Forms.Padding(0);
            this.btn10h30.Name = "btn10h30";
            this.btn10h30.Size = new System.Drawing.Size(74, 33);
            this.btn10h30.TabIndex = 37;
            this.btn10h30.Text = "10:30";
            this.btn10h30.UseVisualStyleBackColor = false;
            // 
            // btn8h
            // 
            this.btn8h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn8h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn8h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8h.FlatAppearance.BorderSize = 0;
            this.btn8h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8h.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8h.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8h.Location = new System.Drawing.Point(397, 42);
            this.btn8h.Margin = new System.Windows.Forms.Padding(0);
            this.btn8h.Name = "btn8h";
            this.btn8h.Size = new System.Drawing.Size(74, 33);
            this.btn8h.TabIndex = 15;
            this.btn8h.Text = "08:00";
            this.btn8h.UseVisualStyleBackColor = false;
            // 
            // btn10h15
            // 
            this.btn10h15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn10h15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn10h15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn10h15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10h15.FlatAppearance.BorderSize = 0;
            this.btn10h15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10h15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10h15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn10h15.Location = new System.Drawing.Point(591, 90);
            this.btn10h15.Margin = new System.Windows.Forms.Padding(0);
            this.btn10h15.Name = "btn10h15";
            this.btn10h15.Size = new System.Drawing.Size(74, 33);
            this.btn10h15.TabIndex = 36;
            this.btn10h15.Text = "10:15";
            this.btn10h15.UseVisualStyleBackColor = false;
            // 
            // btn8h15
            // 
            this.btn8h15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8h15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn8h15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn8h15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8h15.FlatAppearance.BorderSize = 0;
            this.btn8h15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8h15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8h15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8h15.Location = new System.Drawing.Point(494, 42);
            this.btn8h15.Margin = new System.Windows.Forms.Padding(0);
            this.btn8h15.Name = "btn8h15";
            this.btn8h15.Size = new System.Drawing.Size(74, 33);
            this.btn8h15.TabIndex = 16;
            this.btn8h15.Text = "08:15";
            this.btn8h15.UseVisualStyleBackColor = false;
            // 
            // btn8h30
            // 
            this.btn8h30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8h30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn8h30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn8h30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8h30.FlatAppearance.BorderSize = 0;
            this.btn8h30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8h30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8h30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8h30.Location = new System.Drawing.Point(591, 42);
            this.btn8h30.Margin = new System.Windows.Forms.Padding(0);
            this.btn8h30.Name = "btn8h30";
            this.btn8h30.Size = new System.Drawing.Size(74, 33);
            this.btn8h30.TabIndex = 35;
            this.btn8h30.Text = "08:30";
            this.btn8h30.UseVisualStyleBackColor = false;
            // 
            // btn8h45
            // 
            this.btn8h45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8h45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn8h45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn8h45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8h45.FlatAppearance.BorderSize = 0;
            this.btn8h45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8h45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8h45.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8h45.Location = new System.Drawing.Point(9, 90);
            this.btn8h45.Margin = new System.Windows.Forms.Padding(0);
            this.btn8h45.Name = "btn8h45";
            this.btn8h45.Size = new System.Drawing.Size(74, 33);
            this.btn8h45.TabIndex = 17;
            this.btn8h45.Text = "08:45";
            this.btn8h45.UseVisualStyleBackColor = false;
            // 
            // btn16h45
            // 
            this.btn16h45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn16h45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn16h45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn16h45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn16h45.FlatAppearance.BorderSize = 0;
            this.btn16h45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn16h45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn16h45.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn16h45.Location = new System.Drawing.Point(397, 268);
            this.btn16h45.Margin = new System.Windows.Forms.Padding(0);
            this.btn16h45.Name = "btn16h45";
            this.btn16h45.Size = new System.Drawing.Size(74, 33);
            this.btn16h45.TabIndex = 34;
            this.btn16h45.Text = "16:45";
            this.btn16h45.UseVisualStyleBackColor = false;
            // 
            // btn9h
            // 
            this.btn9h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn9h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn9h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9h.FlatAppearance.BorderSize = 0;
            this.btn9h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9h.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9h.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9h.Location = new System.Drawing.Point(108, 90);
            this.btn9h.Margin = new System.Windows.Forms.Padding(0);
            this.btn9h.Name = "btn9h";
            this.btn9h.Size = new System.Drawing.Size(74, 33);
            this.btn9h.TabIndex = 18;
            this.btn9h.Text = "09:00";
            this.btn9h.UseVisualStyleBackColor = false;
            // 
            // btn16h30
            // 
            this.btn16h30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn16h30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn16h30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn16h30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn16h30.FlatAppearance.BorderSize = 0;
            this.btn16h30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn16h30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn16h30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn16h30.Location = new System.Drawing.Point(300, 268);
            this.btn16h30.Margin = new System.Windows.Forms.Padding(0);
            this.btn16h30.Name = "btn16h30";
            this.btn16h30.Size = new System.Drawing.Size(74, 33);
            this.btn16h30.TabIndex = 33;
            this.btn16h30.Text = "16:30";
            this.btn16h30.UseVisualStyleBackColor = false;
            // 
            // btn9h15
            // 
            this.btn9h15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9h15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn9h15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn9h15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9h15.FlatAppearance.BorderSize = 0;
            this.btn9h15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9h15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9h15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9h15.Location = new System.Drawing.Point(203, 90);
            this.btn9h15.Margin = new System.Windows.Forms.Padding(0);
            this.btn9h15.Name = "btn9h15";
            this.btn9h15.Size = new System.Drawing.Size(74, 33);
            this.btn9h15.TabIndex = 19;
            this.btn9h15.Text = "09:15";
            this.btn9h15.UseVisualStyleBackColor = false;
            // 
            // btn16h15
            // 
            this.btn16h15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn16h15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn16h15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn16h15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn16h15.FlatAppearance.BorderSize = 0;
            this.btn16h15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn16h15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn16h15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn16h15.Location = new System.Drawing.Point(203, 268);
            this.btn16h15.Margin = new System.Windows.Forms.Padding(0);
            this.btn16h15.Name = "btn16h15";
            this.btn16h15.Size = new System.Drawing.Size(74, 33);
            this.btn16h15.TabIndex = 32;
            this.btn16h15.Text = "16:15";
            this.btn16h15.UseVisualStyleBackColor = false;
            // 
            // btn9h30
            // 
            this.btn9h30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9h30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn9h30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn9h30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9h30.FlatAppearance.BorderSize = 0;
            this.btn9h30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9h30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9h30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9h30.Location = new System.Drawing.Point(300, 90);
            this.btn9h30.Margin = new System.Windows.Forms.Padding(0);
            this.btn9h30.Name = "btn9h30";
            this.btn9h30.Size = new System.Drawing.Size(74, 33);
            this.btn9h30.TabIndex = 20;
            this.btn9h30.Text = "09:30";
            this.btn9h30.UseVisualStyleBackColor = false;
            // 
            // btn16h
            // 
            this.btn16h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn16h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn16h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn16h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn16h.FlatAppearance.BorderSize = 0;
            this.btn16h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn16h.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn16h.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn16h.Location = new System.Drawing.Point(104, 268);
            this.btn16h.Margin = new System.Windows.Forms.Padding(0);
            this.btn16h.Name = "btn16h";
            this.btn16h.Size = new System.Drawing.Size(74, 33);
            this.btn16h.TabIndex = 31;
            this.btn16h.Text = "16:00";
            this.btn16h.UseVisualStyleBackColor = false;
            // 
            // btn9h45
            // 
            this.btn9h45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9h45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn9h45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn9h45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9h45.FlatAppearance.BorderSize = 0;
            this.btn9h45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9h45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9h45.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9h45.Location = new System.Drawing.Point(397, 90);
            this.btn9h45.Margin = new System.Windows.Forms.Padding(0);
            this.btn9h45.Name = "btn9h45";
            this.btn9h45.Size = new System.Drawing.Size(74, 33);
            this.btn9h45.TabIndex = 21;
            this.btn9h45.Text = "09:45";
            this.btn9h45.UseVisualStyleBackColor = false;
            // 
            // btn15h45
            // 
            this.btn15h45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn15h45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn15h45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn15h45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn15h45.FlatAppearance.BorderSize = 0;
            this.btn15h45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn15h45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15h45.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn15h45.Location = new System.Drawing.Point(10, 268);
            this.btn15h45.Margin = new System.Windows.Forms.Padding(0);
            this.btn15h45.Name = "btn15h45";
            this.btn15h45.Size = new System.Drawing.Size(74, 33);
            this.btn15h45.TabIndex = 30;
            this.btn15h45.Text = "15:45";
            this.btn15h45.UseVisualStyleBackColor = false;
            // 
            // btn10h
            // 
            this.btn10h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn10h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn10h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn10h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn10h.FlatAppearance.BorderSize = 0;
            this.btn10h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn10h.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10h.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn10h.Location = new System.Drawing.Point(494, 90);
            this.btn10h.Margin = new System.Windows.Forms.Padding(0);
            this.btn10h.Name = "btn10h";
            this.btn10h.Size = new System.Drawing.Size(74, 33);
            this.btn10h.TabIndex = 22;
            this.btn10h.Text = "10:00";
            this.btn10h.UseVisualStyleBackColor = false;
            // 
            // btn15h30
            // 
            this.btn15h30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn15h30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn15h30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn15h30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn15h30.FlatAppearance.BorderSize = 0;
            this.btn15h30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn15h30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15h30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn15h30.Location = new System.Drawing.Point(591, 221);
            this.btn15h30.Margin = new System.Windows.Forms.Padding(0);
            this.btn15h30.Name = "btn15h30";
            this.btn15h30.Size = new System.Drawing.Size(74, 33);
            this.btn15h30.TabIndex = 29;
            this.btn15h30.Text = "15:30";
            this.btn15h30.UseVisualStyleBackColor = false;
            // 
            // btn14h
            // 
            this.btn14h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn14h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn14h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn14h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn14h.FlatAppearance.BorderSize = 0;
            this.btn14h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn14h.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14h.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn14h.Location = new System.Drawing.Point(9, 221);
            this.btn14h.Margin = new System.Windows.Forms.Padding(0);
            this.btn14h.Name = "btn14h";
            this.btn14h.Size = new System.Drawing.Size(74, 33);
            this.btn14h.TabIndex = 23;
            this.btn14h.Text = "14:00";
            this.btn14h.UseVisualStyleBackColor = false;
            // 
            // btn15h15
            // 
            this.btn15h15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn15h15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn15h15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn15h15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn15h15.FlatAppearance.BorderSize = 0;
            this.btn15h15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn15h15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15h15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn15h15.Location = new System.Drawing.Point(494, 221);
            this.btn15h15.Margin = new System.Windows.Forms.Padding(0);
            this.btn15h15.Name = "btn15h15";
            this.btn15h15.Size = new System.Drawing.Size(74, 33);
            this.btn15h15.TabIndex = 28;
            this.btn15h15.Text = "15:15";
            this.btn15h15.UseVisualStyleBackColor = false;
            // 
            // btn14h15
            // 
            this.btn14h15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn14h15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn14h15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn14h15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn14h15.FlatAppearance.BorderSize = 0;
            this.btn14h15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn14h15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14h15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn14h15.Location = new System.Drawing.Point(104, 221);
            this.btn14h15.Margin = new System.Windows.Forms.Padding(0);
            this.btn14h15.Name = "btn14h15";
            this.btn14h15.Size = new System.Drawing.Size(74, 33);
            this.btn14h15.TabIndex = 24;
            this.btn14h15.Text = "14:15";
            this.btn14h15.UseVisualStyleBackColor = false;
            // 
            // btn15h
            // 
            this.btn15h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn15h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn15h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn15h.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn15h.FlatAppearance.BorderSize = 0;
            this.btn15h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn15h.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15h.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn15h.Location = new System.Drawing.Point(397, 221);
            this.btn15h.Margin = new System.Windows.Forms.Padding(0);
            this.btn15h.Name = "btn15h";
            this.btn15h.Size = new System.Drawing.Size(74, 33);
            this.btn15h.TabIndex = 27;
            this.btn15h.Text = "15:00";
            this.btn15h.UseVisualStyleBackColor = false;
            // 
            // btn14h30
            // 
            this.btn14h30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn14h30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn14h30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn14h30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn14h30.FlatAppearance.BorderSize = 0;
            this.btn14h30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn14h30.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14h30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn14h30.Location = new System.Drawing.Point(203, 221);
            this.btn14h30.Margin = new System.Windows.Forms.Padding(0);
            this.btn14h30.Name = "btn14h30";
            this.btn14h30.Size = new System.Drawing.Size(74, 33);
            this.btn14h30.TabIndex = 25;
            this.btn14h30.Text = "14:30";
            this.btn14h30.UseVisualStyleBackColor = false;
            // 
            // btn14h45
            // 
            this.btn14h45.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn14h45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.btn14h45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn14h45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn14h45.FlatAppearance.BorderSize = 0;
            this.btn14h45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn14h45.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14h45.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn14h45.Location = new System.Drawing.Point(300, 221);
            this.btn14h45.Margin = new System.Windows.Forms.Padding(0);
            this.btn14h45.Name = "btn14h45";
            this.btn14h45.Size = new System.Drawing.Size(74, 33);
            this.btn14h45.TabIndex = 26;
            this.btn14h45.Text = "14:45";
            this.btn14h45.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flyoutPanel1);
            this.panel2.Location = new System.Drawing.Point(1009, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 501);
            this.panel2.TabIndex = 66;
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(97, 3);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.flyoutPanel1.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.flyoutPanel1.OwnerControl = this.panel2;
            this.flyoutPanel1.Size = new System.Drawing.Size(705, 516);
            this.flyoutPanel1.TabIndex = 71;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.flyoutPanelControl1.Appearance.Options.UseBackColor = true;
            this.flyoutPanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.flyoutPanelControl1.Controls.Add(this.label5);
            this.flyoutPanelControl1.Controls.Add(this.siticoneButton1);
            this.flyoutPanelControl1.Controls.Add(this.lblKhancap);
            this.flyoutPanelControl1.Controls.Add(this.lblGhichu);
            this.flyoutPanelControl1.Controls.Add(this.lblSdt);
            this.flyoutPanelControl1.Controls.Add(this.label6);
            this.flyoutPanelControl1.Controls.Add(this.label9);
            this.flyoutPanelControl1.Controls.Add(this.lblHoTen);
            this.flyoutPanelControl1.Controls.Add(this.btnDangKi);
            this.flyoutPanelControl1.Controls.Add(this.lblDiachi);
            this.flyoutPanelControl1.Controls.Add(this.txtGhichu);
            this.flyoutPanelControl1.Controls.Add(this.lblGioiTinh);
            this.flyoutPanelControl1.Controls.Add(this.label7);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(-69, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(774, 516);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(146, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Họ tên :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneButton1.BorderRadius = 19;
            this.siticoneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(102)))), ((int)(((byte)(49)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(194, 414);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(133, 46);
            this.siticoneButton1.TabIndex = 61;
            this.siticoneButton1.Text = "Chấp nhận";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // lblKhancap
            // 
            this.lblKhancap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKhancap.AutoSize = true;
            this.lblKhancap.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhancap.ForeColor = System.Drawing.Color.Red;
            this.lblKhancap.Location = new System.Drawing.Point(301, 73);
            this.lblKhancap.Name = "lblKhancap";
            this.lblKhancap.Size = new System.Drawing.Size(126, 32);
            this.lblKhancap.TabIndex = 52;
            this.lblKhancap.Text = "Cấp cứu";
            this.lblKhancap.Visible = false;
            this.lblKhancap.Click += new System.EventHandler(this.lblKhancap_Click);
            // 
            // lblGhichu
            // 
            this.lblGhichu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGhichu.AutoSize = true;
            this.lblGhichu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhichu.ForeColor = System.Drawing.Color.MintCream;
            this.lblGhichu.Location = new System.Drawing.Point(146, 267);
            this.lblGhichu.Name = "lblGhichu";
            this.lblGhichu.Size = new System.Drawing.Size(71, 18);
            this.lblGhichu.TabIndex = 58;
            this.lblGhichu.Text = "Ghi chú :";
            this.lblGhichu.Click += new System.EventHandler(this.lblGhichu_Click);
            // 
            // lblSdt
            // 
            this.lblSdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.ForeColor = System.Drawing.Color.MintCream;
            this.lblSdt.Location = new System.Drawing.Point(499, 130);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(50, 18);
            this.lblSdt.TabIndex = 50;
            this.lblSdt.Text = "label7";
            this.lblSdt.Click += new System.EventHandler(this.lblSdt_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MintCream;
            this.label6.Location = new System.Drawing.Point(146, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Giới tính :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MintCream;
            this.label9.Location = new System.Drawing.Point(384, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 65;
            this.label9.Text = "Địa chỉ :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.MintCream;
            this.lblHoTen.Location = new System.Drawing.Point(215, 130);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(50, 18);
            this.lblHoTen.TabIndex = 48;
            this.lblHoTen.Text = "label5";
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDangKi.BorderRadius = 19;
            this.btnDangKi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(102)))), ((int)(((byte)(49)))));
            this.btnDangKi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangKi.ForeColor = System.Drawing.Color.White;
            this.btnDangKi.Location = new System.Drawing.Point(435, 414);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(133, 46);
            this.btnDangKi.TabIndex = 60;
            this.btnDangKi.Text = "Xóa";
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // lblDiachi
            // 
            this.lblDiachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.ForeColor = System.Drawing.Color.MintCream;
            this.lblDiachi.Location = new System.Drawing.Point(478, 200);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(50, 18);
            this.lblDiachi.TabIndex = 51;
            this.lblDiachi.Text = "label8";
            this.lblDiachi.Click += new System.EventHandler(this.lblDiachi_Click);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGhichu.Location = new System.Drawing.Point(233, 267);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.ReadOnly = true;
            this.txtGhichu.Size = new System.Drawing.Size(365, 109);
            this.txtGhichu.TabIndex = 59;
            this.txtGhichu.TextChanged += new System.EventHandler(this.txtGhichu_TextChanged);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.MintCream;
            this.lblGioiTinh.Location = new System.Drawing.Point(230, 200);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(50, 18);
            this.lblGioiTinh.TabIndex = 49;
            this.lblGioiTinh.Text = "label6";
            this.lblGioiTinh.Click += new System.EventHandler(this.lblGioiTinh_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MintCream;
            this.label7.Location = new System.Drawing.Point(384, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Số điện thoại :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(1536, 63);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(16, 24);
            this.lblCount.TabIndex = 65;
            this.lblCount.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1284, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 24);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tổng số lịch được đặt :";
            // 
            // dtpNgaycheck
            // 
            this.dtpNgaycheck.BorderRadius = 20;
            this.dtpNgaycheck.Checked = true;
            this.dtpNgaycheck.CustomFormat = "dddd, dd/MM/yyyy";
            this.dtpNgaycheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.dtpNgaycheck.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaycheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpNgaycheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaycheck.Location = new System.Drawing.Point(910, 51);
            this.dtpNgaycheck.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaycheck.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaycheck.Name = "dtpNgaycheck";
            this.dtpNgaycheck.ShowUpDown = true;
            this.dtpNgaycheck.Size = new System.Drawing.Size(298, 51);
            this.dtpNgaycheck.TabIndex = 63;
            this.dtpNgaycheck.Value = new System.DateTime(2025, 4, 13, 10, 34, 38, 233);
            this.dtpNgaycheck.ValueChanged += new System.EventHandler(this.dtpNgaycheck_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(865, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Vui lòng chọn ngày cần xem lịch";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(223)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(865, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(866, 32);
            this.label1.TabIndex = 61;
            this.label1.Text = "Thông tin đăng kí của bệnh nhân                                                  " +
    "  ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(859, 1017);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton1.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneCircleButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton1.Location = new System.Drawing.Point(874, 63);
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.Size = new System.Drawing.Size(30, 30);
            this.siticoneCircleButton1.TabIndex = 71;
            this.siticoneCircleButton1.Text = "<";
            this.siticoneCircleButton1.Click += new System.EventHandler(this.siticoneCircleButton1_Click);
            // 
            // siticoneCircleButton2
            // 
            this.siticoneCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton2.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneCircleButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneCircleButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton2.Location = new System.Drawing.Point(1214, 63);
            this.siticoneCircleButton2.Name = "siticoneCircleButton2";
            this.siticoneCircleButton2.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton2.Size = new System.Drawing.Size(30, 30);
            this.siticoneCircleButton2.TabIndex = 72;
            this.siticoneCircleButton2.Text = ">";
            this.siticoneCircleButton2.TextOffset = new System.Drawing.Point(2, 0);
            this.siticoneCircleButton2.Click += new System.EventHandler(this.siticoneCircleButton2_Click);
            // 
            // frmXemLichDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 1017);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemLichDat";
            this.Text = "frmXemLichDat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXemLichDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chuyenKhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLichKhamDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBtn.ResumeLayout(false);
            this.pnlBtn.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            this.flyoutPanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QuanLyLichKhamDataSet quanLyLichKhamDataSet;
        private System.Windows.Forms.BindingSource chuyenKhoaBindingSource;
        private QuanLyLichKhamDataSetTableAdapters.ChuyenKhoaTableAdapter chuyenKhoaTableAdapter;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDatLichid;
        private System.Windows.Forms.TextBox txtGiohen;
        private System.Windows.Forms.TextBox txtNgayhen;
        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btn17h;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn7h;
        private System.Windows.Forms.Button btn7h15;
        private System.Windows.Forms.Button btn11h;
        private System.Windows.Forms.Button btn7h30;
        private System.Windows.Forms.Button btn10h45;
        private System.Windows.Forms.Button btn7h45;
        private System.Windows.Forms.Button btn10h30;
        private System.Windows.Forms.Button btn8h;
        private System.Windows.Forms.Button btn10h15;
        private System.Windows.Forms.Button btn8h15;
        private System.Windows.Forms.Button btn8h30;
        private System.Windows.Forms.Button btn8h45;
        private System.Windows.Forms.Button btn16h45;
        private System.Windows.Forms.Button btn9h;
        private System.Windows.Forms.Button btn16h30;
        private System.Windows.Forms.Button btn9h15;
        private System.Windows.Forms.Button btn16h15;
        private System.Windows.Forms.Button btn9h30;
        private System.Windows.Forms.Button btn16h;
        private System.Windows.Forms.Button btn9h45;
        private System.Windows.Forms.Button btn15h45;
        private System.Windows.Forms.Button btn10h;
        private System.Windows.Forms.Button btn15h30;
        private System.Windows.Forms.Button btn14h;
        private System.Windows.Forms.Button btn15h15;
        private System.Windows.Forms.Button btn14h15;
        private System.Windows.Forms.Button btn15h;
        private System.Windows.Forms.Button btn14h30;
        private System.Windows.Forms.Button btn14h45;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDangKi;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label lblGhichu;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblKhancap;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpNgaycheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
    }
}