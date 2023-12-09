using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Queries
{
    internal class ByersMoreAvg
    {
        static public DataTable dtTours = new DataTable();
        static public void GetSoldTours()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT client.name AS \"Клиент\", tour.name AS \"Название тура\"," +
                    " city.name AS \"Город\", tour.cost AS \"Стоимость тура\"" +
                    " FROM contract INNER JOIN client ON client.id = client_id " +
                    "INNER JOIN tour ON tour.id = tour_id " +
                    "INNER JOIN city ON city.id = tour.city_id" +
                    " WHERE tour.cost > (SELECT AVG(tour.cost) FROM tour);";
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
