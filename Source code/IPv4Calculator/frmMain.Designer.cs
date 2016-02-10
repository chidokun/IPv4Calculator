namespace IPv4Calculator
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("IPv4 Address");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Hex Address");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Subnet Mask");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Wildcast Mask");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Prefix");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Class");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("First Octet Range");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvwProperties = new System.Windows.Forms.ListView();
            this.clmProperty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numPrefix = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSubnetMask = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIPv4Address = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvwSubnetting = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSubnetBitmap = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubnetBitmap = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numHostPerSubnet = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubnetting = new System.Windows.Forms.Button();
            this.numNumberOfSubnets = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numSubnetBits = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.picSubnetMask = new System.Windows.Forms.PictureBox();
            this.picIPAddress = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrefix)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlSubnetBitmap.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHostPerSubnet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfSubnets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubnetBits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubnetMask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIPAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(165)))), ((int)(((byte)(64)))));
            this.pnlTitle.Controls.Add(this.btnInfo);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.ForeColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(857, 38);
            this.pnlTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.Location = new System.Drawing.Point(10, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "IPv4 Calculator";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 462);
            this.panel1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.lvwProperties);
            this.groupBox4.Location = new System.Drawing.Point(18, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 201);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties";
            // 
            // lvwProperties
            // 
            this.lvwProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmProperty,
            this.clmValue});
            this.lvwProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwProperties.FullRowSelect = true;
            this.lvwProperties.GridLines = true;
            this.lvwProperties.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.Tag = "";
            this.lvwProperties.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7});
            this.lvwProperties.Location = new System.Drawing.Point(3, 19);
            this.lvwProperties.Name = "lvwProperties";
            this.lvwProperties.Size = new System.Drawing.Size(221, 179);
            this.lvwProperties.TabIndex = 0;
            this.lvwProperties.UseCompatibleStateImageBehavior = false;
            this.lvwProperties.View = System.Windows.Forms.View.Details;
            // 
            // clmProperty
            // 
            this.clmProperty.Text = "Property";
            this.clmProperty.Width = 109;
            // 
            // clmValue
            // 
            this.clmValue.Text = "Value";
            this.clmValue.Width = 111;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numPrefix);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbClass);
            this.groupBox3.Location = new System.Drawing.Point(18, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 82);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network Class and Prefix";
            // 
            // numPrefix
            // 
            this.numPrefix.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numPrefix.Location = new System.Drawing.Point(120, 39);
            this.numPrefix.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPrefix.Name = "numPrefix";
            this.numPrefix.Size = new System.Drawing.Size(72, 30);
            this.numPrefix.TabIndex = 4;
            this.numPrefix.ValueChanged += new System.EventHandler(this.numPrefix_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prefix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(16, 39);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(77, 30);
            this.cmbClass.TabIndex = 2;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picSubnetMask);
            this.groupBox2.Controls.Add(this.cmbSubnetMask);
            this.groupBox2.Location = new System.Drawing.Point(18, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subnet Mask";
            // 
            // cmbSubnetMask
            // 
            this.cmbSubnetMask.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbSubnetMask.FormattingEnabled = true;
            this.cmbSubnetMask.Location = new System.Drawing.Point(16, 22);
            this.cmbSubnetMask.Name = "cmbSubnetMask";
            this.cmbSubnetMask.Size = new System.Drawing.Size(176, 30);
            this.cmbSubnetMask.TabIndex = 2;
            this.cmbSubnetMask.Text = "255.255.255.0";
            this.cmbSubnetMask.SelectedIndexChanged += new System.EventHandler(this.cmbSubnetMask_SelectedIndexChanged);
            this.cmbSubnetMask.TextUpdate += new System.EventHandler(this.cmbSubnetMask_TextUpdate);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picIPAddress);
            this.groupBox1.Controls.Add(this.txtIPv4Address);
            this.groupBox1.Location = new System.Drawing.Point(18, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Address";
            // 
            // txtIPv4Address
            // 
            this.txtIPv4Address.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIPv4Address.Location = new System.Drawing.Point(16, 22);
            this.txtIPv4Address.Name = "txtIPv4Address";
            this.txtIPv4Address.Size = new System.Drawing.Size(176, 30);
            this.txtIPv4Address.TabIndex = 0;
            this.txtIPv4Address.Text = "192.168.123.125";
            this.txtIPv4Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIPv4Address.TextChanged += new System.EventHandler(this.txtIPv4Address_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.pnlSubnetBitmap);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(263, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 462);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lvwSubnetting);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(594, 339);
            this.panel5.TabIndex = 2;
            // 
            // lvwSubnetting
            // 
            this.lvwSubnetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwSubnetting.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvwSubnetting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lvwSubnetting.FullRowSelect = true;
            this.lvwSubnetting.GridLines = true;
            this.lvwSubnetting.Location = new System.Drawing.Point(6, 6);
            this.lvwSubnetting.Name = "lvwSubnetting";
            this.lvwSubnetting.Size = new System.Drawing.Size(572, 333);
            this.lvwSubnetting.TabIndex = 0;
            this.lvwSubnetting.UseCompatibleStateImageBehavior = false;
            this.lvwSubnetting.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 42;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Network ID";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prefix";
            this.columnHeader5.Width = 44;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "First Address";
            this.columnHeader6.Width = 102;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Last Address";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Broadcast Address";
            this.columnHeader8.Width = 143;
            // 
            // pnlSubnetBitmap
            // 
            this.pnlSubnetBitmap.Controls.Add(this.label5);
            this.pnlSubnetBitmap.Controls.Add(this.lblSubnetBitmap);
            this.pnlSubnetBitmap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSubnetBitmap.Location = new System.Drawing.Point(0, 400);
            this.pnlSubnetBitmap.Name = "pnlSubnetBitmap";
            this.pnlSubnetBitmap.Size = new System.Drawing.Size(594, 62);
            this.pnlSubnetBitmap.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Subnet Bitmap";
            // 
            // lblSubnetBitmap
            // 
            this.lblSubnetBitmap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubnetBitmap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSubnetBitmap.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSubnetBitmap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(148)))), ((int)(((byte)(48)))));
            this.lblSubnetBitmap.Location = new System.Drawing.Point(6, 24);
            this.lblSubnetBitmap.Name = "lblSubnetBitmap";
            this.lblSubnetBitmap.Size = new System.Drawing.Size(572, 26);
            this.lblSubnetBitmap.TabIndex = 9;
            this.lblSubnetBitmap.Text = "00000000.00000000.00000000.00000000";
            this.lblSubnetBitmap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numHostPerSubnet);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnSubnetting);
            this.panel3.Controls.Add(this.numNumberOfSubnets);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.numSubnetBits);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 61);
            this.panel3.TabIndex = 0;
            // 
            // numHostPerSubnet
            // 
            this.numHostPerSubnet.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numHostPerSubnet.Location = new System.Drawing.Point(232, 25);
            this.numHostPerSubnet.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numHostPerSubnet.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numHostPerSubnet.Name = "numHostPerSubnet";
            this.numHostPerSubnet.Size = new System.Drawing.Size(125, 30);
            this.numHostPerSubnet.TabIndex = 11;
            this.numHostPerSubnet.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numHostPerSubnet.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hosts per subnet";
            // 
            // btnSubnetting
            // 
            this.btnSubnetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubnetting.BackColor = System.Drawing.Color.Silver;
            this.btnSubnetting.FlatAppearance.BorderSize = 0;
            this.btnSubnetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSubnetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSubnetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubnetting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubnetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubnetting.Location = new System.Drawing.Point(474, 26);
            this.btnSubnetting.Name = "btnSubnetting";
            this.btnSubnetting.Size = new System.Drawing.Size(104, 29);
            this.btnSubnetting.TabIndex = 10;
            this.btnSubnetting.Text = "Subnetting";
            this.btnSubnetting.UseVisualStyleBackColor = false;
            this.btnSubnetting.Click += new System.EventHandler(this.btnSubnetting_Click);
            // 
            // numNumberOfSubnets
            // 
            this.numNumberOfSubnets.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numNumberOfSubnets.Location = new System.Drawing.Point(101, 25);
            this.numNumberOfSubnets.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numNumberOfSubnets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfSubnets.Name = "numNumberOfSubnets";
            this.numNumberOfSubnets.Size = new System.Drawing.Size(125, 30);
            this.numNumberOfSubnets.TabIndex = 8;
            this.numNumberOfSubnets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfSubnets.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of subnets";
            // 
            // numSubnetBits
            // 
            this.numSubnetBits.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numSubnetBits.Location = new System.Drawing.Point(6, 25);
            this.numSubnetBits.Name = "numSubnetBits";
            this.numSubnetBits.Size = new System.Drawing.Size(89, 30);
            this.numSubnetBits.TabIndex = 6;
            this.numSubnetBits.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subnet bits";
            // 
            // picSubnetMask
            // 
            this.picSubnetMask.Location = new System.Drawing.Point(198, 26);
            this.picSubnetMask.Name = "picSubnetMask";
            this.picSubnetMask.Size = new System.Drawing.Size(20, 20);
            this.picSubnetMask.TabIndex = 3;
            this.picSubnetMask.TabStop = false;
            // 
            // picIPAddress
            // 
            this.picIPAddress.Location = new System.Drawing.Point(198, 26);
            this.picIPAddress.Name = "picIPAddress";
            this.picIPAddress.Size = new System.Drawing.Size(20, 20);
            this.picIPAddress.TabIndex = 1;
            this.picIPAddress.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(193)))), ((int)(((byte)(74)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(119)))), ((int)(((byte)(46)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(136)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::IPv4Calculator.Properties.Resources.icon_info_24;
            this.btnInfo.Location = new System.Drawing.Point(813, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(44, 38);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(773, 524);
            this.Name = "frmMain";
            this.Text = "IPv4 Calculator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrefix)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlSubnetBitmap.ResumeLayout(false);
            this.pnlSubnetBitmap.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHostPerSubnet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfSubnets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubnetBits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSubnetMask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIPAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIPv4Address;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSubnetMask;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlSubnetBitmap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvwProperties;
        private System.Windows.Forms.ColumnHeader clmProperty;
        private System.Windows.Forms.ColumnHeader clmValue;
        private System.Windows.Forms.ListView lvwSubnetting;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.NumericUpDown numNumberOfSubnets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSubnetBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubnetting;
        internal System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.NumericUpDown numHostPerSubnet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picSubnetMask;
        private System.Windows.Forms.PictureBox picIPAddress;
        private System.Windows.Forms.Label lblSubnetBitmap;
    }
}

