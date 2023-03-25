using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AgricultureApp.Pages
{
    public partial class LoginPage : Form
    {
        PreloadPage preloadPage;
        public LoginPage(PreloadPage page)
        {
            preloadPage = page;
            InitializeComponent();

            preloadPage.OffMenu();
            pictureBox1.Image = Properties.Resources.logo3_icon;
        }

        #region Placeholders
        private void userName_Enter(object sender, EventArgs e)
        {
            if (userName.Text == "Username")
            { 
                userName.Text = string.Empty;
                userName.ForeColor = Color.DimGray;
            }
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            if (userName.Text == string.Empty)
            {
                userName.Text = "Username";
                userName.ForeColor = Color.Silver;
            }
        }

        private void userPassword_Enter(object sender, EventArgs e)
        {
            if (userPassword.Text == "Password")
            {
                userPassword.Text = string.Empty;
                userPassword.ForeColor = Color.DimGray;
            }
        }

        private void userPassword_Leave(object sender, EventArgs e)
        {
            if (userPassword.Text == string.Empty)
            {
                userPassword.Text = "Password";
                userPassword.ForeColor = Color.Silver;
            }
        }

        #endregion

        private void loginSignUp_Click(object sender, EventArgs e)
        {
            preloadPage.GotoRegestrationPage();
        }

        private void loginSignIn_Click(object sender, EventArgs e)
        {
            string loginUser = userName.Text;
            string passUser = userPassword.Text;

            Database db = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `users` WHERE `username` = @userlogin OR `email` = @userlogin AND `password` = @userpassword", db.GetConnection());
            command.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@userpassword", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            string login;
            string pass;
            string email;

            Bitmap bitmap;
            try
            {
                login = Convert.ToString(table.Rows[0][2]);
                pass = Convert.ToString(table.Rows[0][4]);
                email = Convert.ToString(table.Rows[0][3]);

                //Выгрузка изображения из бд
                var temp = new MemoryStream((byte[])table.Rows[0][6]);
                bitmap = new Bitmap(System.Drawing.Image.FromStream(temp));
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильный Логин / Пароль или аккаунта не существует.");
                return;
            }

            if (login == loginUser || email == loginUser  && pass == passUser)
            { 
                string role = Convert.ToString(table.Rows[0][5]);
                preloadPage.SetInfoUser(role, login, bitmap);
                preloadPage.OnMenu();
                preloadPage.GotoApp();
            }

            else 
                MessageBox.Show("Неправильный Логин / Пароль или аккаунта не существует.");
        }
    }
}
