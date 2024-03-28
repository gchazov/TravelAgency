using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Forms;

namespace TravelAgency
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

       
        private void MainPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void go_Click(object sender, EventArgs e)
        {
            try
            {
                DBconnection.login = login.Text;
                DBconnection.pass = pass.Text;
                if (!DBconnection.Connect()) throw new Exception();
                this.Hide();
                MainPanel mp = new MainPanel();
                mp.Show();
            }
            catch
            {
                MessageBox.Show("Проверьте логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
