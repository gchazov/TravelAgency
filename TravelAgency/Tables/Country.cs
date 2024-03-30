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
    internal class Country
    {
        static public DataTable dtCountry = new DataTable();
        static public void GetCountry()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT country.id AS \"ОКСМ код\", country.name AS \"Название\" FROM country;";
                dtCountry.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtCountry);

            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddCountry(string id, string name)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO country VALUES" +
                    $" (\"{id}\", \"{name}\");";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditCountry(string old_code, string new_code, string old_name, string new_name)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE country SET id = \"{new_code}\", " +
                    $"name = \"{new_name}\"" +
                    $"WHERE id = \"{old_code}\" AND name = \"{old_name}\";";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteCountry(string del_code)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM country WHERE id = \"{del_code}\";";
                DBconnection.msCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"У пользователя {DBconnection.login} не достаточно полномочий для совершения этого действия! Обратитесь к старшему менеджеру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;           
            }
        }

        static public bool ValidateOKSM(string oksm)
        {
            return oksm.Length == 3 && Regex.IsMatch(oksm, @"^[0-9]+$");
        }
        
    }
}
