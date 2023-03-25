namespace AgricultureApp.Pages
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginSignIn = new System.Windows.Forms.Button();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.loginSignUp = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agrolove ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(263, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sign in to AgricultureApp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(385, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "or use your email account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(273, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 64);
            this.panel1.TabIndex = 4;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.userPassword);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(273, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 64);
            this.panel2.TabIndex = 5;
            // 
            // loginSignIn
            // 
            this.loginSignIn.BackColor = System.Drawing.Color.YellowGreen;
            this.loginSignIn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginSignIn.ForeColor = System.Drawing.Color.White;
            this.loginSignIn.Location = new System.Drawing.Point(422, 428);
            this.loginSignIn.Name = "loginSignIn";
            this.loginSignIn.Size = new System.Drawing.Size(228, 69);
            this.loginSignIn.TabIndex = 6;
            this.loginSignIn.Text = "SIGN IN";
            this.loginSignIn.UseVisualStyleBackColor = false;
            this.loginSignIn.Click += new System.EventHandler(this.loginSignIn_Click);
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
            // loginSignUp
            // 
            this.loginSignUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.loginSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginSignUp.ForeColor = System.Drawing.Color.DimGray;
            this.loginSignUp.Location = new System.Drawing.Point(475, 503);
            this.loginSignUp.Name = "loginSignUp";
            this.loginSignUp.Size = new System.Drawing.Size(113, 35);
            this.loginSignUp.TabIndex = 7;
            this.loginSignUp.Text = "SIGN UP";
            this.loginSignUp.UseVisualStyleBackColor = true;
            this.loginSignUp.Click += new System.EventHandler(this.loginSignUp_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AgricultureApp.Properties.Resources.logo3_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 641);
            this.Controls.Add(this.loginSignUp);
            this.Controls.Add(this.loginSignIn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1260, 680);
            this.MinimumSize = new System.Drawing.Size(1260, 680);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loginSignIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Button loginSignUp;
    }
}