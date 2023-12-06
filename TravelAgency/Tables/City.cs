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
                DBconnection.msCommand.CommandText = "SELECT City.id AS \"ОКСМ код\", City.name AS \"Название\" FROM City;";
                dtCity.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtCity);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddCity(string id, string name)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO City VALUES" +
                    $" (\"{id}\", \"{name}\");";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditCity(string old_code, string new_code, string old_name, string new_name)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE City SET id = \"{new_code}\", " +
                    $"name = \"{new_name}\"" +
                    $"WHERE id = \"{old_code}\" AND name = \"{old_name}\";";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public void DeleteCity(string del_code)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM City WHERE id = \"{del_code}\";";
                DBconnection.msCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool ValidateOKSM(string oksm)
        {
            return oksm.Length == 3 && Regex.IsMatch(oksm, @"^[0-9]+$");
        }
        
    }
}
