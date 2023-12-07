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
    internal class Office
    {
        static public DataTable dtOffice = new DataTable();
        static public void GetOffice()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT Office.address AS \"Адрес\", " +
                    "Office.CEO_name AS \"ФИО директора\", " +
                    "office.phone AS \"Телефон\" FROM Office;";
                dtOffice.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtOffice);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddOffice(string address, string CEO_name, string phone)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO Office (address, CEO_name, phone) VALUES" +
                    $" (\"{address}\", \"{CEO_name}\", \"{phone}\");";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditOffice(string old_address, string new_address,
            string old_CEO, string new_CEO, string old_phone, string new_phone)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE Office SET address = \"{new_address}\", " +
                    $"CEO_name = \"{new_CEO}\", phone = \"{new_phone}\" " +
                    $"WHERE address = \"{old_address}\" AND CEO_name = \"{old_CEO}\"" +
                    $"AND phone = \"{old_phone}\";";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public void DeleteOffice(string del_address, string del_CEO, string del_phone)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM Office WHERE address = \"{del_address}\" AND " +
                    $"phone = \"{del_phone}\" AND CEO_name = \"{del_CEO}\";";
                DBconnection.msCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        static public bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, @"^8\d{10}");
        }
    }
}
