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
    internal class Employee
    {
        static public DataTable dtEmployee = new DataTable();
        static public void GetEmployee()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT employee.name AS \"ФИО\", " +
                    "Employee.address AS \"Адрес\", " +
                    "Employee.passport AS \"Паспорт\", " +
                    "Employee.phone AS \"Телефон\", " +
                    "Employee.position AS \"Должность\", " +
                    "office.address AS \"Адрес работы\" " +
                    "FROM Employee INNER JOIN office on office.id = office_id;";
                dtEmployee.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtEmployee);

            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddEmployee(string name, string address, string passport, string phone,
            string position, string office)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO Employee (name, address, passport, phone, " +
                    $"position, office_id) VALUES " +
                    $" (\"{name}\", \"{address}\", \"{passport}\", \"{phone}\", \"{position}\", " +
                    $"(SELECT office.id FROM office WHERE office.address = \"{office}\"));";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditEmployee(string old_name, string new_name, string old_address, string new_address,
            string old_passport, string new_passport, string old_phone, string new_phone,
            string old_position, string new_position, string old_office, string new_office)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE Employee SET name = \"{new_name}\", " +
                    $"address = \"{new_address}\", " +
                    $"passport = \"{new_passport}\", phone = \"{new_phone}\"," +
                    $"position =  \"{new_position}\", office_id = " +
                    $"(SELECT office.id FROM office WHERE office.address =  \"{new_office}\") " +
                    $"WHERE name =  \"{old_name}\" AND address = \"{old_address}\" AND passport = \"{old_passport}\" " +
                    $"AND phone = \"{old_phone}\" AND position =  \"{old_position}\" AND office_id = " +
                    $"(SELECT office.id FROM office WHERE office.address =  \"{old_office}\");";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("У пользователя недостаточно прав для совершения этого действия!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteEmployee(string del_name, string del_address, string del_passport,
            string del_phone, string del_position, string del_office)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM Employee WHERE name = \"{del_name}\" AND " +
                    $"address = \"{del_address}\" AND " +
                    $"phone = \"{del_phone}\" AND passport = \"{del_passport}\" AND " +
                    $"position = \"{del_position}\" AND office_id = " +
                    $"(SELECT office.id FROM office WHERE office.address =  \"{del_office}\");";
                DBconnection.msCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"У пользователя {DBconnection.login} недостаточно полномочий для совершения этого действия! Обратитесь к старшему менеджеру.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool ValidatePassport(string passport)
        {
            return Regex.IsMatch(passport, @"\d{10}");
        }
        
    }
}
