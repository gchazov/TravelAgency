using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TravelAgency.Tables
{
    internal class Flight
    {
        static public DataTable dtFlight = new DataTable();
        static public void GetFlight()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT flight.id AS \"Код рейса\", " +
                    "Flight.date_departure AS \"Дата и время вылета\", " +
                    "Flight.date_arrival AS \"Дата и время прибытия\", " +
                    "af.name AS \"Аэропорт вылета\", " +
                    "at.name AS \"Аэропорт прибытия\", " +
                    "tour.name AS \"Тур\", " +
                    "flight.flight_company AS \"Авиакомпания\" " +
                    "FROM Flight INNER JOIN airport AS af ON af.id = from_airport_id " +
                    "INNER JOIN airport AS at ON at.id = to_airport_id " +
                    "INNER JOIN tour ON tour.id = tour_id;";
                dtFlight.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtFlight);

            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddFlight(string id, string date_dep, string date_arr, string from_airport,
            string to_airport, string tour_name, string flight_company)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO flight VALUES (\"{id}\", " +
                    $"\"{date_dep}\", " +
                    $"\"{date_arr}\", " +
                    $"(SELECT id FROM AIRPORT " +
                    $"WHERE name = \"{from_airport}\"), " +
                    $"(SELECT id FROM AIRPORT " +
                    $"WHERE name = \"{to_airport}\"), " +
                    $"(SELECT tour.id FROM tour " +
                    $"WHERE tour.name = \"{tour_name}\"), " +
                    $"\"{flight_company}\");";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditFlight(string old_id, string new_id, string old_date_dep, string new_date_dep,
            string old_date_arr, string new_date_arr, string old_from_airport, string new_from_airport,
            string old_to_airport, string new_to_airport, string old_tour_name, string new_tour_name,
            string old_flight_company, string new_flight_company)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE flight SET flight.id = \"{new_id}\", " +
                    $"Flight.date_departure = \"{new_date_dep}\", " +
                    $"Flight.date_arrival = \"{new_date_arr}\", " +
                    $"flight.from_airport_id =  (SELECT airport.id FROM AIRPORT " +
                    $"WHERE airport.name = \"{new_from_airport}\"), " +
                    $"flight.to_airport_id =  (SELECT airport.id FROM AIRPORT " +
                    $"WHERE airport.name = \"{new_to_airport}\"), " +
                    $"flight.tour_id =  (SELECT tour.id FROM tour " +
                    $"WHERE tour.name = \"{new_tour_name}\"), " +
                    $"flight.flight_company = \"{new_flight_company}\" WHERE " +
                    $"flight.id = \"{old_id}\" AND " +
                    $"Flight.date_departure = \"{old_date_dep + ":00" }\" AND " +
                    $"Flight.date_arrival = \"{old_date_arr + ":00"}\" AND " +
                    $"flight.from_airport_id =  (SELECT airport.id FROM AIRPORT " +
                    $"WHERE airport.name = \"{old_from_airport}\") AND " +
                    $"flight.to_airport_id =  (SELECT airport.id FROM AIRPORT " +
                    $"WHERE airport.name = \"{old_to_airport}\") AND " +
                    $"flight.tour_id =  (SELECT tour.id FROM tour " +
                    $"WHERE tour.name = \"{old_tour_name}\") AND " +
                    $"flight.flight_company = \"{old_flight_company}\";";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteFlight(string del_id, string del_date_dep, string del_date_arr,
            string del_from_airport, string del_to_airport, string del_tour_name,
            string del_flight_company)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM Flight WHERE " +
                    $"flight.id = \"{del_id}\" AND " +
                    $"Flight.date_departure = \"{del_date_dep}\" AND " +
                    $"Flight.date_arrival = \"{del_date_arr}\" AND " +
                    $"flight.from_airport_id =  (SELECT airport.id FROM AIRPORT " +
                    $"WHERE airport.name = \"{del_from_airport}\") AND " +
                    $"flight.to_airport_id =  (SELECT airport.id FROM AIRPORT " +
                    $"WHERE airport.name = \"{del_to_airport}\") AND " +
                    $"flight.tour_id =  (SELECT tour.id FROM tour " +
                    $"WHERE tour.name = \"{del_tour_name}\") AND " +
                    $"flight.flight_company = \"{del_flight_company}\";";
                DBconnection.msCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"У пользователя {DBconnection.login} не достаточно полномочий для совершения этого действия! Обратитесь к старшему менеджеру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool ValidateIdFlight(string id)
        {
            return Regex.IsMatch(id, @"[A-Z]{2}[0-9]{4}[A-Z]{1}");
        }
                
    }
}
