using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using TravelAgency.Tables;

namespace TravelAgency.Forms
{
    public partial class TourForm : Form
    {
        int originalHeight;
        public TourForm()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TourForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            City.GetCity();
            city_add.DataSource = City.dtCity.Copy();
            city_add.DisplayMember = "Название";
            city_edit.DataSource = City.dtCity.Copy();
            city_edit.DisplayMember = "Название";
            Hotel.GetHotel();
            //hotel_add.DataSource = Hotel.dtHotel.Copy();
            //hotel_add.DisplayMember = "Название";
            //hotel_edit.DataSource = Hotel.dtHotel.Copy();
            //hotel_edit.DisplayMember = "Название";

            date_add.CustomFormat = "yyyy-MM-dd";
            date_edit.CustomFormat = "yyyy-MM-dd";
            Tour.GetTour();
            tours.DataSource = Tour.dtTour;

            originalHeight = this.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Height == originalHeight)
            {
                this.Height = groupBox1.Height + originalHeight + 40;
            }
            else
            {
                this.Height -= groupBox1.Height + 40;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            clear_btn(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Height == originalHeight)
            {
                this.Height = groupBox2.Height + originalHeight + 40;
            }
            else
            {
                this.Height -= groupBox2.Height + 40;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            clear_edit_Click(sender, e);
        }

        private void canceladditbtn_Click(object sender, EventArgs e)
        {
            if (this.Height == originalHeight)
            {
                this.Height = groupBox1.Height + originalHeight + 40;
            }
            else
            {
                this.Height -= groupBox1.Height + 40;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            clear_btn(sender, e);
        }

        private void canceleditbtn_Click(object sender, EventArgs e)
        {
            if (this.Height == originalHeight)
            {
                this.Height = groupBox2.Height + originalHeight + 40;
            }
            else
            {
                this.Height -= groupBox2.Height + 40;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            clear_edit_Click(sender, e);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (name_add.Text != "" &&
                city_add.Text != "" &&
                hotel_add.Text != "" &&
                accomodation_add.Text != "" &&
                meal_add.Text != "" &&
                duration_add.Text != "" &&
                cost_add.Text != "")
            {
                string query = $"SELECT id FROM Tour WHERE " +
                    $"name = \"{name_add.Text}\" AND " +
                    $"city_id = (SELECT city.id FROM city WHERE city.name = \"{city_add.Text}\") AND " +
                    $"hotel_id = (SELECT hotel.id FROM hotel WHERE hotel.name = \"{hotel_add.Text}\") AND " +
                    $"accomodation = \"{accomodation_add.Text}\" AND " +
                    $"meal = \"{meal_add.Text}\" AND " +
                    $"date_start = \"{date_add.Value.Date.ToString("yyyy-MM-dd")}\" AND " +
                    $"duration = \"{duration_add.Text}\" AND " +
                    $"cost = \"{cost_add.Text}\";";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой тур уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_btn(sender, e);
                }
                else
                {
                    if (Tour.AddTour(name_add.Text, city_add.Text, hotel_add.Text, accomodation_add.Text, meal_add.Text,
                        date_add.Value.Date.ToString("yyyy-MM-dd"), duration_add.Text, cost_add.Text))
                    {
                        MessageBox.Show("Тур добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear_btn(sender, e);
                        Tour.GetTour();
                    }
                    else
                    {
                        MessageBox.Show("Тур не был добавлен!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность заполнения полей!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPanel mp = new MainPanel();
            mp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tours.SelectedRows.Count > 0)
            {
                string name, city, hotel, accomodation,
                meal, date_start, duration, cost;
                var res = false;
                foreach (DataGridViewRow row in tours.SelectedRows)
                {
                    name = row.Cells["Название"].Value.ToString();
                    city = row.Cells["Город"].Value.ToString();
                    hotel = row.Cells["Отель"].Value.ToString();
                    accomodation = row.Cells["Тип проживания"].Value.ToString();
                    meal = row.Cells["Тип питания"].Value.ToString();

                    date_start = DateTime.ParseExact(row.Cells["Дата начала"].Value.ToString(),
                        "dd.MM.yyyy h:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

                    duration = row.Cells["Длительность"].Value.ToString();
                    cost = row.Cells["Стоимость"].Value.ToString();
                    res = Tour.DeleteTour(name, city, hotel, accomodation,
                    meal, date_start, duration, cost);
                    if (!res) break;
                }
                Tour.GetTour();
                if (res) MessageBox.Show($"Все выбранные туры успешно удалены!");
            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (name_edit.Text != "" &&
                city_edit.Text != "" &&
                hotel_edit.Text != "" &&
                accomodation_edit.Text != "" &&
                meal_edit.Text != "" &&
                duration_edit.Text != "" &&
                cost_edit.Text != "")
            {
                string query = $"SELECT id FROM Tour WHERE " +
                    $"name = \"{name_edit.Text}\" AND " +
                    $"city_id = (SELECT city.id FROM city WHERE city.name = \"{city_edit.Text}\") AND " +
                    $"hotel_id = (SELECT hotel.id FROM hotel WHERE hotel.name = \"{hotel_edit.Text}\") AND " +
                    $"accomodation = \"{accomodation_edit.Text}\" AND " +
                    $"meal = \"{meal_edit.Text}\" AND " +
                    $"date_start = \"{date_edit.Value.Date.ToString("yyyy-MM-dd")}\" AND " +
                    $"duration = \"{duration_edit.Text}\" AND " +
                    $"cost = \"{cost_edit.Text}\";";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой тур уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_edit_Click(sender, e);
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = tours.SelectedRows[0];
                        string old_name = row.Cells["Название"].Value.ToString();
                        string old_city = row.Cells["Город"].Value.ToString();
                        string old_hotel = row.Cells["Отель"].Value.ToString();
                        string old_accomodation = row.Cells["Тип проживания"].Value.ToString();
                        string old_meal = row.Cells["Тип питания"].Value.ToString();
                        string old_date_start = DateTime.ParseExact(row.Cells["Дата начала"].Value.ToString(),
                        "dd.MM.yyyy h:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                        string old_duration = row.Cells["Длительность"].Value.ToString();
                        string old_cost = row.Cells["Стоимость"].Value.ToString();
                        if (Tour.EditTour(old_name, name_edit.Text, old_city, city_edit.Text,
                            old_hotel, hotel_edit.Text, old_accomodation, accomodation_edit.Text,
                            old_meal, meal_edit.Text,
                            old_date_start, date_edit.Value.Date.ToString("yyyy-MM-dd"), old_duration, duration_edit.Text,
                            old_cost, cost_edit.Text))
                        {
                            MessageBox.Show("Данные о туре изменены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            name_edit.Text = "";
                            Tour.GetTour();
                        }
                        else
                        {
                            MessageBox.Show("Данные о туре не были изменены!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Пожалуйста, выберите строку для редактирования!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность заполнения полей!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn(object sender, EventArgs e)
        {
            name_add.Text = "";
            city_add.Text = "";
            hotel_add.Text = "";
            accomodation_add.Text = "";
            meal_add.Text = "";
            duration_add.Text = "";
            cost_add.Text = "";
        }

        private void clear_edit_Click(object sender, EventArgs e)
        {
            name_edit.Text = "";
            city_edit.Text = "";
            hotel_edit.Text = "";
            accomodation_edit.Text = "";
            meal_edit.Text = "";
            duration_edit.Text = "";
            cost_edit.Text = "";
        }

        private void city_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (city_add.SelectedItem != null)
            {
                string selectedCity = city_add.Text;
                try
                {
                    DBconnection.msCommand.CommandText = "SELECT hotel.name AS \"Название\", " +
                        "Hotel.stars AS \"Количество звёзд\", " +
                        "city.name AS \"Город\" FROM Hotel" +
                        " INNER JOIN city ON city_id = city.id" +
                        $" WHERE city.name = '{selectedCity}';";

                    DataTable dtFilteredHotels = new DataTable();
                    DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                    DBconnection.msDataAdapter.Fill(dtFilteredHotels);

                    hotel_add.DataSource = dtFilteredHotels.Copy();

                    hotel_add.DisplayMember = "Название";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Туры PDF-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToPDF(tours, sfd.FileName);
            }

        }

        private void excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "Туры Excel-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToExcel(tours, sfd.FileName);
            }
        }

        private void TourForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            button4_Click(sender, e);
        }

        private void city_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (city_edit.SelectedItem != null)
            {
                string selectedCity = city_edit.Text;
                try
                {
                    DBconnection.msCommand.CommandText = "SELECT hotel.name AS \"Название\", " +
                        "Hotel.stars AS \"Количество звёзд\", " +
                        "city.name AS \"Город\" FROM Hotel" +
                        " INNER JOIN city ON city_id = city.id" +
                        $" WHERE city.name = '{selectedCity}';";

                    DataTable dtFilteredHotels = new DataTable();
                    DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                    DBconnection.msDataAdapter.Fill(dtFilteredHotels);

                    hotel_edit.DataSource = dtFilteredHotels.Copy();

                    hotel_edit.DisplayMember = "Название";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
