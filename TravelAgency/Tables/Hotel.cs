using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Tables
{
    internal class Hotel
    {
        static public DataTable dtHotel = new DataTable();
        static public void GetHotel()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT Hotel.name AS \"Название\", " +
                    "Hotel.stars AS \"Количество звёзд\", " +
                    "city.name AS \"Город\" FROM Hotel" +
                    " INNER JOIN city ON city_id = city.id;";
                dtHotel.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtHotel);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddHotel(string name, string city, string stars)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO Hotel (name, city_id, stars) VALUES" +
                    $" (\"{name}\", (SELECT id FROM city WHERE city.name = \"{city}\"), {stars});";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditHotel(string old_name, string new_name,
            string old_city, string new_city, string old_stars, string new_stars)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE Hotel SET name = \"{new_name}\", " +
                    $"city_id = (SELECT id FROM city WHERE city.name = \"{new_city}\"), stars = {new_stars} " +
                    $"WHERE name = \"{old_name}\" AND city_id = " +
                    $"(SELECT id FROM city WHERE city.name = \"{old_city}\") " +
                    $"AND stars = {old_stars};";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"У пользователя {DBconnection.login} не достаточно полномочий для совершения этого действия! Обратитесь к старшему менеджеру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteHotel(string del_name, string del_stars, string del_city)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM Hotel WHERE name = \"{del_name}\" AND " +
                    $"stars = \"{del_stars}\" AND city_id = (SELECT id FROM city WHERE city.name = \"{del_city}\");";
                DBconnection.msCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"У пользователя {DBconnection.login} не достаточно полномочий для совершения этого действия! Обратитесь к старшему менеджеру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
    }
}
