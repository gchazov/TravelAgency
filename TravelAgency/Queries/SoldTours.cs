using System;
using System.Data;
using System.Windows.Forms;

namespace TravelAgency.Queries
{
    internal class SoldTours
    {
        static public DataTable dtTours = new DataTable();
        static public void GetSoldTours()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT city.name AS \"Город\", " +
                    "COUNT(1) AS \"Кол-во продаж\", SUM(tour.cost) AS \"Сумма продаж\" FROM tour " +
                    "INNER JOIN city on city.id = city_id" +
                    " GROUP BY city.name ORDER BY \"Сумма продаж\" DESC;";
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
