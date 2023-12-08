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

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
    }
}
