namespace AgricultureApp.Pages
{
    partial class RegestrationPage
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
            this.regSignIn = new System.Windows.Forms.Button();
            this.regSignUp = new System.Windows.Forms.Button();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userFullname = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // regSignIn
            // 
            this.regSignIn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.regSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regSignIn.ForeColor = System.Drawing.Color.DimGray;
            this.regSignIn.Location = new System.Drawing.Point(479, 549);
            this.regSignIn.Name = "regSignIn";
            this.regSignIn.Size = new System.Drawing.Size(113, 35);
            this.regSignIn.TabIndex = 15;
            this.regSignIn.Text = "SIGN IN";
            this.regSignIn.UseVisualStyleBackColor = true;
            this.regSignIn.Click += new System.EventHandler(this.regSignIn_Click);
            // 
            // regSignUp
            // 
            this.regSignUp.BackColor = System.Drawing.Color.YellowGreen;
            this.regSignUp.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regSignUp.ForeColor = System.Drawing.Color.White;
            this.regSignUp.Location = new System.Drawing.Point(424, 474);
            this.regSignUp.Name = "regSignUp";
            this.regSignUp.Size = new System.Drawing.Size(228, 69);
            this.regSignUp.TabIndex = 14;
            this.regSignUp.Text = "SIGN UP";
            this.regSignUp.UseVisualStyleBackColor = false;
            this.regSignUp.Click += new System.EventHandler(this.regSignUp_Click);
            // 
            // userPassword
            // 
            this.userPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPassword.ForeColor = System.Drawing.Color.Silver;
            this.userPassword.Location = new System.Drawing.Point(92, 17);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.Size = new System.Drawing.Size(429, 31);
            this.userPassword.TabIndex = 2;
            this.userPassword.Text = "Password";
            this.userPassword.Enter += new System.EventHandler(this.userPassword_Enter);
            this.userPassword.Leave += new System.EventHandler(this.userPassword_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.userPassword);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(273, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 64);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AgricultureApp.Properties.Resources.Login_Password;
            this.pictureBox3.Location = new System.Drawing.Point(23, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(273, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 64);
            this.panel1.TabIndex = 12;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userName.ForeColor = System.Drawing.Color.Silver;
            this.userName.Location = new System.Drawing.Point(92, 18);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(429, 31);
            this.userName.TabIndex = 1;
            this.userName.Text = "Username";
            this.userName.Enter += new System.EventHandler(this.userName_Enter);
            this.userName.Leave += new System.EventHandler(this.userName_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AgricultureApp.Properties.Resources.Login_Username;
            this.pictureBox2.Location = new System.Drawing.Point(23, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(263, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sign up to AgricultureApp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "Agrolove ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.userFullname);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(273, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 64);
            this.panel3.TabIndex = 16;
            // 
            // userFullname
            // 
            this.userFullname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFullname.ForeColor = System.Drawing.Color.Silver;
            this.userFullname.Location = new System.Drawing.Point(92, 18);
            this.userFullname.Name = "userFullname";
            this.userFullname.Size = new System.Drawing.Size(429, 31);
            this.userFullname.TabIndex = 1;
            this.userFullname.Text = "Full Name";
            this.userFullname.Enter += new System.EventHandler(this.userFullname_Enter);
            this.userFullname.Leave += new System.EventHandler(this.userFullname_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AgricultureApp.Properties.Resources.Login_Fullname;
            this.pictureBox4.Location = new System.Drawing.Point(23, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.userEmail);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(273, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(538, 64);
            this.panel4.TabIndex = 17;
            // 
            // userEmail
            // 
            this.userEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userEmail.ForeColor = System.Drawing.Color.Silver;
            this.userEmail.Location = new System.Drawing.Point(92, 18);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(429, 31);
            this.userEmail.TabIndex = 1;
            this.userEmail.Text = "Email Adress";
            this.userEmail.Enter += new System.EventHandler(this.userEmail_Enter);
            this.userEmail.Leave += new System.EventHandler(this.userEmail_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AgricultureApp.Properties.Resources.Login_Email;
            this.pictureBox5.Location = new System.Drawing.Point(23, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgricultureApp.Properties.Resources.logo3_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // RegestrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 641);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.regSignIn);
            this.Controls.Add(this.regSignUp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1260, 680);
            this.MinimumSize = new System.Drawing.Size(1260, 680);
            this.Name = "RegestrationPage";
            this.Text = "RegestrationPage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regSignIn;
        private System.Windows.Forms.Button regSignUp;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox userFullname;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}