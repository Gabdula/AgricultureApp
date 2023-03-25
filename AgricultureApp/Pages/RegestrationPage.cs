using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgricultureApp.Pages
{
    public partial class RegestrationPage : Form
    {
        PreloadPage preloadPage;
        public RegestrationPage(PreloadPage page)
        {
            preloadPage = page;
            InitializeComponent();
        }

        #region Placeholders
        private void userFullname_Enter(object sender, EventArgs e)
        {
            if (userFullname.Text == "Full Name")
            {
                userFullname.Text = string.Empty;
                userFullname.ForeColor = Color.DimGray;
            }
        }

        private void userFullname_Leave(object sender, EventArgs e)
        {
            if (userFullname.Text == string.Empty)
            {
                userFullname.Text = "Full Name";
                userFullname.ForeColor = Color.Silver;
            }
        }

        private void userEmail_Enter(object sender, EventArgs e)
        {
            if (userEmail.Text == "Email Adress")
            {
                userEmail.Text = string.Empty;
                userEmail.ForeColor = Color.DimGray;
            }
        }

        private void userEmail_Leave(object sender, EventArgs e)
        {
            if (userEmail.Text == string.Empty)
            {
                userEmail.Text = "Email Adress";
                userEmail.ForeColor = Color.Silver;
            }
        }

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

        private void regSignIn_Click(object sender, EventArgs e)
        {
            preloadPage.GotoLoginpage();
        }

        private void regSignUp_Click(object sender, EventArgs e)
        {
            if (IsFieldEmpty()) return;
            if (IsUserRepeat()) return;

            Database db = new Database();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`fullname`, `username`, `email`, `password`, `role`) VALUES (@fullname, @username, @email, @password, @role)", db.GetConnection());
            
            command.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = userFullname.Text;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = userName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userEmail.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = userPassword.Text;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = "user";

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт успешно создан.");
            else
                MessageBox.Show("Ошибка! Аккаунт не был создан.");

            db.CloseConnection();

            preloadPage.GotoLoginpage();
        }

        #region FieldValidation
        public bool IsFieldEmpty()
        {
            if (userFullname.Text == "Full Name" || userFullname.Text == string.Empty)
            {
                userFullname.ForeColor = Color.IndianRed;
                return true;
            }

            if (userName.Text == "Username" || userName.Text == string.Empty)
            {
                userName.ForeColor = Color.IndianRed;
                return true;
            }

            if (userEmail.Text == "Email Adress" || userEmail.Text == string.Empty)
            {
                userEmail.ForeColor = Color.IndianRed;
                return true;
            }

            if (userPassword.Text == "Password" || userPassword.Text == string.Empty)
            {
                userPassword.ForeColor = Color.IndianRed;
                return true;
            }

            return false;
        }

        public bool IsUserRepeat()
        {
            Database db = new Database();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand checkUsername = new MySqlCommand($"SELECT * FROM `users` WHERE `username` = @userlogin", db.GetConnection());
            checkUsername.Parameters.Add("@userlogin", MySqlDbType.VarChar).Value = userName.Text;
            adapter.SelectCommand = checkUsername;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин " + userName.Text + " уже используется.");
                return true;
            }

            MySqlCommand checkEmail = new MySqlCommand($"SELECT * FROM `users` WHERE `email` = @email", db.GetConnection());
            checkEmail.Parameters.Add("@email", MySqlDbType.VarChar).Value = userEmail.Text;
            adapter.SelectCommand = checkEmail;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Почта " + userEmail.Text + " уже используется.");
                return true;
            }

            return false;
        }
        #endregion
    }
}
