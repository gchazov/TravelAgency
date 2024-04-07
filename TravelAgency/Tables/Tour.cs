using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Controls.Primitives;
namespace TravelAgency.Tables
{
    internal class Tour
    {
        static public DataTable dtTour = new DataTable();
        static public void GetTour()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT tour.name AS \"Название\", " +
                    "city.name AS \"Город\", " +
                    "hotel.name AS \"Отель\", " +
                    "Tour.accomodation AS \"Тип проживания\", " +
                    "Tour.meal AS \"Тип питания\", " +
                    "Tour.date_start AS \"Дата начала\", " +
                    "Tour.duration AS \"Длительность\", " +
                    "Tour.cost AS \"Стоимость\" " +
                    "FROM Tour INNER JOIN city on city.id = city_id " +
                    "INNER JOIN hotel ON hotel.id = hotel_id;";
                dtTour.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtTour);

            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       



        static public bool AddTour(string name, string city, string hotel, string accomodation,
            string meal, string date_start, string duration, string cost)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO Tour (name, city_id, hotel_id, accomodation, " +
                    $"meal, date_start, duration, cost) VALUES " +
                    $" (\"{name}\", " +
                    $"(SELECT city.id FROM city WHERE city.name = \"{city}\"), " +
                    $"(SELECT hotel.id FROM hotel WHERE hotel.name = \"{hotel}\"), " +
                    $"\"{accomodation}\", " +
                    $"\"{meal}\", " +
                    $"\"{date_start}\", " +
                    $"\"{duration}\", " +
                    $"\"{cost}\");";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditTour(string old_name, string new_name,string old_city, string new_city, 
            string old_hotel, string new_hotel, string old_accomodation, string new_accomodation,
            string old_meal, string new_meal, string old_date_start, string new_date_start, 
            string old_duration, string new_duration, string old_cost, string new_cost)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE tour SET " +
                    $"name = \"{new_name}\", " +
                    $"city_id = (SELECT city.id FROM city WHERE city.name = \"{new_city}\"), " +
                    $"hotel_id = (SELECT hotel.id FROM hotel WHERE hotel.name = \"{new_hotel}\"), " +
                    $"accomodation = \"{new_accomodation}\", " +
                    $"meal = \"{new_meal}\", " +
                    $"date_start = \"{new_date_start}\", " +
                    $"duration = \"{new_duration}\", " +
                    $"cost = \"{new_cost}\" WHERE " +
                    $"name = \"{old_name}\" AND " +
                    $"city_id = (SELECT city.id FROM city WHERE city.name = \"{old_city}\") AND " +
                    $"hotel_id = (SELECT hotel.id FROM hotel WHERE hotel.name = \"{old_hotel}\") AND " +
                    $"accomodation = \"{old_accomodation}\" AND " +
                    $"meal = \"{old_meal}\" AND " +
                    $"date_start = \"{old_date_start}\" AND " +
                    $"duration = \"{old_duration}\" AND " +
                    $"cost = \"{old_cost}\";";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteTour(string del_name, string del_city, string del_hotel, string del_accomodation,
            string del_meal, string del_date_start, string del_duration, string del_cost)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM Tour WHERE " +
                    $"name = \"{del_name}\" AND " +
                    $"city_id = (SELECT city.id FROM city WHERE city.name = \"{del_city}\") AND " +
                    $"hotel_id = (SELECT hotel.id FROM hotel WHERE hotel.name = \"{del_hotel}\") AND " +
                    $"accomodation = \"{del_accomodation}\" AND " +
                    $"meal = \"{del_meal}\" AND " +
                    $"date_start = \"{del_date_start}\" AND " +
                    $"duration = \"{del_duration}\" AND " +
                    $"cost = \"{del_cost}\";";
                DBconnection.msCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"У пользователя {DBconnection.login} недостаточно полномочий для совершения этого действия! " +
                    $"Обратитесь к старшему менеджеру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
                
    }
}
