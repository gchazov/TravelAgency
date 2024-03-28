using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI;
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
    internal class Contract
    {
        static public DataTable dtContract = new DataTable();
        static public void GetContract()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT tour.name AS \"Тур\", " +
                    "client.name AS \"Клиент\", " +
                    "employee.name AS \"Сотрудник\", " +
                    "contract.reg_date AS \"Дата оформления\" FROM contract " +
                    "INNER JOIN client ON client.id = client_id " +
                    "INNER JOIN employee ON employee.id = employee_id " +
                    "INNER JOIN tour ON tour.id = tour_id;";
                dtContract.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtContract);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddContract(string tour, string client,string employee, string reg_date)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"INSERT INTO contract (tour_id, client_id, " +
                    $"employee_id, reg_date) " +
                    $"VALUES ((SELECT id FROM tour WHERE tour.name = \"{tour}\"), " +
                    $"(SELECT id FROM client WHERE client.name = \"{client}\"), " +
                    $"(SELECT id FROM employee WHERE employee.name = \"{employee}\"), " +
                    $"\"{reg_date}\");";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditContract(string old_tour, string new_tour, string old_client, string new_client,
            string old_employee, string new_employee, string old_reg_date, string new_reg_date)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"UPDATE contract SET " +
                    $"tour_id = (SELECT id FROM tour WHERE tour.name = \"{new_tour}\"), " +
                    $"client_id = (SELECT id FROM client WHERE client.name = \"{new_client}\"), " +
                    $"employee_id = (SELECT id FROM employee WHERE employee.name = \"{new_employee}\"), " +
                    $"reg_date = \"{new_reg_date}\" WHERE " +
                    $"tour_id = (SELECT id FROM tour WHERE tour.name = \"{old_tour}\") AND " +
                    $"client_id = (SELECT id FROM client WHERE client.name = \"{old_client}\") AND " +
                    $"employee_id = (SELECT id FROM employee WHERE employee.name = \"{old_employee}\") AND " +
                    $"reg_date = \"{old_reg_date}\";";
                return DBconnection.msCommand.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool DeleteContract(string tour, string client, string employee, string reg_date)
        {
            try
            {
                DBconnection.msCommand.CommandText = $"DELETE FROM contract WHERE " +
                    $"tour_id = (SELECT id FROM tour WHERE tour.name = \"{tour}\") AND " +
                    $"client_id = (SELECT id FROM client WHERE client.name = \"{client}\") AND " +
                    $"employee_id = (SELECT id FROM employee WHERE employee.name = \"{employee}\") AND " +
                    $"reg_date = \"{reg_date}\";";
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
