using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TravelAgency.Tables
{
    internal class Airport
    {
        static public DataTable dtAirport = new DataTable();
        static public void GetAirport()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT airport.id as \"IATA код\", " +
                    "airport.name as \"Название\", city.name as \"Город\" FROM airport " +
                    "INNER JOIN city on city_id = city.id;";
                dtAirport.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtAirport);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddAirport(string IATA_code, string name, string cityId)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO airport VALUES" +
                    $" (\"{IATA_code}\", \"{name}\", (SELECT id FROM city WHERE city.name = \"{cityId}\"));";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditAirport(string IATA_code, string name, string cityId,
            string new_IATA_code, string new_name, string new_cityId)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE airport SET id = \"{new_IATA_code}\"," +
                    $" name = \"{new_name}\", city_id = (SELECT id FROM city WHERE city.name = \"{new_cityId}\")" +
                    $" WHERE id = \"{IATA_code}\" AND name = \"{name}\" AND" +
                    $" city_id = (SELECT id FROM city WHERE city.name = \"{cityId}\") ;";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteAirport(string IATA_code)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM airport WHERE id = \"{IATA_code}\";";
                DBconnection.msCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"У пользователя {DBconnection.login} не достаточно полномочий для совершения этого действия! Обратитесь к старшему менеджеру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool ValidateIATA(string IATA_code)
        {
            return IATA_code.Length == 3 && Regex.IsMatch(IATA_code, @"^[A-Z]+$");
        }
    }
}
