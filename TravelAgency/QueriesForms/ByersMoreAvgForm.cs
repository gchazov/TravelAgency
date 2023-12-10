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
    public partial class ByersMoreAvgForm : Form
    {
        public ByersMoreAvgForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPanel mp = new MainPanel();
            mp.Show();
        }

        

        private void ByersMoreAvgForm_Load(object sender, EventArgs e)
        {
            ByersMoreAvg.GetSoldTours();
            display.DataSource = ByersMoreAvg.dtTours;
        }
    }
}
