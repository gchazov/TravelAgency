using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Queries
{
    internal class Perm
    {
        static public DataTable dtTours = new DataTable();
        static public void GetPerm()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT country.name AS \"Страна\", " +
                    "COUNT(1) AS \"Количество продаж\" " +
                    "FROM contract " +
                    "INNER JOIN employee ON employee.id = employee_id " +
                    "INNER JOIN office ON employee.office_id = office.id " +
                    "INNER JOIN tour ON contract.tour_id = tour.id " +
                    "INNER JOIN city ON tour.city_id = city.id " +
                    "INNER JOIN country ON country.id = city.country_id " +
                    "WHERE office.address " +
                    "LIKE \"%Пермь%\" AND MONTH(reg_date) IN (1, 2, 12)" +
                    " GROUP BY country.name;";
                dtTours.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtTours);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
