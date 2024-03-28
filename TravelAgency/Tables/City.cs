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
    internal class City
    {
        static public DataTable dtCity = new DataTable();
        static public void GetCity()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT city.name AS \"Название\", country.name AS \"Страна\" FROM City" +
                    " INNER JOIN country ON country_id = country.id;";
                dtCity.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtCity);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddCity(string name, string country)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO City (name, country_id) VALUES" +
                    $" (\"{name}\", (SELECT id FROM country WHERE country.name = \"{country}\"));";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditCity(string old_name, string new_name,
            string old_country, string new_country)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE City SET name = \"{new_name}\", " +
                    $"country_id = (SELECT id FROM country WHERE country.name = \"{new_country}\")" +
                    $"WHERE name = \"{old_name}\" AND country_id = " +
                    $"(SELECT id FROM country WHERE country.name = \"{old_country}\");";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteCity(string del_code)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM City WHERE name = \"{del_code}\";";
                DBconnection.msCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
    }
}
