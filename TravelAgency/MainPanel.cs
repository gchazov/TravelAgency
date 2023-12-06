using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Forms;

namespace TravelAgency
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AirportForm af = new AirportForm();
            af.Show();
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            DBconnection.Connect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryForm af = new CountryForm();
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CityForm cf = new CityForm();
            cf.Show();
        }
    }
}
