using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AgricultureApp.Pages
{
    public partial class SowingPageADMIN : Form
    {
        PreloadPage preloadPage;
        public SowingPageADMIN(PreloadPage page)
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
        DataSet dataSet = new DataSet();
        #endregion


        //Загрузка базы данных в dataGridView
        private void LoadData()
        {
            try
            {
                loadDataAdapter = new MySqlDataAdapter("SELECT sowing_id, plants.title_plant, seed_source, sowing_date, seeds_count, " +
                    "pest_control, harvesting, yield_plant, plants.image_plant, plants.plant_id " +
                    "FROM sowing JOIN plants ON sowing.plant_id = plants.plant_id WHERE 1", db.GetConnection());
                loadDataAdapter.Fill(dataSet, "Sowing");

                FillCombobox();

                dataGridViewSowing.DataSource = dataSet.Tables["Sowing"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Отключение колонки с картинкой
            dataGridViewSowing.Columns["image_plant"].Visible = false;
            DataGridViewSowing_CellClick(this, e);

            //отключение колонки с id растения
            dataGridViewSowing.Columns["plant_id"].Visible = false;

            SetColumnsName();
        }
        //Заполняем combobox
        private void FillCombobox()
        {
            table.Clear();
            //Загрузка только тех у кого нет записи в sowing
            loadPlantTitleAdapter = new MySqlDataAdapter("select title_plant, plant_id from plants where plant_id not in (select plant_id from sowing )", db.GetConnection());
            loadPlantTitleAdapter.Fill(table);

            plantidDropdown.DataSource = table;
            plantidDropdown.DisplayMember = "title_plant";
        }
        //Задаёт альтернативные названия для ячеек
        private void SetColumnsName()
        {
            dataGridViewSowing.Columns[0].HeaderText = "Sowing Id";
            dataGridViewSowing.Columns[1].HeaderText = "Title plant";
            dataGridViewSowing.Columns[2].HeaderText = "Seed source";
            dataGridViewSowing.Columns[3].HeaderText = "Sowing date";
            dataGridViewSowing.Columns[4].HeaderText = "Seeds count";
            dataGridViewSowing.Columns[5].HeaderText = "Pest control";
            dataGridViewSowing.Columns[6].HeaderText = "Harvesting date";
            dataGridViewSowing.Columns[7].HeaderText = "Yield plant";
        }
        //Отображение картинки (готовая картинка - bitmap)
        private void DataGridViewSowing_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var imageByteArray = new MemoryStream((byte[])dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["image_plant"].Value);
                bitmap = new Bitmap(System.Drawing.Image.FromStream(imageByteArray));
                imagePlant.Image = bitmap;
            }
            catch (Exception)
            {
                //Если нет картинки 
                imagePlant.Image = Properties.Resources.noimage;
            }
            //Название над картинкой
            plant.Text = Convert.ToString(dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["title_plant"].Value);
            /*MessageBox.Show();*/
        }
        //Открытие подключение к бд
        private void SowingPageADMIN_Load(object sender, EventArgs e)
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
                MySqlCommand command = new MySqlCommand("DELETE FROM sowing WHERE sowing_id = @indexDeletedRow", db.GetConnection());
                command.Parameters.Add("@indexDeletedRow", MySqlDbType.Int32).Value =
                    dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["sowing_id"].Value;

                loadDataAdapter.SelectCommand = command;
                loadDataAdapter.Fill(dataSet, "Sowing");
                dataSet.Clear();
                LoadData();
            }

        }
        #endregion

        #region dataInsert

        //Конвертированные данные с полей, будут записываться здесь
        //затем они будут вписываться в бд.
        string Row1; //Seed source
        DateTime Row2; //Sowing date
        int Row3; //Seeds count
        byte Row4; //Pest control
        DateTime Row5; //Harvesting date
        int Row6; //Plant id


        private void RowAddbtn_Click(object sender, EventArgs e)
        {
            FillCombobox();
            //Переход на страницу редактирования
            tabCommands.SelectedIndex = 1;
            //Даём знак что мы добавляем запись а не редактируем
            isInsert = true;

            //Опустошаем поля
            row1.Text = string.Empty;
            sowingdateDate.Text = string.Empty;
            row3.Text = string.Empty;
            pestcontrolCheck.Checked = false;
            harvestingdate.Text = string.Empty;
        }
        //При выборе в dropdown записываем id выбранного растения в Row6
        private void PlantidDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Row6 = Convert.ToInt32(table.Rows[plantidDropdown.SelectedIndex][1]);
        }
        private void SaveNewdatabtn_Click(object sender, EventArgs e)
        {
            //Проверка на пустые поля
            if (FieldEmpty()) return;

            //Проверка дат
            if (sowingdateDate.Value > harvestingdateDate.Value)
            {
                MessageBox.Show("Дата посадки не может быть позже чем дата сбора!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Проверяем правильные ли форматы введённых данных
            try
            {
                Row1 = row1.Text;
                Row2 = sowingdateDate.Value;
                Row3 = Convert.ToInt32(row3.Text);
                Row4 = Convert.ToByte(pestcontrolCheck.Checked);
                Row5 = harvestingdateDate.Value;
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
                    MySqlCommand command = new MySqlCommand("INSERT INTO sowing (plant_id, seed_source, sowing_date, seeds_count, pest_control, " +
                    "harvesting) VALUES (@plantid, @seedsurce, @sowingdate, @seedscount, @pestcontrol, @harvesting)", db.GetConnection());

                    command.Parameters.Add("@plantid", MySqlDbType.Int32).Value = Row6;
                    command.Parameters.Add("@seedsurce", MySqlDbType.VarChar).Value = Row1;
                    command.Parameters.Add("@sowingdate", MySqlDbType.DateTime).Value = Row2;
                    command.Parameters.Add("@seedscount", MySqlDbType.Int32).Value = Row3;
                    command.Parameters.Add("@pestcontrol", MySqlDbType.Byte).Value = Row4;
                    command.Parameters.Add("@harvesting", MySqlDbType.DateTime).Value = Row5;

                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно добавлена.");
                    else
                        MessageBox.Show("Ошибка! Запись не была создана.");

                    db.CloseConnection();

                    tabCommands.SelectedIndex = 0;

                    preloadPage.Sowingbtn_Click(this, e);
                }
            }
            else
            {
                if (FieldEmpty()) return;
                else if (MessageBox.Show("Изменить данные в базе данных?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand commandDeleted = new MySqlCommand("DELETE FROM sowing WHERE sowing_id = @indexDeletedRow", db.GetConnection());
                    commandDeleted.Parameters.Add("@indexDeletedRow", MySqlDbType.Int32).Value =
                        dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["sowing_id"].Value;

                    loadDataAdapter.SelectCommand = commandDeleted;
                    loadDataAdapter.Fill(dataSet, "Sowing");
                    dataSet.Clear();
                    LoadData();

                    MySqlCommand command = new MySqlCommand("INSERT INTO sowing (plant_id, seed_source, sowing_date, seeds_count, pest_control, " +
                    "harvesting) VALUES (@plantidEdit, @seedsourceEdit, @sowingdateEdit, @seedscountEdit, @pestcontrolEdit, @harvestingEdit)", db.GetConnection());
                    //TODO: Убрать повторение кода
                    command.Parameters.Add("@plantidEdit", MySqlDbType.Int32).Value = Row6;
                    command.Parameters.Add("@seedsourceEdit", MySqlDbType.VarChar).Value = Row1;
                    command.Parameters.Add("@sowingdateEdit", MySqlDbType.DateTime).Value = Row2;
                    command.Parameters.Add("@seedscountEdit", MySqlDbType.Int32).Value = Row3;
                    command.Parameters.Add("@pestcontrolEdit", MySqlDbType.Byte).Value = Row4;
                    command.Parameters.Add("@harvestingEdit", MySqlDbType.DateTime).Value = Row5;

                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно изменена.");
                    else
                        MessageBox.Show("Ошибка! Запись не была изменена.");

                    db.CloseConnection();

                    tabCommands.SelectedIndex = 0;

                    preloadPage.Sowingbtn_Click(this, e);
                }
            }
        }
        //Проверка на пустые поля
        private bool FieldEmpty()
        {
            if (row1.Text == string.Empty || sowingdateDate.Value == null || row3.Text == string.Empty
                || harvestingdateDate.Value == null || string.IsNullOrEmpty(plantidDropdown.Text))
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

            //Чтобы определить выбраное растения уже созданной посевной, создадим sql запрос, с существующими
            GetExistingSowing();

            row1.Text = Convert.ToString(dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["seed_source"].Value);
            sowingdateDate.Value = Convert.ToDateTime(dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["sowing_date"].Value);
            row3.Text = Convert.ToString(dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["seeds_count"].Value);
            pestcontrolCheck.Checked = Convert.ToBoolean(dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["pest_control"].Value);
            harvestingdateDate.Value = Convert.ToDateTime(dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["harvesting"].Value);
        }

        private void GetExistingSowing()
        {
            FillCombobox();
            //title plant по нажатой ячейке
            MySqlDataAdapter getExistingSowing = new MySqlDataAdapter("select title_plant, plant_id from plants where plant_id = " + Convert.ToInt32(dataGridViewSowing.Rows[dataGridViewSowing.CurrentCell.RowIndex].Cells["plant_id"].Value), db.GetConnection());
            getExistingSowing.Fill(table);
            /*table.Rows.Add(getExistingSowing);*/

            //Заполняем combobox c другими данными 
            plantidDropdown.DataSource = table;
            plantidDropdown.DisplayMember = "title_plant";
        }
        #endregion

        /*#region dataSearch
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
        #endregion*/
    }
}
