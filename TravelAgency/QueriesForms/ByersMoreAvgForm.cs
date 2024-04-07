using System;
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

        private void pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Богатые клиенты PDF-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToPDF(display, sfd.FileName);
            }

        }

        private void excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "Богатые клиенты Excel-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToExcel(display, sfd.FileName);
            }
        }

        private void ByersMoreAvgForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
