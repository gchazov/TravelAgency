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
using TravelAgency.Queries;

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
            label3.Text = "Вы авторизованы как " + DBconnection.login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryForm cf = new CountryForm();
            cf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CityForm cf = new CityForm();
            cf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HotelForm hf = new HotelForm();
            hf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficeForm of = new OfficeForm();
            of.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm cf = new ClientForm();
            cf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm ef = new EmployeeForm();
            ef.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TourForm tf = new TourForm();
            tf.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightForm ff = new FlightForm();
            ff.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContractForm cf = new ContractForm();
            cf.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoldToursForm sff = new SoldToursForm();
            sff.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            ByersMoreAvgForm bmaf = new ByersMoreAvgForm();
            bmaf.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            PermForm pf = new PermForm();
            pf.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficeAvgForm oaf = new OfficeAvgForm();
            oaf.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlightTimeForm ftf = new FlightTimeForm();
            ftf.Show();
        }
    }
}
