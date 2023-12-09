using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Queries
{
    public partial class AvgOfficeForm : Form
    {
        public AvgOfficeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPanel mp = new MainPanel();
            mp.Show();
        }

        private void AvgOfficeForm_Load(object sender, EventArgs e)
        {
            AvgOffice.GetSoldTours();
            display.DataSource = AvgOffice.dtAvg;
        }
    }
}
