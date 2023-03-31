namespace AgricultureApp.Pages
{
    partial class SowingPageADMIN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SowingPageADMIN));
            this.tabCommands = new System.Windows.Forms.TabControl();
            this.dataList = new System.Windows.Forms.TabPage();
            this.imageplantContainer = new System.Windows.Forms.Panel();
            this.plant = new System.Windows.Forms.Label();
            this.imagePlant = new System.Windows.Forms.PictureBox();
            this.dataGridViewSowing = new System.Windows.Forms.DataGridView();
            this.RowDeletebtn = new System.Windows.Forms.Button();
            this.RowEditbtn = new System.Windows.Forms.Button();
            this.RowAddbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataInsert = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.plantidPanel = new System.Windows.Forms.Panel();
            this.plantid = new System.Windows.Forms.Label();
            this.plantidContainer = new System.Windows.Forms.Panel();
            this.plantidDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.harvestingtimePanel = new System.Windows.Forms.Panel();
            this.harvestingdate = new System.Windows.Forms.Label();
            this.harvestingtimeContainer = new System.Windows.Forms.Panel();
            this.harvestingdateDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.pestcontrolPanel = new System.Windows.Forms.Panel();
            this.pestcontrol = new System.Windows.Forms.Label();
            this.pestcontrolContainer = new System.Windows.Forms.Panel();
            this.pestcontrolCheck = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.seedscountPanel = new System.Windows.Forms.Panel();
            this.seedscount = new System.Windows.Forms.Label();
            this.seedscountContainer = new System.Windows.Forms.Panel();
            this.row3 = new System.Windows.Forms.TextBox();
            this.sowingdatePanel = new System.Windows.Forms.Panel();
            this.sowingdate = new System.Windows.Forms.Label();
            this.sowingdateContainer = new System.Windows.Forms.Panel();
            this.sowingdateDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.seedsourcePanel = new System.Windows.Forms.Panel();
            this.seedsource = new System.Windows.Forms.Label();
            this.seedsourceContainer = new System.Windows.Forms.Panel();
            this.row1 = new System.Windows.Forms.TextBox();
            this.CancelNewdata = new System.Windows.Forms.Button();
            this.SaveNewdatabtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plantimageEdit = new System.Windows.Forms.PictureBox();
            this.imageplant1 = new System.Windows.Forms.Label();
            this.imageplantPanel = new System.Windows.Forms.Panel();
            this.tabCommands.SuspendLayout();
            this.dataList.SuspendLayout();
            this.imageplantContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSowing)).BeginInit();
            this.dataInsert.SuspendLayout();
            this.plantidPanel.SuspendLayout();
            this.plantidContainer.SuspendLayout();
            this.harvestingtimePanel.SuspendLayout();
            this.harvestingtimeContainer.SuspendLayout();
            this.pestcontrolPanel.SuspendLayout();
            this.pestcontrolContainer.SuspendLayout();
            this.seedscountPanel.SuspendLayout();
            this.seedscountContainer.SuspendLayout();
            this.sowingdatePanel.SuspendLayout();
            this.sowingdateContainer.SuspendLayout();
            this.seedsourcePanel.SuspendLayout();
            this.seedsourceContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantimageEdit)).BeginInit();
            this.imageplantPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCommands
            // 
            this.tabCommands.Controls.Add(this.dataList);
            this.tabCommands.Controls.Add(this.dataInsert);
            this.tabCommands.Location = new System.Drawing.Point(0, 42);
            this.tabCommands.Name = "tabCommands";
            this.tabCommands.SelectedIndex = 0;
            this.tabCommands.Size = new System.Drawing.Size(1244, 623);
            this.tabCommands.TabIndex = 4;
            // 
            // dataList
            // 
            this.dataList.Controls.Add(this.imageplantContainer);
            this.dataList.Controls.Add(this.dataGridViewSowing);
            this.dataList.Controls.Add(this.RowDeletebtn);
            this.dataList.Controls.Add(this.RowEditbtn);
            this.dataList.Controls.Add(this.RowAddbtn);
            this.dataList.Controls.Add(this.Searchbtn);
            this.dataList.Controls.Add(this.textSearch);
            this.dataList.Controls.Add(this.label2);
            this.dataList.Location = new System.Drawing.Point(4, 22);
            this.dataList.Name = "dataList";
            this.dataList.Padding = new System.Windows.Forms.Padding(3);
            this.dataList.Size = new System.Drawing.Size(1236, 597);
            this.dataList.TabIndex = 0;
            this.dataList.Text = "Grounds list";
            this.dataList.UseVisualStyleBackColor = true;
            // 
            // imageplantContainer
            // 
            this.imageplantContainer.BackColor = System.Drawing.SystemColors.Control;
            this.imageplantContainer.Controls.Add(this.plant);
            this.imageplantContainer.Controls.Add(this.imagePlant);
            this.imageplantContainer.Location = new System.Drawing.Point(994, 76);
            this.imageplantContainer.Name = "imageplantContainer";
            this.imageplantContainer.Size = new System.Drawing.Size(180, 239);
            this.imageplantContainer.TabIndex = 8;
            // 
            // plant
            // 
            this.plant.AutoSize = true;
            this.plant.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plant.Location = new System.Drawing.Point(14, 16);
            this.plant.Name = "plant";
            this.plant.Size = new System.Drawing.Size(60, 30);
            this.plant.TabIndex = 8;
            this.plant.Text = "plant";
            // 
            // imagePlant
            // 
            this.imagePlant.BackColor = System.Drawing.SystemColors.ControlLight;
            this.imagePlant.Location = new System.Drawing.Point(5, 64);
            this.imagePlant.Name = "imagePlant";
            this.imagePlant.Size = new System.Drawing.Size(170, 170);
            this.imagePlant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePlant.TabIndex = 7;
            this.imagePlant.TabStop = false;
            // 
            // dataGridViewSowing
            // 
            this.dataGridViewSowing.AllowUserToAddRows = false;
            this.dataGridViewSowing.AllowUserToDeleteRows = false;
            this.dataGridViewSowing.AllowUserToResizeColumns = false;
            this.dataGridViewSowing.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewSowing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSowing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSowing.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSowing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSowing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSowing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSowing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSowing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSowing.EnableHeadersVisualStyles = false;
            this.dataGridViewSowing.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridViewSowing.Location = new System.Drawing.Point(27, 76);
            this.dataGridViewSowing.MultiSelect = false;
            this.dataGridViewSowing.Name = "dataGridViewSowing";
            this.dataGridViewSowing.ReadOnly = true;
            this.dataGridViewSowing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSowing.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSowing.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewSowing.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSowing.RowTemplate.Height = 40;
            this.dataGridViewSowing.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSowing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSowing.Size = new System.Drawing.Size(961, 472);
            this.dataGridViewSowing.TabIndex = 6;
            this.dataGridViewSowing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSowing_CellClick);
            // 
            // RowDeletebtn
            // 
            this.RowDeletebtn.BackColor = System.Drawing.Color.Tomato;
            this.RowDeletebtn.ForeColor = System.Drawing.Color.White;
            this.RowDeletebtn.Location = new System.Drawing.Point(648, 30);
            this.RowDeletebtn.Name = "RowDeletebtn";
            this.RowDeletebtn.Size = new System.Drawing.Size(110, 40);
            this.RowDeletebtn.TabIndex = 5;
            this.RowDeletebtn.Text = "Delete";
            this.RowDeletebtn.UseVisualStyleBackColor = false;
            this.RowDeletebtn.Click += new System.EventHandler(this.RowDeletebtn_Click);
            // 
            // RowEditbtn
            // 
            this.RowEditbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.RowEditbtn.ForeColor = System.Drawing.Color.White;
            this.RowEditbtn.Location = new System.Drawing.Point(764, 30);
            this.RowEditbtn.Name = "RowEditbtn";
            this.RowEditbtn.Size = new System.Drawing.Size(110, 40);
            this.RowEditbtn.TabIndex = 4;
            this.RowEditbtn.Text = "Edit";
            this.RowEditbtn.UseVisualStyleBackColor = false;
            this.RowEditbtn.Click += new System.EventHandler(this.RowEditbtn_Click);
            // 
            // RowAddbtn
            // 
            this.RowAddbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RowAddbtn.ForeColor = System.Drawing.Color.White;
            this.RowAddbtn.Location = new System.Drawing.Point(880, 30);
            this.RowAddbtn.Name = "RowAddbtn";
            this.RowAddbtn.Size = new System.Drawing.Size(110, 40);
            this.RowAddbtn.TabIndex = 3;
            this.RowAddbtn.Text = "Add new";
            this.RowAddbtn.UseVisualStyleBackColor = false;
            this.RowAddbtn.Click += new System.EventHandler(this.RowAddbtn_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.LightGray;
            this.Searchbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Searchbtn.Location = new System.Drawing.Point(366, 41);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(75, 23);
            this.Searchbtn.TabIndex = 2;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSearch.Location = new System.Drawing.Point(27, 37);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(333, 29);
            this.textSearch.TabIndex = 1;
            this.textSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextSearch_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Sowing";
            // 
            // dataInsert
            // 
            this.dataInsert.Controls.Add(this.imageplantPanel);
            this.dataInsert.Controls.Add(this.label3);
            this.dataInsert.Controls.Add(this.plantidPanel);
            this.dataInsert.Controls.Add(this.harvestingtimePanel);
            this.dataInsert.Controls.Add(this.pestcontrolPanel);
            this.dataInsert.Controls.Add(this.seedscountPanel);
            this.dataInsert.Controls.Add(this.sowingdatePanel);
            this.dataInsert.Controls.Add(this.seedsourcePanel);
            this.dataInsert.Controls.Add(this.CancelNewdata);
            this.dataInsert.Controls.Add(this.SaveNewdatabtn);
            this.dataInsert.Location = new System.Drawing.Point(4, 22);
            this.dataInsert.Name = "dataInsert";
            this.dataInsert.Padding = new System.Windows.Forms.Padding(3);
            this.dataInsert.Size = new System.Drawing.Size(1236, 597);
            this.dataInsert.TabIndex = 1;
            this.dataInsert.Text = "Grounds detail";
            this.dataInsert.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(952, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "no plant record, no record added";
            // 
            // plantidPanel
            // 
            this.plantidPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.plantidPanel.Controls.Add(this.plantid);
            this.plantidPanel.Controls.Add(this.plantidContainer);
            this.plantidPanel.Location = new System.Drawing.Point(595, 283);
            this.plantidPanel.Name = "plantidPanel";
            this.plantidPanel.Size = new System.Drawing.Size(268, 157);
            this.plantidPanel.TabIndex = 8;
            // 
            // plantid
            // 
            this.plantid.AutoSize = true;
            this.plantid.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plantid.ForeColor = System.Drawing.Color.White;
            this.plantid.Location = new System.Drawing.Point(91, 14);
            this.plantid.Name = "plantid";
            this.plantid.Size = new System.Drawing.Size(77, 37);
            this.plantid.TabIndex = 0;
            this.plantid.Text = "Plant";
            // 
            // plantidContainer
            // 
            this.plantidContainer.BackColor = System.Drawing.SystemColors.Control;
            this.plantidContainer.Controls.Add(this.plantidDropdown);
            this.plantidContainer.Location = new System.Drawing.Point(10, 60);
            this.plantidContainer.Name = "plantidContainer";
            this.plantidContainer.Size = new System.Drawing.Size(247, 83);
            this.plantidContainer.TabIndex = 0;
            // 
            // plantidDropdown
            // 
            this.plantidDropdown.BackColor = System.Drawing.Color.Transparent;
            this.plantidDropdown.BackgroundColor = System.Drawing.Color.White;
            this.plantidDropdown.BorderColor = System.Drawing.Color.Silver;
            this.plantidDropdown.BorderRadius = 1;
            this.plantidDropdown.Color = System.Drawing.Color.Silver;
            this.plantidDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.plantidDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.plantidDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.plantidDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.plantidDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.plantidDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.plantidDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.plantidDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.plantidDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantidDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.plantidDropdown.FillDropDown = true;
            this.plantidDropdown.FillIndicator = false;
            this.plantidDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plantidDropdown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plantidDropdown.ForeColor = System.Drawing.Color.Black;
            this.plantidDropdown.FormattingEnabled = true;
            this.plantidDropdown.Icon = null;
            this.plantidDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.plantidDropdown.IndicatorColor = System.Drawing.Color.Gray;
            this.plantidDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.plantidDropdown.ItemBackColor = System.Drawing.Color.White;
            this.plantidDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.plantidDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.plantidDropdown.ItemHeight = 30;
            this.plantidDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.plantidDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.plantidDropdown.ItemTopMargin = 3;
            this.plantidDropdown.Location = new System.Drawing.Point(17, 25);
            this.plantidDropdown.Name = "plantidDropdown";
            this.plantidDropdown.Size = new System.Drawing.Size(216, 36);
            this.plantidDropdown.TabIndex = 0;
            this.plantidDropdown.Text = null;
            this.plantidDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.plantidDropdown.TextLeftMargin = 5;
            this.plantidDropdown.SelectedIndexChanged += new System.EventHandler(this.PlantidDropdown_SelectedIndexChanged);
            // 
            // harvestingtimePanel
            // 
            this.harvestingtimePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.harvestingtimePanel.Controls.Add(this.harvestingdate);
            this.harvestingtimePanel.Controls.Add(this.harvestingtimeContainer);
            this.harvestingtimePanel.Location = new System.Drawing.Point(319, 283);
            this.harvestingtimePanel.Name = "harvestingtimePanel";
            this.harvestingtimePanel.Size = new System.Drawing.Size(268, 157);
            this.harvestingtimePanel.TabIndex = 15;
            // 
            // harvestingdate
            // 
            this.harvestingdate.AutoSize = true;
            this.harvestingdate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.harvestingdate.ForeColor = System.Drawing.Color.White;
            this.harvestingdate.Location = new System.Drawing.Point(36, 14);
            this.harvestingdate.Name = "harvestingdate";
            this.harvestingdate.Size = new System.Drawing.Size(204, 37);
            this.harvestingdate.TabIndex = 0;
            this.harvestingdate.Text = "Harvesting date";
            // 
            // harvestingtimeContainer
            // 
            this.harvestingtimeContainer.BackColor = System.Drawing.SystemColors.Control;
            this.harvestingtimeContainer.Controls.Add(this.harvestingdateDate);
            this.harvestingtimeContainer.Location = new System.Drawing.Point(10, 60);
            this.harvestingtimeContainer.Name = "harvestingtimeContainer";
            this.harvestingtimeContainer.Size = new System.Drawing.Size(247, 83);
            this.harvestingtimeContainer.TabIndex = 0;
            // 
            // harvestingdateDate
            // 
            this.harvestingdateDate.BackColor = System.Drawing.Color.White;
            this.harvestingdateDate.BorderRadius = 5;
            this.harvestingdateDate.Color = System.Drawing.Color.White;
            this.harvestingdateDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.harvestingdateDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.harvestingdateDate.DisabledColor = System.Drawing.Color.Gray;
            this.harvestingdateDate.DisplayWeekNumbers = false;
            this.harvestingdateDate.DPHeight = 0;
            this.harvestingdateDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.harvestingdateDate.FillDatePicker = false;
            this.harvestingdateDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.harvestingdateDate.ForeColor = System.Drawing.Color.Black;
            this.harvestingdateDate.Icon = ((System.Drawing.Image)(resources.GetObject("harvestingdateDate.Icon")));
            this.harvestingdateDate.IconColor = System.Drawing.Color.Gray;
            this.harvestingdateDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.harvestingdateDate.LeftTextMargin = 5;
            this.harvestingdateDate.Location = new System.Drawing.Point(16, 25);
            this.harvestingdateDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.harvestingdateDate.Name = "harvestingdateDate";
            this.harvestingdateDate.Size = new System.Drawing.Size(214, 35);
            this.harvestingdateDate.TabIndex = 16;
            this.harvestingdateDate.Value = new System.DateTime(2023, 3, 28, 13, 21, 0, 0);
            // 
            // pestcontrolPanel
            // 
            this.pestcontrolPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pestcontrolPanel.Controls.Add(this.pestcontrol);
            this.pestcontrolPanel.Controls.Add(this.pestcontrolContainer);
            this.pestcontrolPanel.Location = new System.Drawing.Point(40, 283);
            this.pestcontrolPanel.Name = "pestcontrolPanel";
            this.pestcontrolPanel.Size = new System.Drawing.Size(268, 157);
            this.pestcontrolPanel.TabIndex = 14;
            // 
            // pestcontrol
            // 
            this.pestcontrol.AutoSize = true;
            this.pestcontrol.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pestcontrol.ForeColor = System.Drawing.Color.White;
            this.pestcontrol.Location = new System.Drawing.Point(54, 14);
            this.pestcontrol.Name = "pestcontrol";
            this.pestcontrol.Size = new System.Drawing.Size(156, 37);
            this.pestcontrol.TabIndex = 0;
            this.pestcontrol.Text = "Pest control";
            // 
            // pestcontrolContainer
            // 
            this.pestcontrolContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pestcontrolContainer.Controls.Add(this.pestcontrolCheck);
            this.pestcontrolContainer.Location = new System.Drawing.Point(10, 60);
            this.pestcontrolContainer.Name = "pestcontrolContainer";
            this.pestcontrolContainer.Size = new System.Drawing.Size(247, 83);
            this.pestcontrolContainer.TabIndex = 0;
            // 
            // pestcontrolCheck
            // 
            this.pestcontrolCheck.AllowBindingControlAnimation = true;
            this.pestcontrolCheck.AllowBindingControlColorChanges = false;
            this.pestcontrolCheck.AllowBindingControlLocation = true;
            this.pestcontrolCheck.AllowCheckBoxAnimation = false;
            this.pestcontrolCheck.AllowCheckmarkAnimation = true;
            this.pestcontrolCheck.AllowOnHoverStates = true;
            this.pestcontrolCheck.AutoCheck = true;
            this.pestcontrolCheck.BackColor = System.Drawing.Color.Transparent;
            this.pestcontrolCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pestcontrolCheck.BackgroundImage")));
            this.pestcontrolCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pestcontrolCheck.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.pestcontrolCheck.BorderRadius = 12;
            this.pestcontrolCheck.Checked = false;
            this.pestcontrolCheck.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.pestcontrolCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.pestcontrolCheck.CustomCheckmarkImage = null;
            this.pestcontrolCheck.Location = new System.Drawing.Point(99, 25);
            this.pestcontrolCheck.MinimumSize = new System.Drawing.Size(17, 17);
            this.pestcontrolCheck.Name = "pestcontrolCheck";
            this.pestcontrolCheck.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.pestcontrolCheck.OnCheck.BorderRadius = 12;
            this.pestcontrolCheck.OnCheck.BorderThickness = 2;
            this.pestcontrolCheck.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.pestcontrolCheck.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.pestcontrolCheck.OnCheck.CheckmarkThickness = 2;
            this.pestcontrolCheck.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.pestcontrolCheck.OnDisable.BorderRadius = 12;
            this.pestcontrolCheck.OnDisable.BorderThickness = 2;
            this.pestcontrolCheck.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.pestcontrolCheck.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.pestcontrolCheck.OnDisable.CheckmarkThickness = 2;
            this.pestcontrolCheck.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.pestcontrolCheck.OnHoverChecked.BorderRadius = 12;
            this.pestcontrolCheck.OnHoverChecked.BorderThickness = 2;
            this.pestcontrolCheck.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.pestcontrolCheck.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.pestcontrolCheck.OnHoverChecked.CheckmarkThickness = 2;
            this.pestcontrolCheck.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.pestcontrolCheck.OnHoverUnchecked.BorderRadius = 12;
            this.pestcontrolCheck.OnHoverUnchecked.BorderThickness = 1;
            this.pestcontrolCheck.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.pestcontrolCheck.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.pestcontrolCheck.OnUncheck.BorderRadius = 12;
            this.pestcontrolCheck.OnUncheck.BorderThickness = 1;
            this.pestcontrolCheck.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.pestcontrolCheck.Size = new System.Drawing.Size(35, 35);
            this.pestcontrolCheck.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.pestcontrolCheck.TabIndex = 16;
            this.pestcontrolCheck.ThreeState = false;
            this.pestcontrolCheck.ToolTipText = null;
            // 
            // seedscountPanel
            // 
            this.seedscountPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.seedscountPanel.Controls.Add(this.seedscount);
            this.seedscountPanel.Controls.Add(this.seedscountContainer);
            this.seedscountPanel.Location = new System.Drawing.Point(595, 33);
            this.seedscountPanel.Name = "seedscountPanel";
            this.seedscountPanel.Size = new System.Drawing.Size(268, 157);
            this.seedscountPanel.TabIndex = 7;
            // 
            // seedscount
            // 
            this.seedscount.AutoSize = true;
            this.seedscount.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seedscount.ForeColor = System.Drawing.Color.White;
            this.seedscount.Location = new System.Drawing.Point(57, 14);
            this.seedscount.Name = "seedscount";
            this.seedscount.Size = new System.Drawing.Size(160, 37);
            this.seedscount.TabIndex = 0;
            this.seedscount.Text = "Seeds count";
            // 
            // seedscountContainer
            // 
            this.seedscountContainer.BackColor = System.Drawing.SystemColors.Control;
            this.seedscountContainer.Controls.Add(this.row3);
            this.seedscountContainer.Location = new System.Drawing.Point(10, 60);
            this.seedscountContainer.Name = "seedscountContainer";
            this.seedscountContainer.Size = new System.Drawing.Size(247, 83);
            this.seedscountContainer.TabIndex = 0;
            // 
            // row3
            // 
            this.row3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row3.Location = new System.Drawing.Point(17, 24);
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(214, 35);
            this.row3.TabIndex = 4;
            // 
            // sowingdatePanel
            // 
            this.sowingdatePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.sowingdatePanel.Controls.Add(this.sowingdate);
            this.sowingdatePanel.Controls.Add(this.sowingdateContainer);
            this.sowingdatePanel.Location = new System.Drawing.Point(319, 33);
            this.sowingdatePanel.Name = "sowingdatePanel";
            this.sowingdatePanel.Size = new System.Drawing.Size(268, 157);
            this.sowingdatePanel.TabIndex = 7;
            // 
            // sowingdate
            // 
            this.sowingdate.AutoSize = true;
            this.sowingdate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sowingdate.ForeColor = System.Drawing.Color.White;
            this.sowingdate.Location = new System.Drawing.Point(53, 14);
            this.sowingdate.Name = "sowingdate";
            this.sowingdate.Size = new System.Drawing.Size(165, 37);
            this.sowingdate.TabIndex = 0;
            this.sowingdate.Text = "Sowing date";
            // 
            // sowingdateContainer
            // 
            this.sowingdateContainer.BackColor = System.Drawing.SystemColors.Control;
            this.sowingdateContainer.Controls.Add(this.sowingdateDate);
            this.sowingdateContainer.Location = new System.Drawing.Point(10, 60);
            this.sowingdateContainer.Name = "sowingdateContainer";
            this.sowingdateContainer.Size = new System.Drawing.Size(247, 83);
            this.sowingdateContainer.TabIndex = 0;
            // 
            // sowingdateDate
            // 
            this.sowingdateDate.BackColor = System.Drawing.Color.White;
            this.sowingdateDate.BorderRadius = 5;
            this.sowingdateDate.Color = System.Drawing.Color.White;
            this.sowingdateDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.sowingdateDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.sowingdateDate.DisabledColor = System.Drawing.Color.Gray;
            this.sowingdateDate.DisplayWeekNumbers = false;
            this.sowingdateDate.DPHeight = 0;
            this.sowingdateDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.sowingdateDate.FillDatePicker = false;
            this.sowingdateDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sowingdateDate.ForeColor = System.Drawing.Color.Black;
            this.sowingdateDate.Icon = ((System.Drawing.Image)(resources.GetObject("sowingdateDate.Icon")));
            this.sowingdateDate.IconColor = System.Drawing.Color.Gray;
            this.sowingdateDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.sowingdateDate.LeftTextMargin = 5;
            this.sowingdateDate.Location = new System.Drawing.Point(18, 24);
            this.sowingdateDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.sowingdateDate.Name = "sowingdateDate";
            this.sowingdateDate.Size = new System.Drawing.Size(214, 35);
            this.sowingdateDate.TabIndex = 17;
            this.sowingdateDate.Value = new System.DateTime(2023, 3, 28, 13, 21, 0, 0);
            // 
            // seedsourcePanel
            // 
            this.seedsourcePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.seedsourcePanel.Controls.Add(this.seedsource);
            this.seedsourcePanel.Controls.Add(this.seedsourceContainer);
            this.seedsourcePanel.Location = new System.Drawing.Point(40, 33);
            this.seedsourcePanel.Name = "seedsourcePanel";
            this.seedsourcePanel.Size = new System.Drawing.Size(268, 157);
            this.seedsourcePanel.TabIndex = 6;
            // 
            // seedsource
            // 
            this.seedsource.AutoSize = true;
            this.seedsource.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seedsource.ForeColor = System.Drawing.Color.White;
            this.seedsource.Location = new System.Drawing.Point(53, 14);
            this.seedsource.Name = "seedsource";
            this.seedsource.Size = new System.Drawing.Size(159, 37);
            this.seedsource.TabIndex = 0;
            this.seedsource.Text = "Seed source";
            // 
            // seedsourceContainer
            // 
            this.seedsourceContainer.BackColor = System.Drawing.SystemColors.Control;
            this.seedsourceContainer.Controls.Add(this.row1);
            this.seedsourceContainer.Location = new System.Drawing.Point(10, 60);
            this.seedsourceContainer.Name = "seedsourceContainer";
            this.seedsourceContainer.Size = new System.Drawing.Size(247, 83);
            this.seedsourceContainer.TabIndex = 0;
            // 
            // row1
            // 
            this.row1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.row1.Location = new System.Drawing.Point(16, 24);
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(214, 35);
            this.row1.TabIndex = 2;
            // 
            // CancelNewdata
            // 
            this.CancelNewdata.BackColor = System.Drawing.Color.Tomato;
            this.CancelNewdata.ForeColor = System.Drawing.Color.White;
            this.CancelNewdata.Location = new System.Drawing.Point(922, 471);
            this.CancelNewdata.Name = "CancelNewdata";
            this.CancelNewdata.Size = new System.Drawing.Size(110, 40);
            this.CancelNewdata.TabIndex = 5;
            this.CancelNewdata.Text = "Cancel";
            this.CancelNewdata.UseVisualStyleBackColor = false;
            this.CancelNewdata.Click += new System.EventHandler(this.CancelNewdata_Click);
            // 
            // SaveNewdatabtn
            // 
            this.SaveNewdatabtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveNewdatabtn.ForeColor = System.Drawing.Color.White;
            this.SaveNewdatabtn.Location = new System.Drawing.Point(1038, 471);
            this.SaveNewdatabtn.Name = "SaveNewdatabtn";
            this.SaveNewdatabtn.Size = new System.Drawing.Size(110, 40);
            this.SaveNewdatabtn.TabIndex = 4;
            this.SaveNewdatabtn.Text = "Save";
            this.SaveNewdatabtn.UseVisualStyleBackColor = false;
            this.SaveNewdatabtn.Click += new System.EventHandler(this.SaveNewdatabtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 65);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgricultureApp.Properties.Resources.sowing;
            this.pictureBox1.Location = new System.Drawing.Point(31, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sowing";
            // 
            // plantimageEdit
            // 
            this.plantimageEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plantimageEdit.Location = new System.Drawing.Point(9, 56);
            this.plantimageEdit.Name = "plantimageEdit";
            this.plantimageEdit.Size = new System.Drawing.Size(247, 247);
            this.plantimageEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plantimageEdit.TabIndex = 1;
            this.plantimageEdit.TabStop = false;
            // 
            // imageplant1
            // 
            this.imageplant1.AutoSize = true;
            this.imageplant1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageplant1.ForeColor = System.Drawing.Color.White;
            this.imageplant1.Location = new System.Drawing.Point(49, 14);
            this.imageplant1.Name = "imageplant1";
            this.imageplant1.Size = new System.Drawing.Size(159, 37);
            this.imageplant1.TabIndex = 0;
            this.imageplant1.Text = "Image plant";
            // 
            // imageplantPanel
            // 
            this.imageplantPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.imageplantPanel.Controls.Add(this.plantimageEdit);
            this.imageplantPanel.Controls.Add(this.imageplant1);
            this.imageplantPanel.Location = new System.Drawing.Point(890, 75);
            this.imageplantPanel.Name = "imageplantPanel";
            this.imageplantPanel.Size = new System.Drawing.Size(268, 314);
            this.imageplantPanel.TabIndex = 14;
            // 
            // SowingPageADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCommands);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "SowingPageADMIN";
            this.Text = "SowingPageADMIN";
            this.Load += new System.EventHandler(this.SowingPageADMIN_Load);
            this.tabCommands.ResumeLayout(false);
            this.dataList.ResumeLayout(false);
            this.dataList.PerformLayout();
            this.imageplantContainer.ResumeLayout(false);
            this.imageplantContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSowing)).EndInit();
            this.dataInsert.ResumeLayout(false);
            this.dataInsert.PerformLayout();
            this.plantidPanel.ResumeLayout(false);
            this.plantidPanel.PerformLayout();
            this.plantidContainer.ResumeLayout(false);
            this.harvestingtimePanel.ResumeLayout(false);
            this.harvestingtimePanel.PerformLayout();
            this.harvestingtimeContainer.ResumeLayout(false);
            this.pestcontrolPanel.ResumeLayout(false);
            this.pestcontrolPanel.PerformLayout();
            this.pestcontrolContainer.ResumeLayout(false);
            this.seedscountPanel.ResumeLayout(false);
            this.seedscountPanel.PerformLayout();
            this.seedscountContainer.ResumeLayout(false);
            this.seedscountContainer.PerformLayout();
            this.sowingdatePanel.ResumeLayout(false);
            this.sowingdatePanel.PerformLayout();
            this.sowingdateContainer.ResumeLayout(false);
            this.seedsourcePanel.ResumeLayout(false);
            this.seedsourcePanel.PerformLayout();
            this.seedsourceContainer.ResumeLayout(false);
            this.seedsourceContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantimageEdit)).EndInit();
            this.imageplantPanel.ResumeLayout(false);
            this.imageplantPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCommands;
        private System.Windows.Forms.TabPage dataList;
        private System.Windows.Forms.Panel imageplantContainer;
        private System.Windows.Forms.Label plant;
        private System.Windows.Forms.PictureBox imagePlant;
        private System.Windows.Forms.DataGridView dataGridViewSowing;
        private System.Windows.Forms.Button RowDeletebtn;
        private System.Windows.Forms.Button RowEditbtn;
        private System.Windows.Forms.Button RowAddbtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage dataInsert;
        private System.Windows.Forms.Panel pestcontrolPanel;
        private System.Windows.Forms.Label pestcontrol;
        private System.Windows.Forms.Panel pestcontrolContainer;
        private System.Windows.Forms.Panel seedscountPanel;
        private System.Windows.Forms.Label seedscount;
        private System.Windows.Forms.Panel seedscountContainer;
        private System.Windows.Forms.TextBox row3;
        private System.Windows.Forms.Panel sowingdatePanel;
        private System.Windows.Forms.Label sowingdate;
        private System.Windows.Forms.Panel sowingdateContainer;
        private System.Windows.Forms.Panel seedsourcePanel;
        private System.Windows.Forms.Label seedsource;
        private System.Windows.Forms.Panel seedsourceContainer;
        private System.Windows.Forms.TextBox row1;
        private System.Windows.Forms.Button CancelNewdata;
        private System.Windows.Forms.Button SaveNewdatabtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel harvestingtimePanel;
        private System.Windows.Forms.Label harvestingdate;
        private System.Windows.Forms.Panel harvestingtimeContainer;
        private Bunifu.UI.WinForms.BunifuDatePicker harvestingdateDate;
        private Bunifu.UI.WinForms.BunifuCheckBox pestcontrolCheck;
        private Bunifu.UI.WinForms.BunifuDatePicker sowingdateDate;
        private System.Windows.Forms.Panel plantidPanel;
        private System.Windows.Forms.Label plantid;
        private System.Windows.Forms.Panel plantidContainer;
        private Bunifu.UI.WinForms.BunifuDropdown plantidDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel imageplantPanel;
        private System.Windows.Forms.PictureBox plantimageEdit;
        private System.Windows.Forms.Label imageplant1;
    }
}