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
    public partial class PermForm : Form
    {
        public PermForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPanel mp = new MainPanel();
            mp.Show();
        }

        private void SoldToursForm_Load(object sender, EventArgs e)
        {
            Perm.GetSoldTours();
            display.DataSource = Perm.dtTours;
        }
    }
}
