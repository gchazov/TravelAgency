using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgency.Forms
{
    public partial class FlightForm : Form
    {
        int originalHeight;
        public FlightForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Airport.GetAirport();
            airport_from_add.DataSource = Airport.dtAirport;
            airport_from_add.DisplayMember = "Название";
            airport_to_add.DataSource = Airport.dtAirport;
            airport_to_add.DisplayMember = "Название";
            airport_from_edit.DataSource = Airport.dtAirport;
            airport_from_edit.DisplayMember = "Название";
            airport_to_edit.DataSource = Airport.dtAirport;
            airport_to_edit.DisplayMember = "Название";


            Tour.GetTour();
            tour_add.DataSource = Tour.dtTour;
            tour_add.DisplayMember = "Название";
            tour_edit.DataSource = Tour.dtTour;
            tour_edit.DisplayMember = "Название";

            date_dep_add.Format = DateTimePickerFormat.Custom;
            date_arr_add.Format = DateTimePickerFormat.Custom;
            date_dep_edit.Format = DateTimePickerFormat.Custom;
            date_arr_edit.Format = DateTimePickerFormat.Custom;

            date_dep_add.CustomFormat = "yyyy-MM-dd HH:mm";
            date_arr_add.CustomFormat = "yyyy-MM-dd HH:mm";
            date_dep_edit.CustomFormat = "yyyy-MM-dd HH:mm";
            date_arr_edit.CustomFormat = "yyyy-MM-dd HH:mm";

            Flight.GetFlight();
            flights.DataSource = Flight.dtFlight;
            
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
            if (Flight.ValidateIdFlight(id_add.Text) &&
                    flight_company_add.Text != "" &&
                    date_dep_add.Value < date_arr_add.Value)
            {
                string query = "SELECT id FROM Flight WHERE " +
                    "flight.id = \"" + id_add.Text + "\" AND " +
                    "flight.date_departure = \"" + date_dep_add.Text + ":00" + "\" AND " +
                    "flight.date_arrival = \"" + date_arr_add.Text + ":00" + "\" AND " +
                    "flight.from_airport_id = (SELECT airport.id FROM AIRPORT WHERE airport.name = \"" +
                    airport_from_add.Text + "\") AND " +
                    "flight.to_airport_id = (SELECT airport.id FROM AIRPORT WHERE airport.name = \"" +
                    airport_to_add.Text + "\") AND " +
                    "flight.tour_id = (SELECT tour.id FROM tour WHERE tour.name = \"" + tour_add.Text + "\") AND " +
                    "flight.flight_company = \"" + flight_company_add.Text + "\";";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой авиарейс уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_btn(sender, e);
                }
                else
                {
                    if (Flight.AddFlight(id_add.Text, date_dep_add.Text + ":00", 
                        date_arr_add.Text + ":00", airport_from_add.Text,
                        airport_to_add.Text, tour_add.Text, flight_company_add.Text))
                    {
                        MessageBox.Show("Авиарейс добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear_btn(sender, e);
                        Flight.GetFlight();
                    }
                    else
                    {
                        MessageBox.Show("Авиарейс не был добавлен!");
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
            if (flights.SelectedRows.Count > 0)
            {
                string id, date_dep, date_arr, airport_from, airport_to,
                    tour, flight_company;
                foreach (DataGridViewRow row in flights.SelectedRows)
                {
                    id = row.Cells["Код рейса"].Value.ToString();
                    try
                    {
                        date_dep = DateTime.ParseExact(row.Cells["Дата и время вылета"].Value.ToString(),
                        "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                    }
                    catch
                    {
                        date_dep = DateTime.ParseExact(row.Cells["Дата и время вылета"].Value.ToString(),
                        "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                    }


                    try
                    {
                        date_arr = DateTime.ParseExact(row.Cells["Дата и время прибытия"].Value.ToString(),
                        "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                    }
                    catch
                    {
                        date_arr = DateTime.ParseExact(row.Cells["Дата и время прибытия"].Value.ToString(),
                        "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                    }

                    airport_from = row.Cells["Аэропорт вылета"].Value.ToString();
                    airport_to = row.Cells["Аэропорт прибытия"].Value.ToString();
                    tour = row.Cells["Тур"].Value.ToString();
                    flight_company = row.Cells["Авиакомпания"].Value.ToString();


                    Flight.DeleteFlight(id, date_dep, date_arr, airport_from, airport_to,
                    tour, flight_company);
                }
                Flight.GetFlight();
                MessageBox.Show($"Все выбранные рейсы успешно удалены!");
            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (Flight.ValidateIdFlight(id_edit.Text) &&
                    flight_company_edit.Text != "" &&
                    date_dep_edit.Value < date_arr_edit.Value)
            {
                string query = $"SELECT id FROM Flight WHERE " +
                    $"flight.id = \"{id_edit.Text}\" AND " +
                    $"Flight.date_departure = \"{date_dep_edit.Text}\" AND " +
                    $"Flight.date_arrival = \"{date_arr_edit.Text}\" AND " +
                    $"flight.from_airport_id =  (SELECT airport.id FROM AIRPORT " +
                    $"WHERE airport.name = \"{airport_from_edit.Text}\") AND " +
                    $"flight.to_airport_id =  (SELECT airport.id FROM AIRPORT " +
                    $"WHERE airport.name = \"{airport_to_edit.Text}\") AND " +
                    $"flight.tour_id =  (SELECT tour.id FROM tour " +
                    $"WHERE tour.name = \"{tour_edit.Text}\") AND " +
                    $"flight.flight_company = \"{flight_company_edit.Text}\";";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой авиарейс уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_edit_Click(sender, e);
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = flights.SelectedRows[0];
                        string id, date_dep, date_arr, airport_from, airport_to,
                        tour, flight_company;

                        id = row.Cells["Код рейса"].Value.ToString();

                        try
                        {
                            date_dep = DateTime.ParseExact(row.Cells["Дата и время вылета"].Value.ToString(),
                                "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                        }
                        catch
                        {
                            date_dep = DateTime.ParseExact(row.Cells["Дата и время вылета"].Value.ToString(),
                                "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                        }
                        try
                        {
                            date_arr = DateTime.ParseExact(row.Cells["Дата и время прибытия"].Value.ToString(),
                                "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                        }
                        catch
                        {
                            date_arr = DateTime.ParseExact(row.Cells["Дата и время прибытия"].Value.ToString(),
                                "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                        }

                        airport_from = row.Cells["Аэропорт вылета"].Value.ToString();
                        airport_to = row.Cells["Аэропорт прибытия"].Value.ToString();
                        tour = row.Cells["Тур"].Value.ToString();
                        flight_company = row.Cells["Авиакомпания"].Value.ToString();

                        if (Flight.EditFlight(id, id_edit.Text, date_dep, date_dep_edit.Text + ":00", 
                            date_arr, date_arr_edit.Text + ":00", airport_from, airport_from_edit.Text,
                            airport_to, airport_to_edit.Text, tour, tour_edit.Text, flight_company, flight_company_edit.Text))
                        {
                            MessageBox.Show("Данные об авиарейсе изменены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear_edit_Click(sender, e);
                            Flight.GetFlight();
                        }
                        else
                        {
                            MessageBox.Show("Данные об авиарейсе не были изменены!");
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
            id_add.Text = "";
            flight_company_add.Text = "";
        }

        private void clear_edit_Click(object sender, EventArgs e)
        {
            id_edit.Text = "";
            flight_company_edit.Text = "";
        }

        private void city_add_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
