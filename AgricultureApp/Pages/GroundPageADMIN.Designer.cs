namespace AgricultureApp.Pages
{
    partial class GroundPageADMIN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCommands = new System.Windows.Forms.TabControl();
            this.dataList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RowDeletebtn = new System.Windows.Forms.Button();
            this.RowEditbtn = new System.Windows.Forms.Button();
            this.RowAddbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataInsert = new System.Windows.Forms.TabPage();
            this.numberGroundPanel = new System.Windows.Forms.Panel();
            this.numbergrounds = new System.Windows.Forms.Label();
            this.numberGroundContainer = new System.Windows.Forms.Panel();
            this.row1 = new System.Windows.Forms.TextBox();
            this.row2 = new System.Windows.Forms.TextBox();
            this.CancelNewdata = new System.Windows.Forms.Button();
            this.SaveNewdatabtn = new System.Windows.Forms.Button();
            this.landAreaContainer = new System.Windows.Forms.Panel();
            this.landAreaPanel = new System.Windows.Forms.Panel();
            this.landarea = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCommands.SuspendLayout();
            this.dataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataInsert.SuspendLayout();
            this.numberGroundPanel.SuspendLayout();
            this.numberGroundContainer.SuspendLayout();
            this.landAreaContainer.SuspendLayout();
            this.landAreaPanel.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgricultureApp.Properties.Resources.ground;
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
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grounds";
            // 
            // tabCommands
            // 
            this.tabCommands.Controls.Add(this.dataList);
            this.tabCommands.Controls.Add(this.dataInsert);
            this.tabCommands.Location = new System.Drawing.Point(0, 42);
            this.tabCommands.Name = "tabCommands";
            this.tabCommands.SelectedIndex = 0;
            this.tabCommands.Size = new System.Drawing.Size(1244, 623);
            this.tabCommands.TabIndex = 1;
            // 
            // dataList
            // 
            this.dataList.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(27, 76);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 472);
            this.dataGridView1.TabIndex = 6;
            // 
            // RowDeletebtn
            // 
            this.RowDeletebtn.BackColor = System.Drawing.Color.Tomato;
            this.RowDeletebtn.ForeColor = System.Drawing.Color.White;
            this.RowDeletebtn.Location = new System.Drawing.Point(1049, 238);
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
            this.RowEditbtn.Location = new System.Drawing.Point(1049, 177);
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
            this.RowAddbtn.Location = new System.Drawing.Point(1049, 119);
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
            this.Searchbtn.Location = new System.Drawing.Point(1064, 43);
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
            this.textSearch.Size = new System.Drawing.Size(1000, 29);
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
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Ground";
            // 
            // dataInsert
            // 
            this.dataInsert.Controls.Add(this.landAreaPanel);
            this.dataInsert.Controls.Add(this.CancelNewdata);
            this.dataInsert.Controls.Add(this.numberGroundPanel);
            this.dataInsert.Controls.Add(this.SaveNewdatabtn);
            this.dataInsert.Location = new System.Drawing.Point(4, 22);
            this.dataInsert.Name = "dataInsert";
            this.dataInsert.Padding = new System.Windows.Forms.Padding(3);
            this.dataInsert.Size = new System.Drawing.Size(1236, 597);
            this.dataInsert.TabIndex = 1;
            this.dataInsert.Text = "Grounds detail";
            this.dataInsert.UseVisualStyleBackColor = true;
            // 
            // numberGroundPanel
            // 
            this.numberGroundPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.numberGroundPanel.Controls.Add(this.numbergrounds);
            this.numberGroundPanel.Controls.Add(this.numberGroundContainer);
            this.numberGroundPanel.Location = new System.Drawing.Point(43, 47);
            this.numberGroundPanel.Name = "numberGroundPanel";
            this.numberGroundPanel.Size = new System.Drawing.Size(268, 157);
            this.numberGroundPanel.TabIndex = 6;
            // 
            // numbergrounds
            // 
            this.numbergrounds.AutoSize = true;
            this.numbergrounds.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numbergrounds.ForeColor = System.Drawing.Color.White;
            this.numbergrounds.Location = new System.Drawing.Point(19, 14);
            this.numbergrounds.Name = "numbergrounds";
            this.numbergrounds.Size = new System.Drawing.Size(219, 37);
            this.numbergrounds.TabIndex = 0;
            this.numbergrounds.Text = "Number grounds";
            // 
            // numberGroundContainer
            // 
            this.numberGroundContainer.BackColor = System.Drawing.SystemColors.Control;
            this.numberGroundContainer.Controls.Add(this.row1);
            this.numberGroundContainer.Location = new System.Drawing.Point(10, 60);
            this.numberGroundContainer.Name = "numberGroundContainer";
            this.numberGroundContainer.Size = new System.Drawing.Size(247, 83);
            this.numberGroundContainer.TabIndex = 0;
            // 
            // row1
            // 
            this.row1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.row1.Location = new System.Drawing.Point(16, 24);
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(214, 35);
            this.row1.TabIndex = 2;
            // 
            // row2
            // 
            this.row2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.row2.Location = new System.Drawing.Point(16, 24);
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(214, 35);
            this.row2.TabIndex = 3;
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
            // landAreaContainer
            // 
            this.landAreaContainer.BackColor = System.Drawing.SystemColors.Control;
            this.landAreaContainer.Controls.Add(this.row2);
            this.landAreaContainer.Location = new System.Drawing.Point(10, 60);
            this.landAreaContainer.Name = "landAreaContainer";
            this.landAreaContainer.Size = new System.Drawing.Size(247, 83);
            this.landAreaContainer.TabIndex = 0;
            // 
            // landAreaPanel
            // 
            this.landAreaPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.landAreaPanel.Controls.Add(this.landarea);
            this.landAreaPanel.Controls.Add(this.landAreaContainer);
            this.landAreaPanel.Location = new System.Drawing.Point(357, 47);
            this.landAreaPanel.Name = "landAreaPanel";
            this.landAreaPanel.Size = new System.Drawing.Size(268, 157);
            this.landAreaPanel.TabIndex = 7;
            // 
            // landarea
            // 
            this.landarea.AutoSize = true;
            this.landarea.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.landarea.ForeColor = System.Drawing.Color.White;
            this.landarea.Location = new System.Drawing.Point(43, 14);
            this.landarea.Name = "landarea";
            this.landarea.Size = new System.Drawing.Size(185, 37);
            this.landarea.TabIndex = 0;
            this.landarea.Text = "Land area (ha)";
            // 
            // GroundPageADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCommands);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "GroundPageADMIN";
            this.Text = "GroundPageADMIN";
            this.Load += new System.EventHandler(this.GroundPageADMIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCommands.ResumeLayout(false);
            this.dataList.ResumeLayout(false);
            this.dataList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataInsert.ResumeLayout(false);
            this.numberGroundPanel.ResumeLayout(false);
            this.numberGroundPanel.PerformLayout();
            this.numberGroundContainer.ResumeLayout(false);
            this.numberGroundContainer.PerformLayout();
            this.landAreaContainer.ResumeLayout(false);
            this.landAreaContainer.PerformLayout();
            this.landAreaPanel.ResumeLayout(false);
            this.landAreaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCommands;
        private System.Windows.Forms.TabPage dataList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RowDeletebtn;
        private System.Windows.Forms.Button RowEditbtn;
        private System.Windows.Forms.Button RowAddbtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage dataInsert;
        private System.Windows.Forms.Button CancelNewdata;
        private System.Windows.Forms.Button SaveNewdatabtn;
        private System.Windows.Forms.TextBox row2;
        private System.Windows.Forms.TextBox row1;
        private System.Windows.Forms.Label numbergrounds;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel numberGroundPanel;
        private System.Windows.Forms.Panel numberGroundContainer;
        private System.Windows.Forms.Panel landAreaPanel;
        private System.Windows.Forms.Label landarea;
        private System.Windows.Forms.Panel landAreaContainer;
    }
}