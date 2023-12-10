using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Queries
{
    internal class FlightTime
    {
        static public DataTable dtTours = new DataTable();
        static public void GetFlightTime()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT client.name AS \"Клиент\", " +
                    "TIME_FORMAT(SEC_TO_TIME( SUM(TIMESTAMPDIFF(SECOND," +
                    " flight.date_departure, flight.date_arrival)))," +
                    " '%H:%i') AS \"Общее время в полёте\" " +
                    "FROM contract INNER JOIN tour ON tour.id = contract.tour_id " +
                    "INNER JOIN client ON client.id = contract.client_id" +
                    " INNER JOIN flight ON flight.tour_id = tour.id " +
                    "GROUP BY client.name ORDER BY \"Время в полёте\";";
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
