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
    internal class Client
    {
        static public DataTable dtClient = new DataTable();
        static public void GetClient()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT client.name AS \"ФИО\", " +
                    "Client.address AS \"Адрес\", " +
                    "Client.passport AS \"Паспорт\", " +
                    "Client.phone AS \"Телефон\" FROM Client;";
                dtClient.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtClient);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddClient(string name, string address, string passport, string phone)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO Client (name, address, passport, phone) VALUES" +
                    $" (\"{name}\", \"{address}\", \"{passport}\", \"{phone}\");";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditClient(string old_name, string new_name, string old_address, string new_address,
            string old_passport, string new_passport, string old_phone, string new_phone)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE Client SET name = \"{new_name}\", " +
                    $"address = \"{new_address}\", " +
                    $"passport = \"{new_passport}\", phone = \"{new_phone}\" " +
                    $"WHERE name =  \"{old_name}\" AND address = \"{old_address}\" AND passport = \"{old_passport}\" " +
                    $"AND phone = \"{old_phone}\";";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteClient(string del_name, string del_address, string del_passport, string del_phone)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM Client WHERE name = \"{del_name}\" AND " +
                    $"address = \"{del_address}\" AND " +
                    $"phone = \"{del_phone}\" AND passport = \"{del_passport}\";";
                DBconnection.msCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"У пользователя {DBconnection.login} не достаточно полномочий для совершения этого действия! Обратитесь к старшему менеджеру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool ValidatePassport(string passport)
        {
            return Regex.IsMatch(passport, @"\d{10}");
        }
        
    }
}
