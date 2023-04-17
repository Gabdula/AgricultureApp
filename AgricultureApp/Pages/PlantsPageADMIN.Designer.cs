namespace AgricultureApp.Pages
{
    partial class PlantsPageADMIN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCommands = new System.Windows.Forms.TabControl();
            this.dataList = new System.Windows.Forms.TabPage();
            this.imageplantContainer = new System.Windows.Forms.Panel();
            this.plant = new System.Windows.Forms.Label();
            this.imagePlant = new System.Windows.Forms.PictureBox();
            this.dataGridViewPlants = new System.Windows.Forms.DataGridView();
            this.RowDeletebtn = new System.Windows.Forms.Button();
            this.RowEditbtn = new System.Windows.Forms.Button();
            this.RowAddbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataInsert = new System.Windows.Forms.TabPage();
            this.yieldplantPanel = new System.Windows.Forms.Panel();
            this.yieldplant = new System.Windows.Forms.Label();
            this.yieldplantContainer = new System.Windows.Forms.Panel();
            this.row4 = new System.Windows.Forms.TextBox();
            this.imageplantPanel = new System.Windows.Forms.Panel();
            this.plantimageEdit = new System.Windows.Forms.PictureBox();
            this.imageplant1 = new System.Windows.Forms.Label();
            this.imageContainer = new System.Windows.Forms.Panel();
            this.ChoiseImage = new System.Windows.Forms.Button();
            this.growingtimePanel = new System.Windows.Forms.Panel();
            this.growingtime = new System.Windows.Forms.Label();
            this.growingtimeContainer = new System.Windows.Forms.Panel();
            this.row3 = new System.Windows.Forms.TextBox();
            this.typeplantPanel = new System.Windows.Forms.Panel();
            this.typeplant = new System.Windows.Forms.Label();
            this.typeplantContainer = new System.Windows.Forms.Panel();
            this.row2 = new System.Windows.Forms.TextBox();
            this.titleplantPanel = new System.Windows.Forms.Panel();
            this.titleplant = new System.Windows.Forms.Label();
            this.titleplantContainer = new System.Windows.Forms.Panel();
            this.row1 = new System.Windows.Forms.TextBox();
            this.CancelNewdata = new System.Windows.Forms.Button();
            this.SaveNewdatabtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCommands.SuspendLayout();
            this.dataList.SuspendLayout();
            this.imageplantContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlants)).BeginInit();
            this.dataInsert.SuspendLayout();
            this.yieldplantPanel.SuspendLayout();
            this.yieldplantContainer.SuspendLayout();
            this.imageplantPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantimageEdit)).BeginInit();
            this.imageContainer.SuspendLayout();
            this.growingtimePanel.SuspendLayout();
            this.growingtimeContainer.SuspendLayout();
            this.typeplantPanel.SuspendLayout();
            this.typeplantContainer.SuspendLayout();
            this.titleplantPanel.SuspendLayout();
            this.titleplantContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgricultureApp.Properties.Resources.plants;
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
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plants";
            // 
            // tabCommands
            // 
            this.tabCommands.Controls.Add(this.dataList);
            this.tabCommands.Controls.Add(this.dataInsert);
            this.tabCommands.Location = new System.Drawing.Point(0, 42);
            this.tabCommands.Name = "tabCommands";
            this.tabCommands.SelectedIndex = 0;
            this.tabCommands.Size = new System.Drawing.Size(1244, 623);
            this.tabCommands.TabIndex = 3;
            // 
            // dataList
            // 
            this.dataList.Controls.Add(this.imageplantContainer);
            this.dataList.Controls.Add(this.dataGridViewPlants);
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
            // dataGridViewPlants
            // 
            this.dataGridViewPlants.AllowUserToAddRows = false;
            this.dataGridViewPlants.AllowUserToDeleteRows = false;
            this.dataGridViewPlants.AllowUserToResizeColumns = false;
            this.dataGridViewPlants.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewPlants.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPlants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlants.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPlants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPlants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewPlants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPlants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlants.EnableHeadersVisualStyles = false;
            this.dataGridViewPlants.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridViewPlants.Location = new System.Drawing.Point(27, 76);
            this.dataGridViewPlants.MultiSelect = false;
            this.dataGridViewPlants.Name = "dataGridViewPlants";
            this.dataGridViewPlants.ReadOnly = true;
            this.dataGridViewPlants.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlants.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPlants.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewPlants.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPlants.RowTemplate.Height = 40;
            this.dataGridViewPlants.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPlants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlants.Size = new System.Drawing.Size(961, 472);
            this.dataGridViewPlants.TabIndex = 6;
            this.dataGridViewPlants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPlants_CellClick);
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
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Plants";
            // 
            // dataInsert
            // 
            this.dataInsert.Controls.Add(this.yieldplantPanel);
            this.dataInsert.Controls.Add(this.imageplantPanel);
            this.dataInsert.Controls.Add(this.growingtimePanel);
            this.dataInsert.Controls.Add(this.typeplantPanel);
            this.dataInsert.Controls.Add(this.titleplantPanel);
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
            // yieldplantPanel
            // 
            this.yieldplantPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.yieldplantPanel.Controls.Add(this.yieldplant);
            this.yieldplantPanel.Controls.Add(this.yieldplantContainer);
            this.yieldplantPanel.Location = new System.Drawing.Point(40, 282);
            this.yieldplantPanel.Name = "yieldplantPanel";
            this.yieldplantPanel.Size = new System.Drawing.Size(268, 157);
            this.yieldplantPanel.TabIndex = 14;
            // 
            // yieldplant
            // 
            this.yieldplant.AutoSize = true;
            this.yieldplant.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yieldplant.ForeColor = System.Drawing.Color.White;
            this.yieldplant.Location = new System.Drawing.Point(51, 14);
            this.yieldplant.Name = "yieldplant";
            this.yieldplant.Size = new System.Drawing.Size(144, 37);
            this.yieldplant.TabIndex = 0;
            this.yieldplant.Text = "Yield plant";
            // 
            // yieldplantContainer
            // 
            this.yieldplantContainer.BackColor = System.Drawing.SystemColors.Control;
            this.yieldplantContainer.Controls.Add(this.row4);
            this.yieldplantContainer.Location = new System.Drawing.Point(10, 60);
            this.yieldplantContainer.Name = "yieldplantContainer";
            this.yieldplantContainer.Size = new System.Drawing.Size(247, 83);
            this.yieldplantContainer.TabIndex = 0;
            // 
            // row4
            // 
            this.row4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row4.Location = new System.Drawing.Point(16, 25);
            this.row4.Name = "row4";
            this.row4.Size = new System.Drawing.Size(214, 35);
            this.row4.TabIndex = 9;
            // 
            // imageplantPanel
            // 
            this.imageplantPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.imageplantPanel.Controls.Add(this.plantimageEdit);
            this.imageplantPanel.Controls.Add(this.imageplant1);
            this.imageplantPanel.Controls.Add(this.imageContainer);
            this.imageplantPanel.Location = new System.Drawing.Point(866, 33);
            this.imageplantPanel.Name = "imageplantPanel";
            this.imageplantPanel.Size = new System.Drawing.Size(268, 406);
            this.imageplantPanel.TabIndex = 13;
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
            // imageContainer
            // 
            this.imageContainer.BackColor = System.Drawing.SystemColors.Control;
            this.imageContainer.Controls.Add(this.ChoiseImage);
            this.imageContainer.Location = new System.Drawing.Point(9, 309);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(247, 83);
            this.imageContainer.TabIndex = 0;
            // 
            // ChoiseImage
            // 
            this.ChoiseImage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiseImage.Location = new System.Drawing.Point(17, 25);
            this.ChoiseImage.Name = "ChoiseImage";
            this.ChoiseImage.Size = new System.Drawing.Size(214, 35);
            this.ChoiseImage.TabIndex = 0;
            this.ChoiseImage.Text = "Выбрать картинку";
            this.ChoiseImage.UseVisualStyleBackColor = true;
            this.ChoiseImage.Click += new System.EventHandler(this.ChoiseImage_Click);
            // 
            // growingtimePanel
            // 
            this.growingtimePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.growingtimePanel.Controls.Add(this.growingtime);
            this.growingtimePanel.Controls.Add(this.growingtimeContainer);
            this.growingtimePanel.Location = new System.Drawing.Point(444, 282);
            this.growingtimePanel.Name = "growingtimePanel";
            this.growingtimePanel.Size = new System.Drawing.Size(268, 157);
            this.growingtimePanel.TabIndex = 7;
            // 
            // growingtime
            // 
            this.growingtime.AutoSize = true;
            this.growingtime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.growingtime.ForeColor = System.Drawing.Color.White;
            this.growingtime.Location = new System.Drawing.Point(42, 14);
            this.growingtime.Name = "growingtime";
            this.growingtime.Size = new System.Drawing.Size(179, 37);
            this.growingtime.TabIndex = 0;
            this.growingtime.Text = "Growing time";
            // 
            // growingtimeContainer
            // 
            this.growingtimeContainer.BackColor = System.Drawing.SystemColors.Control;
            this.growingtimeContainer.Controls.Add(this.row3);
            this.growingtimeContainer.Location = new System.Drawing.Point(10, 60);
            this.growingtimeContainer.Name = "growingtimeContainer";
            this.growingtimeContainer.Size = new System.Drawing.Size(247, 83);
            this.growingtimeContainer.TabIndex = 0;
            // 
            // row3
            // 
            this.row3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row3.Location = new System.Drawing.Point(17, 24);
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(214, 35);
            this.row3.TabIndex = 4;
            // 
            // typeplantPanel
            // 
            this.typeplantPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.typeplantPanel.Controls.Add(this.typeplant);
            this.typeplantPanel.Controls.Add(this.typeplantContainer);
            this.typeplantPanel.Location = new System.Drawing.Point(444, 33);
            this.typeplantPanel.Name = "typeplantPanel";
            this.typeplantPanel.Size = new System.Drawing.Size(268, 157);
            this.typeplantPanel.TabIndex = 7;
            // 
            // typeplant
            // 
            this.typeplant.AutoSize = true;
            this.typeplant.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeplant.ForeColor = System.Drawing.Color.White;
            this.typeplant.Location = new System.Drawing.Point(61, 14);
            this.typeplant.Name = "typeplant";
            this.typeplant.Size = new System.Drawing.Size(141, 37);
            this.typeplant.TabIndex = 0;
            this.typeplant.Text = "Type plant";
            // 
            // typeplantContainer
            // 
            this.typeplantContainer.BackColor = System.Drawing.SystemColors.Control;
            this.typeplantContainer.Controls.Add(this.row2);
            this.typeplantContainer.Location = new System.Drawing.Point(10, 60);
            this.typeplantContainer.Name = "typeplantContainer";
            this.typeplantContainer.Size = new System.Drawing.Size(247, 83);
            this.typeplantContainer.TabIndex = 0;
            // 
            // row2
            // 
            this.row2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row2.Location = new System.Drawing.Point(16, 24);
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(214, 35);
            this.row2.TabIndex = 3;
            // 
            // titleplantPanel
            // 
            this.titleplantPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.titleplantPanel.Controls.Add(this.titleplant);
            this.titleplantPanel.Controls.Add(this.titleplantContainer);
            this.titleplantPanel.Location = new System.Drawing.Point(40, 33);
            this.titleplantPanel.Name = "titleplantPanel";
            this.titleplantPanel.Size = new System.Drawing.Size(268, 157);
            this.titleplantPanel.TabIndex = 6;
            // 
            // titleplant
            // 
            this.titleplant.AutoSize = true;
            this.titleplant.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleplant.ForeColor = System.Drawing.Color.White;
            this.titleplant.Location = new System.Drawing.Point(59, 14);
            this.titleplant.Name = "titleplant";
            this.titleplant.Size = new System.Drawing.Size(136, 37);
            this.titleplant.TabIndex = 0;
            this.titleplant.Text = "Title plant";
            // 
            // titleplantContainer
            // 
            this.titleplantContainer.BackColor = System.Drawing.SystemColors.Control;
            this.titleplantContainer.Controls.Add(this.row1);
            this.titleplantContainer.Location = new System.Drawing.Point(10, 60);
            this.titleplantContainer.Name = "titleplantContainer";
            this.titleplantContainer.Size = new System.Drawing.Size(247, 83);
            this.titleplantContainer.TabIndex = 0;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PlantsPageADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCommands);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "PlantsPageADMIN";
            this.Text = "PlantsPageADMIN";
            this.Load += new System.EventHandler(this.PlantsPageADMIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCommands.ResumeLayout(false);
            this.dataList.ResumeLayout(false);
            this.dataList.PerformLayout();
            this.imageplantContainer.ResumeLayout(false);
            this.imageplantContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlants)).EndInit();
            this.dataInsert.ResumeLayout(false);
            this.yieldplantPanel.ResumeLayout(false);
            this.yieldplantPanel.PerformLayout();
            this.yieldplantContainer.ResumeLayout(false);
            this.yieldplantContainer.PerformLayout();
            this.imageplantPanel.ResumeLayout(false);
            this.imageplantPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantimageEdit)).EndInit();
            this.imageContainer.ResumeLayout(false);
            this.growingtimePanel.ResumeLayout(false);
            this.growingtimePanel.PerformLayout();
            this.growingtimeContainer.ResumeLayout(false);
            this.growingtimeContainer.PerformLayout();
            this.typeplantPanel.ResumeLayout(false);
            this.typeplantPanel.PerformLayout();
            this.typeplantContainer.ResumeLayout(false);
            this.typeplantContainer.PerformLayout();
            this.titleplantPanel.ResumeLayout(false);
            this.titleplantPanel.PerformLayout();
            this.titleplantContainer.ResumeLayout(false);
            this.titleplantContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCommands;
        private System.Windows.Forms.TabPage dataList;
        private System.Windows.Forms.DataGridView dataGridViewPlants;
        private System.Windows.Forms.Button RowDeletebtn;
        private System.Windows.Forms.Button RowEditbtn;
        private System.Windows.Forms.Button RowAddbtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage dataInsert;
        private System.Windows.Forms.Panel yieldplantPanel;
        private System.Windows.Forms.Label yieldplant;
        private System.Windows.Forms.Panel yieldplantContainer;
        private System.Windows.Forms.TextBox row4;
        private System.Windows.Forms.Panel imageplantPanel;
        private System.Windows.Forms.Label imageplant1;
        private System.Windows.Forms.Panel imageContainer;
        private System.Windows.Forms.Panel growingtimePanel;
        private System.Windows.Forms.Label growingtime;
        private System.Windows.Forms.Panel growingtimeContainer;
        private System.Windows.Forms.TextBox row3;
        private System.Windows.Forms.Panel typeplantPanel;
        private System.Windows.Forms.Label typeplant;
        private System.Windows.Forms.Panel typeplantContainer;
        private System.Windows.Forms.TextBox row2;
        private System.Windows.Forms.Panel titleplantPanel;
        private System.Windows.Forms.Label titleplant;
        private System.Windows.Forms.Panel titleplantContainer;
        private System.Windows.Forms.TextBox row1;
        private System.Windows.Forms.Button CancelNewdata;
        private System.Windows.Forms.Button SaveNewdatabtn;
        private System.Windows.Forms.Button ChoiseImage;
        private System.Windows.Forms.PictureBox imagePlant;
        private System.Windows.Forms.Panel imageplantContainer;
        private System.Windows.Forms.Label plant;
        private System.Windows.Forms.PictureBox plantimageEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}