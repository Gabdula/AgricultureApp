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
    public partial class GroundPageADMIN : Form
    {
        PreloadPage preloadPage;
        public GroundPageADMIN(PreloadPage page)
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
                adapter = new MySqlDataAdapter("SELECT * FROM `grounds`", db.GetConnection());
                builder = new MySqlCommandBuilder(adapter);

                builder.GetInsertCommand();
                builder.GetUpdateCommand();
                builder.GetDeleteCommand();

                adapter.Fill(dataSet, "Grounds");

                dataGridView1.DataSource = dataSet.Tables["Grounds"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            preloadPage.SetRoundedShape(dataGridView1, 10);
            preloadPage.SetRoundedShape(numberGroundContainer, 10);
            preloadPage.SetRoundedShape(numberGroundPanel, 10);
            preloadPage.SetRoundedShape(landAreaContainer, 10);
            preloadPage.SetRoundedShape(landAreaPanel, 10);

            dataGridView1.Columns[0].HeaderText = "Ground Id";
            dataGridView1.Columns[1].HeaderText = "Ground Number (№)";
            dataGridView1.Columns[2].HeaderText = "Land Area (ha)";
        }
        private void UpdateData()
        {
            try
            {
                dataSet.Tables["Grounds"].Clear();

                adapter.Fill(dataSet, "Grounds");

                dataGridView1.DataSource = dataSet.Tables["Grounds"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GroundPageADMIN_Load(object sender, EventArgs e)
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
                MySqlCommand command = new MySqlCommand("DELETE FROM grounds WHERE grounds_id = @indexDeletedRow", db.GetConnection());
                command.Parameters.Add("@indexDeletedRow", MySqlDbType.Int32).Value = 
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["grounds_id"].Value;

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Grounds");
                dataSet.Clear();
                LoadData();
            }
            
        }
        #endregion

        #region dataInsert
        int Row1; //Number Ground
        float Row2; //Land area

        private void RowAddbtn_Click(object sender, EventArgs e)
        {
            tabCommands.SelectedIndex = 1;
            isInsert = true;
            row1.Text = string.Empty;
            row2.Text = string.Empty;
        }

        private void SaveNewdatabtn_Click(object sender, EventArgs e)
        {
            if (row1.Text == string.Empty || row2.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Row1 = Convert.ToInt32(row1.Text);
                Row2 = Convert.ToSingle(row2.Text, System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
            catch (Exception)
            {
                MessageBox.Show("Введённые данные имеют неверный формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isInsert)
            {
                if (MessageBox.Show("Добавить данные в базу данных?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.Rows.Count - 2;
                    DataRow row = dataSet.Tables["Grounds"].NewRow();

                    row["number_grounds"] = Row1;
                    row["land_area"] = Row2;

                    dataSet.Tables["Grounds"].Rows.Add(row);

                    adapter.Update(dataSet, "Grounds");

                    tabCommands.SelectedIndex = 0;

                    UpdateData();
                }
            }
            else
            {
                if (MessageBox.Show("Изменить данные в базе данных?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE grounds SET number_grounds = @numberGroundEdit, land_area = @landAreaEditing WHERE grounds_id = @indexDeletedRow", db.GetConnection());
                    command.Parameters.Add("@numberGroundEdit", MySqlDbType.Int32).Value = Row1;
                    command.Parameters.Add("@landAreaEditing", MySqlDbType.Float).Value = Row2;
                    command.Parameters.Add("@indexDeletedRow", MySqlDbType.Int32).Value =
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["grounds_id"].Value;

                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "Grounds");
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

            row1.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["number_grounds"].Value,
                System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            row2.Text = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["land_area"].Value,
                System.Globalization.CultureInfo.GetCultureInfo("en-US"));
        }
        #endregion

        #region dataSearch
        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (textSearch.Text == string.Empty)
            {
                MessageBox.Show("Поле поиска пусто!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textSearch.Text.Contains(','))
            {
                MessageBox.Show("Недопустимый символ, Запятая, воспользуйтесь для поиска Точкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MySqlCommand command = new MySqlCommand("Select * FROM grounds WHERE grounds_id LIKE " + textSearch.Text + " OR number_grounds LIKE " + textSearch.Text + " OR land_area LIKE " + textSearch.Text + "", db.GetConnection());

            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
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
                MySqlCommand command = new MySqlCommand("Select * FROM grounds", db.GetConnection());

                adapter.SelectCommand = command;
                table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        #endregion
    }
}
