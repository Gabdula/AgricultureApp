namespace AgricultureApp.Pages
{
    partial class WorkersPageADMIN
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
            this.dataGridViewWorker = new System.Windows.Forms.DataGridView();
            this.RowDeletebtn = new System.Windows.Forms.Button();
            this.RowEditbtn = new System.Windows.Forms.Button();
            this.RowAddbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataInsert = new System.Windows.Forms.TabPage();
            this.groundidPanel = new System.Windows.Forms.Panel();
            this.groundid = new System.Windows.Forms.Label();
            this.groundidContainer = new System.Windows.Forms.Panel();
            this.row8 = new System.Windows.Forms.TextBox();
            this.salaryPanel = new System.Windows.Forms.Panel();
            this.salary = new System.Windows.Forms.Label();
            this.salaryContainer = new System.Windows.Forms.Panel();
            this.row7 = new System.Windows.Forms.TextBox();
            this.jobtitlePanel = new System.Windows.Forms.Panel();
            this.jobtitle = new System.Windows.Forms.Label();
            this.jobtitleContainer = new System.Windows.Forms.Panel();
            this.row6 = new System.Windows.Forms.TextBox();
            this.experiencePanel = new System.Windows.Forms.Panel();
            this.experience = new System.Windows.Forms.Label();
            this.experienceContainer = new System.Windows.Forms.Panel();
            this.row5 = new System.Windows.Forms.TextBox();
            this.agePanel = new System.Windows.Forms.Panel();
            this.age = new System.Windows.Forms.Label();
            this.ageContainer = new System.Windows.Forms.Panel();
            this.row4 = new System.Windows.Forms.TextBox();
            this.fathernamePanel = new System.Windows.Forms.Panel();
            this.fathername = new System.Windows.Forms.Label();
            this.fathernameContainer = new System.Windows.Forms.Panel();
            this.row3 = new System.Windows.Forms.TextBox();
            this.surnamePanel = new System.Windows.Forms.Panel();
            this.surname = new System.Windows.Forms.Label();
            this.surnameContainer = new System.Windows.Forms.Panel();
            this.row2 = new System.Windows.Forms.TextBox();
            this.namePanel = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.nameContainer = new System.Windows.Forms.Panel();
            this.row1 = new System.Windows.Forms.TextBox();
            this.CancelNewdata = new System.Windows.Forms.Button();
            this.SaveNewdatabtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCommands.SuspendLayout();
            this.dataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).BeginInit();
            this.dataInsert.SuspendLayout();
            this.groundidPanel.SuspendLayout();
            this.groundidContainer.SuspendLayout();
            this.salaryPanel.SuspendLayout();
            this.salaryContainer.SuspendLayout();
            this.jobtitlePanel.SuspendLayout();
            this.jobtitleContainer.SuspendLayout();
            this.experiencePanel.SuspendLayout();
            this.experienceContainer.SuspendLayout();
            this.agePanel.SuspendLayout();
            this.ageContainer.SuspendLayout();
            this.fathernamePanel.SuspendLayout();
            this.fathernameContainer.SuspendLayout();
            this.surnamePanel.SuspendLayout();
            this.surnameContainer.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.nameContainer.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgricultureApp.Properties.Resources.worker;
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
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Workers";
            // 
            // tabCommands
            // 
            this.tabCommands.Controls.Add(this.dataList);
            this.tabCommands.Controls.Add(this.dataInsert);
            this.tabCommands.Location = new System.Drawing.Point(0, 42);
            this.tabCommands.Name = "tabCommands";
            this.tabCommands.SelectedIndex = 0;
            this.tabCommands.Size = new System.Drawing.Size(1244, 623);
            this.tabCommands.TabIndex = 2;
            // 
            // dataList
            // 
            this.dataList.Controls.Add(this.dataGridViewWorker);
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
            // dataGridViewWorker
            // 
            this.dataGridViewWorker.AllowUserToAddRows = false;
            this.dataGridViewWorker.AllowUserToDeleteRows = false;
            this.dataGridViewWorker.AllowUserToResizeColumns = false;
            this.dataGridViewWorker.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewWorker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWorker.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorker.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewWorker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewWorker.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewWorker.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWorker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorker.EnableHeadersVisualStyles = false;
            this.dataGridViewWorker.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridViewWorker.Location = new System.Drawing.Point(27, 76);
            this.dataGridViewWorker.MultiSelect = false;
            this.dataGridViewWorker.Name = "dataGridViewWorker";
            this.dataGridViewWorker.ReadOnly = true;
            this.dataGridViewWorker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWorker.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWorker.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewWorker.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewWorker.RowTemplate.Height = 40;
            this.dataGridViewWorker.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWorker.Size = new System.Drawing.Size(1127, 472);
            this.dataGridViewWorker.TabIndex = 6;
            // 
            // RowDeletebtn
            // 
            this.RowDeletebtn.BackColor = System.Drawing.Color.Tomato;
            this.RowDeletebtn.ForeColor = System.Drawing.Color.White;
            this.RowDeletebtn.Location = new System.Drawing.Point(812, 30);
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
            this.RowEditbtn.Location = new System.Drawing.Point(928, 30);
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
            this.RowAddbtn.Location = new System.Drawing.Point(1044, 30);
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
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Workers";
            // 
            // dataInsert
            // 
            this.dataInsert.Controls.Add(this.groundidPanel);
            this.dataInsert.Controls.Add(this.salaryPanel);
            this.dataInsert.Controls.Add(this.jobtitlePanel);
            this.dataInsert.Controls.Add(this.experiencePanel);
            this.dataInsert.Controls.Add(this.agePanel);
            this.dataInsert.Controls.Add(this.fathernamePanel);
            this.dataInsert.Controls.Add(this.surnamePanel);
            this.dataInsert.Controls.Add(this.namePanel);
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
            // groundidPanel
            // 
            this.groundidPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groundidPanel.Controls.Add(this.groundid);
            this.groundidPanel.Controls.Add(this.groundidContainer);
            this.groundidPanel.Location = new System.Drawing.Point(880, 282);
            this.groundidPanel.Name = "groundidPanel";
            this.groundidPanel.Size = new System.Drawing.Size(268, 157);
            this.groundidPanel.TabIndex = 17;
            // 
            // groundid
            // 
            this.groundid.AutoSize = true;
            this.groundid.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groundid.ForeColor = System.Drawing.Color.White;
            this.groundid.Location = new System.Drawing.Point(57, 14);
            this.groundid.Name = "groundid";
            this.groundid.Size = new System.Drawing.Size(137, 37);
            this.groundid.TabIndex = 0;
            this.groundid.Text = "Ground Id";
            // 
            // groundidContainer
            // 
            this.groundidContainer.BackColor = System.Drawing.SystemColors.Control;
            this.groundidContainer.Controls.Add(this.row8);
            this.groundidContainer.Location = new System.Drawing.Point(10, 60);
            this.groundidContainer.Name = "groundidContainer";
            this.groundidContainer.Size = new System.Drawing.Size(247, 83);
            this.groundidContainer.TabIndex = 0;
            // 
            // row8
            // 
            this.row8.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row8.Location = new System.Drawing.Point(16, 25);
            this.row8.Name = "row8";
            this.row8.Size = new System.Drawing.Size(214, 35);
            this.row8.TabIndex = 12;
            // 
            // salaryPanel
            // 
            this.salaryPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.salaryPanel.Controls.Add(this.salary);
            this.salaryPanel.Controls.Add(this.salaryContainer);
            this.salaryPanel.Location = new System.Drawing.Point(601, 282);
            this.salaryPanel.Name = "salaryPanel";
            this.salaryPanel.Size = new System.Drawing.Size(268, 157);
            this.salaryPanel.TabIndex = 16;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salary.ForeColor = System.Drawing.Color.White;
            this.salary.Location = new System.Drawing.Point(56, 14);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(151, 37);
            this.salary.TabIndex = 0;
            this.salary.Text = "Salary (rub)";
            // 
            // salaryContainer
            // 
            this.salaryContainer.BackColor = System.Drawing.SystemColors.Control;
            this.salaryContainer.Controls.Add(this.row7);
            this.salaryContainer.Location = new System.Drawing.Point(10, 60);
            this.salaryContainer.Name = "salaryContainer";
            this.salaryContainer.Size = new System.Drawing.Size(247, 83);
            this.salaryContainer.TabIndex = 0;
            // 
            // row7
            // 
            this.row7.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row7.Location = new System.Drawing.Point(17, 25);
            this.row7.Name = "row7";
            this.row7.Size = new System.Drawing.Size(214, 35);
            this.row7.TabIndex = 11;
            // 
            // jobtitlePanel
            // 
            this.jobtitlePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.jobtitlePanel.Controls.Add(this.jobtitle);
            this.jobtitlePanel.Controls.Add(this.jobtitleContainer);
            this.jobtitlePanel.Location = new System.Drawing.Point(321, 282);
            this.jobtitlePanel.Name = "jobtitlePanel";
            this.jobtitlePanel.Size = new System.Drawing.Size(268, 157);
            this.jobtitlePanel.TabIndex = 15;
            // 
            // jobtitle
            // 
            this.jobtitle.AutoSize = true;
            this.jobtitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobtitle.ForeColor = System.Drawing.Color.White;
            this.jobtitle.Location = new System.Drawing.Point(69, 14);
            this.jobtitle.Name = "jobtitle";
            this.jobtitle.Size = new System.Drawing.Size(117, 37);
            this.jobtitle.TabIndex = 0;
            this.jobtitle.Text = "Job Title";
            // 
            // jobtitleContainer
            // 
            this.jobtitleContainer.BackColor = System.Drawing.SystemColors.Control;
            this.jobtitleContainer.Controls.Add(this.row6);
            this.jobtitleContainer.Location = new System.Drawing.Point(10, 60);
            this.jobtitleContainer.Name = "jobtitleContainer";
            this.jobtitleContainer.Size = new System.Drawing.Size(247, 83);
            this.jobtitleContainer.TabIndex = 0;
            // 
            // row6
            // 
            this.row6.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row6.Location = new System.Drawing.Point(16, 25);
            this.row6.Name = "row6";
            this.row6.Size = new System.Drawing.Size(214, 35);
            this.row6.TabIndex = 10;
            // 
            // experiencePanel
            // 
            this.experiencePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.experiencePanel.Controls.Add(this.experience);
            this.experiencePanel.Controls.Add(this.experienceContainer);
            this.experiencePanel.Location = new System.Drawing.Point(40, 282);
            this.experiencePanel.Name = "experiencePanel";
            this.experiencePanel.Size = new System.Drawing.Size(268, 157);
            this.experiencePanel.TabIndex = 14;
            // 
            // experience
            // 
            this.experience.AutoSize = true;
            this.experience.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.experience.ForeColor = System.Drawing.Color.White;
            this.experience.Location = new System.Drawing.Point(19, 14);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(228, 37);
            this.experience.TabIndex = 0;
            this.experience.Text = "Experience (years)";
            // 
            // experienceContainer
            // 
            this.experienceContainer.BackColor = System.Drawing.SystemColors.Control;
            this.experienceContainer.Controls.Add(this.row5);
            this.experienceContainer.Location = new System.Drawing.Point(10, 60);
            this.experienceContainer.Name = "experienceContainer";
            this.experienceContainer.Size = new System.Drawing.Size(247, 83);
            this.experienceContainer.TabIndex = 0;
            // 
            // row5
            // 
            this.row5.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row5.Location = new System.Drawing.Point(16, 25);
            this.row5.Name = "row5";
            this.row5.Size = new System.Drawing.Size(214, 35);
            this.row5.TabIndex = 9;
            // 
            // agePanel
            // 
            this.agePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.agePanel.Controls.Add(this.age);
            this.agePanel.Controls.Add(this.ageContainer);
            this.agePanel.Location = new System.Drawing.Point(880, 33);
            this.agePanel.Name = "agePanel";
            this.agePanel.Size = new System.Drawing.Size(268, 157);
            this.agePanel.TabIndex = 13;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age.ForeColor = System.Drawing.Color.White;
            this.age.Location = new System.Drawing.Point(99, 14);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(64, 37);
            this.age.TabIndex = 0;
            this.age.Text = "Age";
            // 
            // ageContainer
            // 
            this.ageContainer.BackColor = System.Drawing.SystemColors.Control;
            this.ageContainer.Controls.Add(this.row4);
            this.ageContainer.Location = new System.Drawing.Point(10, 60);
            this.ageContainer.Name = "ageContainer";
            this.ageContainer.Size = new System.Drawing.Size(247, 83);
            this.ageContainer.TabIndex = 0;
            // 
            // row4
            // 
            this.row4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row4.Location = new System.Drawing.Point(16, 24);
            this.row4.Name = "row4";
            this.row4.Size = new System.Drawing.Size(214, 35);
            this.row4.TabIndex = 8;
            // 
            // fathernamePanel
            // 
            this.fathernamePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fathernamePanel.Controls.Add(this.fathername);
            this.fathernamePanel.Controls.Add(this.fathernameContainer);
            this.fathernamePanel.Location = new System.Drawing.Point(601, 33);
            this.fathernamePanel.Name = "fathernamePanel";
            this.fathernamePanel.Size = new System.Drawing.Size(268, 157);
            this.fathernamePanel.TabIndex = 7;
            // 
            // fathername
            // 
            this.fathername.AutoSize = true;
            this.fathername.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fathername.ForeColor = System.Drawing.Color.White;
            this.fathername.Location = new System.Drawing.Point(51, 14);
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(156, 37);
            this.fathername.TabIndex = 0;
            this.fathername.Text = "Fathername";
            // 
            // fathernameContainer
            // 
            this.fathernameContainer.BackColor = System.Drawing.SystemColors.Control;
            this.fathernameContainer.Controls.Add(this.row3);
            this.fathernameContainer.Location = new System.Drawing.Point(10, 60);
            this.fathernameContainer.Name = "fathernameContainer";
            this.fathernameContainer.Size = new System.Drawing.Size(247, 83);
            this.fathernameContainer.TabIndex = 0;
            // 
            // row3
            // 
            this.row3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row3.Location = new System.Drawing.Point(17, 24);
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(214, 35);
            this.row3.TabIndex = 4;
            // 
            // surnamePanel
            // 
            this.surnamePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.surnamePanel.Controls.Add(this.surname);
            this.surnamePanel.Controls.Add(this.surnameContainer);
            this.surnamePanel.Location = new System.Drawing.Point(321, 33);
            this.surnamePanel.Name = "surnamePanel";
            this.surnamePanel.Size = new System.Drawing.Size(268, 157);
            this.surnamePanel.TabIndex = 7;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.ForeColor = System.Drawing.Color.White;
            this.surname.Location = new System.Drawing.Point(65, 14);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(121, 37);
            this.surname.TabIndex = 0;
            this.surname.Text = "Surname";
            // 
            // surnameContainer
            // 
            this.surnameContainer.BackColor = System.Drawing.SystemColors.Control;
            this.surnameContainer.Controls.Add(this.row2);
            this.surnameContainer.Location = new System.Drawing.Point(10, 60);
            this.surnameContainer.Name = "surnameContainer";
            this.surnameContainer.Size = new System.Drawing.Size(247, 83);
            this.surnameContainer.TabIndex = 0;
            // 
            // row2
            // 
            this.row2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row2.Location = new System.Drawing.Point(16, 24);
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(214, 35);
            this.row2.TabIndex = 3;
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.namePanel.Controls.Add(this.name);
            this.namePanel.Controls.Add(this.nameContainer);
            this.namePanel.Location = new System.Drawing.Point(40, 33);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(268, 157);
            this.namePanel.TabIndex = 6;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(80, 14);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 37);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // nameContainer
            // 
            this.nameContainer.BackColor = System.Drawing.SystemColors.Control;
            this.nameContainer.Controls.Add(this.row1);
            this.nameContainer.Location = new System.Drawing.Point(10, 60);
            this.nameContainer.Name = "nameContainer";
            this.nameContainer.Size = new System.Drawing.Size(247, 83);
            this.nameContainer.TabIndex = 0;
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
            // WorkersPageADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCommands);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "WorkersPageADMIN";
            this.Text = "WorkersPageADMIN";
            this.Load += new System.EventHandler(this.WorkersPageADMIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCommands.ResumeLayout(false);
            this.dataList.ResumeLayout(false);
            this.dataList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).EndInit();
            this.dataInsert.ResumeLayout(false);
            this.groundidPanel.ResumeLayout(false);
            this.groundidPanel.PerformLayout();
            this.groundidContainer.ResumeLayout(false);
            this.groundidContainer.PerformLayout();
            this.salaryPanel.ResumeLayout(false);
            this.salaryPanel.PerformLayout();
            this.salaryContainer.ResumeLayout(false);
            this.salaryContainer.PerformLayout();
            this.jobtitlePanel.ResumeLayout(false);
            this.jobtitlePanel.PerformLayout();
            this.jobtitleContainer.ResumeLayout(false);
            this.jobtitleContainer.PerformLayout();
            this.experiencePanel.ResumeLayout(false);
            this.experiencePanel.PerformLayout();
            this.experienceContainer.ResumeLayout(false);
            this.experienceContainer.PerformLayout();
            this.agePanel.ResumeLayout(false);
            this.agePanel.PerformLayout();
            this.ageContainer.ResumeLayout(false);
            this.ageContainer.PerformLayout();
            this.fathernamePanel.ResumeLayout(false);
            this.fathernamePanel.PerformLayout();
            this.fathernameContainer.ResumeLayout(false);
            this.fathernameContainer.PerformLayout();
            this.surnamePanel.ResumeLayout(false);
            this.surnamePanel.PerformLayout();
            this.surnameContainer.ResumeLayout(false);
            this.surnameContainer.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.nameContainer.ResumeLayout(false);
            this.nameContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCommands;
        private System.Windows.Forms.TabPage dataList;
        private System.Windows.Forms.DataGridView dataGridViewWorker;
        private System.Windows.Forms.Button RowDeletebtn;
        private System.Windows.Forms.Button RowEditbtn;
        private System.Windows.Forms.Button RowAddbtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage dataInsert;
        private System.Windows.Forms.Panel surnamePanel;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Panel surnameContainer;
        private System.Windows.Forms.TextBox row2;
        private System.Windows.Forms.Button CancelNewdata;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Panel nameContainer;
        private System.Windows.Forms.TextBox row1;
        private System.Windows.Forms.Button SaveNewdatabtn;
        private System.Windows.Forms.TextBox row3;
        private System.Windows.Forms.TextBox row8;
        private System.Windows.Forms.TextBox row7;
        private System.Windows.Forms.TextBox row6;
        private System.Windows.Forms.TextBox row5;
        private System.Windows.Forms.TextBox row4;
        private System.Windows.Forms.Panel fathernamePanel;
        private System.Windows.Forms.Label fathername;
        private System.Windows.Forms.Panel fathernameContainer;
        private System.Windows.Forms.Panel groundidPanel;
        private System.Windows.Forms.Label groundid;
        private System.Windows.Forms.Panel groundidContainer;
        private System.Windows.Forms.Panel salaryPanel;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Panel salaryContainer;
        private System.Windows.Forms.Panel jobtitlePanel;
        private System.Windows.Forms.Label jobtitle;
        private System.Windows.Forms.Panel jobtitleContainer;
        private System.Windows.Forms.Panel experiencePanel;
        private System.Windows.Forms.Label experience;
        private System.Windows.Forms.Panel experienceContainer;
        private System.Windows.Forms.Panel agePanel;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Panel ageContainer;
    }
}