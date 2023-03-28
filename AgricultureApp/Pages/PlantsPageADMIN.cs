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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgricultureApp.Pages
{
    public partial class PlantsPageADMIN : Form
    {
        PreloadPage preloadPage;
        public PlantsPageADMIN(PreloadPage page)
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
        private DataGridViewCellEventArgs e;
        Bitmap bitmap;
        byte[] imageToBase;
        bool isThereAPicture = false;

        private void LoadData()
        {
            try
            {
                adapter = new MySqlDataAdapter("SELECT * FROM `plants`", db.GetConnection());
                builder = new MySqlCommandBuilder(adapter);

                builder.GetInsertCommand();
                builder.GetUpdateCommand();
                builder.GetDeleteCommand();

                adapter.Fill(dataSet, "Plants");

                dataGridViewPlants.DataSource = dataSet.Tables["Plants"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #region SetRoundedShape
            preloadPage.SetRoundedShape(imageplantContainer ,10);
            preloadPage.SetRoundedShape(imagePlant, 10);
            preloadPage.SetRoundedShape(dataGridViewPlants, 10);
            preloadPage.SetRoundedShape(titleplantContainer, 10);
            preloadPage.SetRoundedShape(titleplantPanel, 10);
            preloadPage.SetRoundedShape(growingtimeContainer, 10);
            preloadPage.SetRoundedShape(growingtimePanel, 10);
            preloadPage.SetRoundedShape(yieldplantContainer, 10);
            preloadPage.SetRoundedShape(yieldplantPanel, 10);
            preloadPage.SetRoundedShape(typeplantContainer, 10);
            preloadPage.SetRoundedShape(typeplantPanel, 10);
            preloadPage.SetRoundedShape(imageContainer, 10);
            preloadPage.SetRoundedShape(imageplantPanel, 10);
            #endregion

            dataGridViewPlants.Columns[0].HeaderText = "Plant Id";
            dataGridViewPlants.Columns[1].HeaderText = "Title plant";
            dataGridViewPlants.Columns[2].HeaderText = "Type plant";
            dataGridViewPlants.Columns[3].HeaderText = "Growing time (days)";
            dataGridViewPlants.Columns[4].HeaderText = "Yield plant";
            dataGridViewPlants.Columns[5].HeaderText = "Image plant";

            dataGridViewPlants.Columns["image_plant"].Visible= false;
            DataGridViewPlants_CellClick(this, e);
        }
        private void DataGridViewPlants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var imageByteArray = new MemoryStream((byte[])dataGridViewPlants.Rows[dataGridViewPlants.CurrentCell.RowIndex].Cells["image_plant"].Value);
                bitmap = new Bitmap(System.Drawing.Image.FromStream(imageByteArray));
                imagePlant.Image = bitmap;
            }
            catch (Exception)
            {
                imagePlant.Image = Properties.Resources.noimage;
            }
            plant.Text = Convert.ToString(dataGridViewPlants.Rows[dataGridViewPlants.CurrentCell.RowIndex].Cells["title_plant"].Value);
        }

        private void PlantsPageADMIN_Load(object sender, EventArgs e)
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
                MySqlCommand command = new MySqlCommand("DELETE FROM plants WHERE plant_id = @indexDeletedRow", db.GetConnection());
                command.Parameters.Add("@indexDeletedRow", MySqlDbType.Int32).Value =
                    dataGridViewPlants.Rows[dataGridViewPlants.CurrentCell.RowIndex].Cells["plant_id"].Value;

                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "Plants");
                dataSet.Clear();
                LoadData();
            }

        }
        #endregion

        #region dataInsert
        string Row1; //Title plant
        string Row2; //Type plant
        string Row3; //Growing time
        int Row4; //Yield plant
        byte[] Row5; //Image plant

        private void RowAddbtn_Click(object sender, EventArgs e)
        {
            tabCommands.SelectedIndex = 1;
            isInsert = true;
            row1.Text = string.Empty;
            row2.Text = string.Empty;
            row3.Text = string.Empty;
            row4.Text = string.Empty;

            imagePlant.Image = Properties.Resources.noimage;
        }

        private void ChoiseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            isThereAPicture = true;

            string filename = openFileDialog1.FileName;
            System.Drawing.Image image = System.Drawing.Image.FromFile(filename);
            plantimageEdit.Image = image;

            ImageConverter _imageConverter = new ImageConverter();
            imageToBase = (byte[])_imageConverter.ConvertTo(image, typeof(byte[]));
        }

        private void SaveNewdatabtn_Click(object sender, EventArgs e)
        {
            if (row1.Text == string.Empty || row2.Text == string.Empty || row3.Text == string.Empty
                || row4.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!isThereAPicture)
                Row5 = null;
            else
                Row5 = imageToBase;

            try
            {
                Row1 = row1.Text;
                Row2 = row2.Text;
                Row3 = row3.Text;
                Row4 = Convert.ToInt32(row4.Text);
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
                    int rowIndex = dataGridViewPlants.Rows.Count - 2;
                    DataRow row = dataSet.Tables["Plants"].NewRow();

                    row["title_plant"] = Row1;
                    row["type_plant"] = Row2;
                    row["growing_time"] = Row3;
                    row["yield_plant"] = Row4;
                    row["image_plant"] = Row5;

                    dataSet.Tables["Plants"].Rows.Add(row);
                    adapter.Update(dataSet, "Plants");
                    tabCommands.SelectedIndex = 0;

                    preloadPage.Plantsbtn_Click(this, e);
                }
            }
            else
            {
                if (MessageBox.Show("Изменить данные в базе данных?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE plants SET title_plant = @titleplantEdit, type_plant = @typeplantEdit," +
                        "growing_time = @growingtimeEdit, yield_plant = @yieldplantEdit, image_plant = @imageplantEdit " +
                        "WHERE plant_id = @indexEditingRow", db.GetConnection());

                    command.Parameters.Add("@titleplantEdit", MySqlDbType.VarChar).Value = Row1;
                    command.Parameters.Add("@typeplantEdit", MySqlDbType.VarChar).Value = Row2;
                    command.Parameters.Add("@growingtimeEdit", MySqlDbType.VarChar).Value = Row3;
                    command.Parameters.Add("@yieldplantEdit", MySqlDbType.Int32).Value = Row4;
                    command.Parameters.Add("@imageplantEdit", MySqlDbType.MediumBlob).Value = Row5;

                    command.Parameters.Add("@indexEditingRow", MySqlDbType.Int32).Value =
                    Convert.ToInt32(dataGridViewPlants.Rows[dataGridViewPlants.CurrentCell.RowIndex].Cells["plant_id"].Value);

                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "Plants");
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

            row1.Text = Convert.ToString(dataGridViewPlants.Rows[dataGridViewPlants.CurrentCell.RowIndex].Cells["title_plant"].Value);
            row2.Text = Convert.ToString(dataGridViewPlants.Rows[dataGridViewPlants.CurrentCell.RowIndex].Cells["type_plant"].Value);
            row3.Text = Convert.ToString(dataGridViewPlants.Rows[dataGridViewPlants.CurrentCell.RowIndex].Cells["growing_time"].Value);
            row4.Text = Convert.ToString(dataGridViewPlants.Rows[dataGridViewPlants.CurrentCell.RowIndex].Cells["yield_plant"].Value);
            plantimageEdit.Image = bitmap;
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
            MySqlCommand command = new MySqlCommand("Select * FROM plants WHERE plant_id LIKE '%" + textSearch.Text +
                "%' OR title_plant LIKE '%" + textSearch.Text + "%' OR type_plant LIKE '%" + textSearch.Text + "%' OR growing_time LIKE '%" +
                textSearch.Text + "%' OR yield_plant LIKE '%" + textSearch.Text + "%'", db.GetConnection());

            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            dataGridViewPlants.DataSource = table;
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
                MySqlCommand command = new MySqlCommand("Select * FROM plants", db.GetConnection());

                adapter.SelectCommand = command;
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewPlants.DataSource = table;
            }
        }
        #endregion
    }
}
