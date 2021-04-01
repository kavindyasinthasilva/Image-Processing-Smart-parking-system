namespace Auto_parking
{
    partial class MainForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_PlateIn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.text_PlateIn = new System.Windows.Forms.TextBox();
            this.regonizeBtn = new System.Windows.Forms.Button();
            this.capCameraBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.text_PlateOut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_PlateOut = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_CarIn = new System.Windows.Forms.PictureBox();
            this.pictureBox_CarOut = new System.Windows.Forms.PictureBox();
            this.CheckIn = new System.Windows.Forms.Button();
            this.pictureBox_WC = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlateIn)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlateOut)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarOut)).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In";
            this.groupBox1.UseWaitCursor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox_PlateIn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(496, 188);
            this.tableLayoutPanel4.TabIndex = 5;
            this.tableLayoutPanel4.UseWaitCursor = true;
            // 
            // pictureBox_PlateIn
            // 
            this.pictureBox_PlateIn.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_PlateIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_PlateIn.Location = new System.Drawing.Point(251, 3);
            this.pictureBox_PlateIn.Name = "pictureBox_PlateIn";
            this.pictureBox_PlateIn.Size = new System.Drawing.Size(242, 182);
            this.pictureBox_PlateIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlateIn.TabIndex = 4;
            this.pictureBox_PlateIn.TabStop = false;
            this.pictureBox_PlateIn.UseWaitCursor = true;
            this.pictureBox_PlateIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.text_PlateIn, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(242, 182);
            this.tableLayoutPanel5.TabIndex = 5;
            this.tableLayoutPanel5.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plate:";
            this.label1.UseWaitCursor = true;
            // 
            // text_PlateIn
            // 
            this.text_PlateIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_PlateIn.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_PlateIn.Location = new System.Drawing.Point(3, 28);
            this.text_PlateIn.Multiline = true;
            this.text_PlateIn.Name = "text_PlateIn";
            this.text_PlateIn.ReadOnly = true;
            this.text_PlateIn.Size = new System.Drawing.Size(236, 123);
            this.text_PlateIn.TabIndex = 10;
            this.text_PlateIn.Text = "No Image";
            this.text_PlateIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_PlateIn.UseWaitCursor = true;
            this.text_PlateIn.TextChanged += new System.EventHandler(this.text_PlateIn_TextChanged);
            // 
            // regonizeBtn
            // 
            this.regonizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regonizeBtn.BackColor = System.Drawing.Color.Maroon;
            this.regonizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regonizeBtn.FlatAppearance.BorderSize = 2;
            this.regonizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.regonizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regonizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regonizeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regonizeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.regonizeBtn.ImageKey = "(none)";
            this.regonizeBtn.Location = new System.Drawing.Point(3, 237);
            this.regonizeBtn.Name = "regonizeBtn";
            this.regonizeBtn.Size = new System.Drawing.Size(188, 47);
            this.regonizeBtn.TabIndex = 1;
            this.regonizeBtn.Text = "Regonize file";
            this.regonizeBtn.UseVisualStyleBackColor = false;
            this.regonizeBtn.UseWaitCursor = true;
            this.regonizeBtn.Click += new System.EventHandler(this.regonizeBtn_Click);
            // 
            // capCameraBtn
            // 
            this.capCameraBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.capCameraBtn.BackColor = System.Drawing.Color.Maroon;
            this.capCameraBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.capCameraBtn.FlatAppearance.BorderSize = 2;
            this.capCameraBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.capCameraBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.capCameraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capCameraBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capCameraBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.capCameraBtn.Location = new System.Drawing.Point(3, 290);
            this.capCameraBtn.Name = "capCameraBtn";
            this.capCameraBtn.Size = new System.Drawing.Size(188, 47);
            this.capCameraBtn.TabIndex = 0;
            this.capCameraBtn.Text = "Capture";
            this.capCameraBtn.UseVisualStyleBackColor = false;
            this.capCameraBtn.UseWaitCursor = true;
            this.capCameraBtn.Click += new System.EventHandler(this.capCameraBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(511, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 215);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Out";
            this.groupBox2.UseWaitCursor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox_PlateOut, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(496, 188);
            this.tableLayoutPanel6.TabIndex = 6;
            this.tableLayoutPanel6.UseWaitCursor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.text_PlateOut, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(242, 182);
            this.tableLayoutPanel7.TabIndex = 5;
            this.tableLayoutPanel7.UseWaitCursor = true;
            // 
            // text_PlateOut
            // 
            this.text_PlateOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_PlateOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_PlateOut.Location = new System.Drawing.Point(3, 28);
            this.text_PlateOut.Multiline = true;
            this.text_PlateOut.Name = "text_PlateOut";
            this.text_PlateOut.ReadOnly = true;
            this.text_PlateOut.Size = new System.Drawing.Size(211, 120);
            this.text_PlateOut.TabIndex = 10;
            this.text_PlateOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_PlateOut.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Plate:";
            this.label6.UseWaitCursor = true;
            // 
            // pictureBox_PlateOut
            // 
            this.pictureBox_PlateOut.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_PlateOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_PlateOut.Location = new System.Drawing.Point(251, 3);
            this.pictureBox_PlateOut.Name = "pictureBox_PlateOut";
            this.pictureBox_PlateOut.Size = new System.Drawing.Size(242, 182);
            this.pictureBox_PlateOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlateOut.TabIndex = 4;
            this.pictureBox_PlateOut.TabStop = false;
            this.pictureBox_PlateOut.UseWaitCursor = true;
            this.pictureBox_PlateOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1222, 574);
            this.tableLayoutPanel1.TabIndex = 26;
            this.tableLayoutPanel1.UseWaitCursor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_CarIn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_CarOut, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.2676F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.7324F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1016, 568);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.UseWaitCursor = true;
            // 
            // pictureBox_CarIn
            // 
            this.pictureBox_CarIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_CarIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_CarIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CarIn.Image = global::Auto_parking.Properties.Resources._1761349_200;
            this.pictureBox_CarIn.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_CarIn.Name = "pictureBox_CarIn";
            this.pictureBox_CarIn.Size = new System.Drawing.Size(502, 341);
            this.pictureBox_CarIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_CarIn.TabIndex = 1;
            this.pictureBox_CarIn.TabStop = false;
            this.pictureBox_CarIn.UseWaitCursor = true;
            this.pictureBox_CarIn.Click += new System.EventHandler(this.pictureBox_CarIn_Click);
            // 
            // pictureBox_CarOut
            // 
            this.pictureBox_CarOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_CarOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CarOut.Image = global::Auto_parking.Properties.Resources._1761349_200;
            this.pictureBox_CarOut.Location = new System.Drawing.Point(511, 3);
            this.pictureBox_CarOut.Name = "pictureBox_CarOut";
            this.pictureBox_CarOut.Size = new System.Drawing.Size(502, 341);
            this.pictureBox_CarOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_CarOut.TabIndex = 2;
            this.pictureBox_CarOut.TabStop = false;
            this.pictureBox_CarOut.UseWaitCursor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = System.Drawing.Color.Maroon;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(this.regonizeBtn, 0, 2);
            tableLayoutPanel3.Controls.Add(this.capCameraBtn, 0, 3);
            tableLayoutPanel3.Controls.Add(this.CheckIn, 0, 0);
            tableLayoutPanel3.Controls.Add(this.pictureBox_WC, 0, 1);
            tableLayoutPanel3.Controls.Add(this.Home, 0, 4);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(1025, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(194, 568);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.UseWaitCursor = true;
            tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // CheckIn
            // 
            this.CheckIn.BackColor = System.Drawing.Color.Maroon;
            this.CheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.CheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckIn.Location = new System.Drawing.Point(3, 3);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(188, 57);
            this.CheckIn.TabIndex = 7;
            this.CheckIn.Text = "CheckIn";
            this.CheckIn.UseVisualStyleBackColor = false;
            this.CheckIn.UseWaitCursor = true;
            this.CheckIn.Click += new System.EventHandler(this.CheckIn_Click);
            // 
            // pictureBox_WC
            // 
            this.pictureBox_WC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_WC.BackColor = System.Drawing.Color.Snow;
            this.pictureBox_WC.Location = new System.Drawing.Point(3, 66);
            this.pictureBox_WC.Name = "pictureBox_WC";
            this.pictureBox_WC.Size = new System.Drawing.Size(188, 165);
            this.pictureBox_WC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_WC.TabIndex = 6;
            this.pictureBox_WC.TabStop = false;
            this.pictureBox_WC.UseWaitCursor = true;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Maroon;
            this.Home.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.Home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Home.Location = new System.Drawing.Point(3, 343);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(188, 57);
            this.Home.TabIndex = 8;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.UseWaitCursor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1222, 574);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto_Parking";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlateIn)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlateOut)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarOut)).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_CarOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_PlateIn;
        private System.Windows.Forms.PictureBox pictureBox_PlateIn;
        private System.Windows.Forms.PictureBox pictureBox_WC;
        private System.Windows.Forms.Button regonizeBtn;
        private System.Windows.Forms.Button capCameraBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_PlateOut;
        private System.Windows.Forms.PictureBox pictureBox_PlateOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox_CarIn;
        private System.Windows.Forms.Button CheckIn;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label2;
    }
}

