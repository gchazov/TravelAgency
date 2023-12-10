using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Queries
{
    internal class OfficeAvg
    {
        static public DataTable dtTours = new DataTable();
        static public void GetAvg()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT city.name AS \"Город филиала\"," +
                    " ROUND(AVG(tour.cost), 2) AS \"Средняя сумма продажи\" FROM contract " +
                    "INNER JOIN tour ON tour.id = contract.tour_id " +
                    "INNER JOIN employee ON employee.id = contract.employee_id" +
                    " INNER JOIN office ON office.id = employee.office_id " +
                    "INNER JOIN city ON office.address LIKE CONCAT('%', city.name, '%') " +
                    "GROUP BY city.name ORDER BY ROUND(AVG(tour.cost), 2) DESC;";
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
