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

namespace AgricultureApp.Pages
{
    public partial class WorkersPageADMIN : Form
    {
        PreloadPage preloadPage;
        public WorkersPageADMIN(PreloadPage page)
        {
            preloadPage = page;
            InitializeComponent();
        }

        bool isInsert;

        Database db = new Database();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable table = new DataTable();
        MySqlCommandBuilder builder = new MySqlCommandBuilder();
        DataSet dataSet = new DataSet();

        private void LoadData()
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM `workers`", db.GetConnection());
                builder = new MySqlCommandBuilder(adapter);

                builder.GetInsertCommand();
                builder.GetUpdateCommand();
                builder.GetDeleteCommand();

                adapter.Fill(dataSet, "Workers");

                dataGridViewWorker.DataSource = dataSet.Tables["Workers"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            preloadPage.SetRoundedShape(dataGridViewWorker, 10);
            preloadPage.SetRoundedShape(nameContainer, 10);
            preloadPage.SetRoundedShape(namePanel, 10);
            preloadPage.SetRoundedShape(surnameContainer, 10);
            preloadPage.SetRoundedShape(surnamePanel, 10);

            dataGridViewWorker.Columns[0].HeaderText = "Worker Id";
            dataGridViewWorker.Columns[1].HeaderText = "Name";
            dataGridViewWorker.Columns[2].HeaderText = "Surname";
            dataGridViewWorker.Columns[3].HeaderText = "Fathername";
            dataGridViewWorker.Columns[4].HeaderText = "Age";
            dataGridViewWorker.Columns[5].HeaderText = "Experience (years)";
            dataGridViewWorker.Columns[6].HeaderText = "Job title";
            dataGridViewWorker.Columns[7].HeaderText = "Salary (rub)";
            dataGridViewWorker.Columns[8].HeaderText = "Ground Id";
        }
        private void UpdateData()
        {
            try
            {
                dataSet.Tables["Workers"].Clear();

                adapter.Fill(dataSet, "Workers");

                dataGridViewWorker.DataSource = dataSet.Tables["Workers"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void WorkersPageADMIN_Load(object sender, EventArgs e)
        {
            db.OpenConnection();

            LoadData();

            db.CloseConnection();
        }

        #region dataDelete
        private void RowDeletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM workers WHERE worker_id = @indexDeletedRow", db.GetConnection());
                command.Parameters.Add("@indexDeletedRow", MySqlDbType.Int32).Value =
                    dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["worker_id"].Value;

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Workers");
                dataSet.Clear();
                LoadData();
            }

        }
        #endregion

        #region dataInsert
        string Row1; //Name
        string Row2; //Surname
        string Row3; //Fathername
        int Row4; //Age
        int Row5; //Experience
        string Row6; //Job title
        float Row7; //Salary
        int Row8; //Ground id

        private void RowAddbtn_Click(object sender, EventArgs e)
        {
            tabCommands.SelectedIndex = 1;
            isInsert = true;
            row1.Text = string.Empty;
            row2.Text = string.Empty;
            row3.Text = string.Empty;
            row4.Text = string.Empty;
            row5.Text = string.Empty;
            row6.Text = string.Empty;
            row7.Text = string.Empty;
            row8.Text = string.Empty;
        }

        private void SaveNewdatabtn_Click(object sender, EventArgs e)
        {
            if (row1.Text == string.Empty || row2.Text == string.Empty || row3.Text == string.Empty 
                || row4.Text == string.Empty || row5.Text == string.Empty || row6.Text == string.Empty 
                || row7.Text == string.Empty || row8.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Row1 = row1.Text;
                Row2 = row2.Text;
                Row3 = row3.Text;
                Row4 = Convert.ToInt32(row4.Text);
                Row5 = Convert.ToInt32(row5.Text);
                Row6 = row6.Text;
                Row7 = Convert.ToSingle(row7.Text, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                Row8 = Convert.ToInt32(row8.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введённые данные имеют неверный формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Проверка на существование поля
            DataTable checkIndex = new DataTable();
            MySqlCommand checkRow = new MySqlCommand("SELECT * FROM grounds WHERE grounds_id LIKE "+ Row8 +"", db.GetConnection());
            adapter.SelectCommand = checkRow;
            adapter.Fill(checkIndex);
            if (checkIndex.Rows.Count == 0)
            {
                MessageBox.Show("Нельзя создать запись, сели работник ссылаеться на несуществующее поле! Пожалуйста введите индекс существуещего поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isInsert)
            {
                if (MessageBox.Show("Добавить данные в базу данных?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = dataGridViewWorker.Rows.Count - 2;
                    DataRow row = dataSet.Tables["Workers"].NewRow();

                    row["name"] = Row1;
                    row["surname"] = Row2;
                    row["fathername"] = Row3;
                    row["age"] = Row4;
                    row["experience"] = Row5;
                    row["job_title"] = Row6;
                    row["salary"] = Row7;
                    row["ground_id"] = Row8;

                    dataSet.Tables["Workers"].Rows.Add(row);
                    adapter.Update(dataSet, "Workers");
                    tabCommands.SelectedIndex = 0;

                    preloadPage.Workersbtn_Click(this, e);
                }
            }
            else
            {
                if (MessageBox.Show("Изменить данные в базе данных?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE workers SET name = @nameEdit, surname = @surnameEdit," +
                        "fathername = @fathernameEdit, age = @ageEdit, experience = @experienceEdit, job_title = @jobTitleEdit," +
                        "salary = @salaryEdit, ground_id = @groundIdEdit WHERE worker_id = @indexEditingRow", db.GetConnection());

                    command.Parameters.Add("@nameEdit", MySqlDbType.VarChar).Value = Row1;
                    command.Parameters.Add("@surnameEdit", MySqlDbType.VarChar).Value = Row2;
                    command.Parameters.Add("@fathernameEdit", MySqlDbType.VarChar).Value = Row3;
                    command.Parameters.Add("@ageEdit", MySqlDbType.Int32).Value = Row4;
                    command.Parameters.Add("@experienceEdit", MySqlDbType.Int32).Value = Row5;
                    command.Parameters.Add("@jobTitleEdit", MySqlDbType.VarChar).Value = Row6;
                    command.Parameters.Add("@salaryEdit", MySqlDbType.Float).Value = Row7;
                    command.Parameters.Add("@groundIdEdit", MySqlDbType.Int32).Value = Row8;

                    command.Parameters.Add("@indexEditingRow", MySqlDbType.Int32).Value =
                    Convert.ToInt32(dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["worker_id"].Value);


                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "Workers");
                    dataSet.Clear();
                    LoadData();
                    tabCommands.SelectedIndex = 0;
                }
            }
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

            row1.Text = Convert.ToString(dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["name"].Value);
            row2.Text = Convert.ToString(dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["surname"].Value);
            row3.Text = Convert.ToString(dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["fathername"].Value);
            row4.Text = Convert.ToString(dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["age"].Value);
            row5.Text = Convert.ToString(dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["experience"].Value);
            row6.Text = Convert.ToString(dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["job_title"].Value);
            row7.Text = Convert.ToString(dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["salary"].Value,
                System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            row8.Text = Convert.ToString(dataGridViewWorker.Rows[dataGridViewWorker.CurrentCell.RowIndex].Cells["ground_id"].Value);
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
            MySqlCommand command = new MySqlCommand("Select * FROM workers WHERE worker_id LIKE '%" + textSearch.Text +
                "%' OR name LIKE '%" + textSearch.Text + "%' OR surname LIKE '%" + textSearch.Text + "%' OR fathername LIKE '%" +
                textSearch.Text + "%' OR age LIKE '%" + textSearch.Text + "%' OR experience LIKE '%" + textSearch.Text +
                "%' OR job_title LIKE '%" + textSearch.Text + "%' OR salary LIKE '%" + textSearch.Text + "%' OR ground_id LIKE '%" +
                textSearch.Text + "%'", db.GetConnection());

            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewWorker.DataSource = table;
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
                MySqlCommand command = new MySqlCommand("Select * FROM workers", db.GetConnection());

                adapter.SelectCommand = command;
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewWorker.DataSource = table;
            }
        }
        #endregion
    }
}
