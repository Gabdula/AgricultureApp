using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgricultureApp.Pages
{
    public partial class UsersPageADMIN : Form
    {
        PreloadPage preloadPage;
        public UsersPageADMIN(PreloadPage page)
        {
            preloadPage = page;
            InitializeComponent();
        }

        #region defaultSettings
        //Выбор между сохранить или добавить
        bool isInsert;
        Bitmap bitmap;
        byte[] imageToBase;
        bool isThereAPicture = false;
        private DataGridViewCellEventArgs e;

        //Подключение бд
        Database db = new Database();

        MySqlDataAdapter loadDataAdapter = new MySqlDataAdapter();
        MySqlDataAdapter loadPlantTitleAdapter = new MySqlDataAdapter();

        DataTable table = new DataTable();
        DataTable dt = new DataTable();
        DataSet dataSet = new DataSet();
        #endregion

        //Загрузка базы данных в dataGridView
        private void LoadData()
        {
            try
            {
                loadDataAdapter = new MySqlDataAdapter("SELECT * From users WHERE 1", db.GetConnection());
                loadDataAdapter.Fill(dataSet, "Users");

                FillCombobox();

                dataGridViewUsers.DataSource = dataSet.Tables["Users"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Отключение колонки с картинкой
            dataGridViewUsers.Columns["image"].Visible = false;
            DataGridViewUsers_CellClick(this, e);

            SetColumnsName();
            SetRoundShape();
        }
        private void SetRoundShape()
        {
            preloadPage.SetRoundedShape(dataGridViewUsers, 10);
            preloadPage.SetRoundedShape(imageuserContainer, 10);
            preloadPage.SetRoundedShape(imageUser, 10);
        }
        //Заполняем combobox
        private void FillCombobox()
        {
            table.Clear();
            //Загрузка только тех у кого нет записи в sowing
            List<string> items = new List<string>
            {
                "user",
                "worker"
            };

            roleDropdown.DataSource = items;
        }
        //Задаёт альтернативные названия для ячеек
        private void SetColumnsName()
        {
            dataGridViewUsers.Columns[0].HeaderText = "User Id";
            dataGridViewUsers.Columns[1].HeaderText = "Fullname";
            dataGridViewUsers.Columns[2].HeaderText = "Username";
            dataGridViewUsers.Columns[3].HeaderText = "Email";
            dataGridViewUsers.Columns[4].HeaderText = "Password";
            dataGridViewUsers.Columns[5].HeaderText = "Role";
        }
        //Отображение картинки (готовая картинка - bitmap)
        private void DataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var imageByteArray = new MemoryStream((byte[])dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells["image"].Value);
                bitmap = new Bitmap(System.Drawing.Image.FromStream(imageByteArray));
                imageUser.Image = bitmap;
            }
            catch (Exception)
            {
                //Если нет картинки 
                imageUser.Image = Properties.Resources.noimage;
                bitmap = Properties.Resources.noimage;
            }
        }
        //Открытие подключение к бд
        private void UsersPageADMIN_Load(object sender, EventArgs e)
        {
            db.OpenConnection();

            LoadData();

            db.CloseConnection();
        }

        //Удаление записи в таблице
        #region dataDelete
        private void RowDeletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteRow();
            }

        }
        private void DeleteRow()
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE user_id = @indexDeletedRow", db.GetConnection());
            command.Parameters.Add("@indexDeletedRow", MySqlDbType.Int32).Value =
            dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells["user_id"].Value;

            loadDataAdapter.SelectCommand = command;
            loadDataAdapter.Fill(dataSet, "Users");
            dataSet.Clear();
            LoadData();
        }
        #endregion

        #region dataInsert

        //Конвертированные данные с полей, будут записываться здесь
        //затем они будут вписываться в бд.
        string Row1; //Fullname
        string Row2; //Username
        string Row3; //Email
        string Row4; //Password
        string Row5; //Role
        byte[] Row6; //image


        private void RowAddbtn_Click(object sender, EventArgs e)
        {
            FillCombobox();
            //Переход на страницу редактирования
            tabCommands.SelectedIndex = 1;
            //Даём знак что мы добавляем запись а не редактируем
            isInsert = true;

            //Опустошаем поля
            row1.Text = string.Empty;
            row2.Text = string.Empty;
            row3.Text = string.Empty;
            row4.Text = string.Empty;

            imageuserEdit.Image = Properties.Resources.noimage;
        }

        private void ChoiseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            isThereAPicture = true;

            string filename = openFileDialog1.FileName;
            System.Drawing.Image image = System.Drawing.Image.FromFile(filename);
            imageuserEdit.Image = image;

            ImageConverter _imageConverter = new ImageConverter();
            imageToBase = (byte[])_imageConverter.ConvertTo(image, typeof(byte[]));
        }

        private void SaveNewdatabtn_Click(object sender, EventArgs e)
        {
            //Проверка на пустые поля
            if (FieldEmpty()) return;

            //Проверка на присутсвие картинки 
            if (!isThereAPicture)
                Row6 = null;
            else
                Row6 = imageToBase;

            //Проверяем правильные ли форматы введённых данных
            try
            {
                Row1 = row1.Text;
                Row2 = row2.Text;
                Row3 = row3.Text;
                Row4 = row4.Text;
                Row5 = roleDropdown.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Введённые данные имеют неверный формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Если добавляем новую запись
            if (isInsert)
            {
                if (MessageBox.Show("Добавить данные в базу данных?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InsertData("добавлена");
                }
            }
            else
            {
                if (FieldEmpty()) return;
                else if (MessageBox.Show("Изменить данные в базе данных?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteRow();
                    InsertData("изменена");
                }
            }
        }
        private void InsertData(string InsertEdit)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO users (fullname, username, email, password, role, " +
                  "image) VALUES (@fullname, @username, @email, @password, @role, @image)", db.GetConnection());

            command.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = Row1;
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = Row2;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = Row3;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = Row4;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = Row5;
            command.Parameters.Add("@image", MySqlDbType.MediumBlob).Value = Row6;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Запись успешно " + InsertEdit + ".");
            else
                MessageBox.Show("Ошибка! Запись не была создана " + InsertEdit + ".");

            db.CloseConnection();

            tabCommands.SelectedIndex = 0;

            preloadPage.Usersbtn_Click(this, e);
        }
        //Проверка на пустые поля
        private bool FieldEmpty()
        {
            if (row1.Text == string.Empty || row2.Text == string.Empty || row3.Text == string.Empty
            || row4.Text == string.Empty || string.IsNullOrEmpty(roleDropdown.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void CancelNewdata_Click(object sender, EventArgs e)
        {
            tabCommands.SelectedIndex = 0;
        }
        #endregion

        #region dataEdit
        private void RowEditbtn_Click(object sender, EventArgs e)
        {
            tabCommands.SelectedIndex = 1;
            isInsert = false;
            isThereAPicture = true;

            row1.Text = Convert.ToString(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells["fullname"].Value);
            row2.Text = Convert.ToString(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells["username"].Value);
            row3.Text = Convert.ToString(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells["email"].Value);
            row4.Text = Convert.ToString(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells["password"].Value);
            roleDropdown.SelectedItem = Convert.ToString(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells["role"].Value);
            imageuserEdit.Image = bitmap;
        }
        #endregion

        #region dataSearch
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textSearch.Text))
            {
                MessageBox.Show("Поле поиска пусто!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textSearch.Text.Contains(','))
            {
                MessageBox.Show("Недопустимый символ, Запятая, воспользуйтесь для поиска Точкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MySqlCommand command = new MySqlCommand("Select * FROM users WHERE " +
                "fullname LIKE '%" + textSearch.Text + "%' OR username LIKE '%" + textSearch.Text + "%' " +
                "OR email LIKE '%" + textSearch.Text + "%' OR password LIKE '%" +
                textSearch.Text + "%' OR role LIKE '%" + textSearch.Text + "%'", db.GetConnection());

            loadDataAdapter.SelectCommand = command;
            table = new DataTable();
            loadDataAdapter.Fill(table);
            dataGridViewUsers.DataSource = table;
        }
        private void TextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Searchbtn_Click(sender, e);
            }
        }
        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text == string.Empty)
            {
                dataGridViewUsers.DataSource = dataSet.Tables["Users"];
/*                preloadPage.Sowingbtn_Click(this, e);*/
            }
        }
        #endregion
    }
}
