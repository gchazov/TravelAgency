using System;
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

        private void PermForm_Load(object sender, EventArgs e)
        {
            Perm.GetPerm();
            display.DataSource = Perm.dtTours;
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Жители Перми PDF-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToPDF(display, sfd.FileName);
            }

        }

        private void excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "Жители Перми Excel-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToExcel(display, sfd.FileName);
            }
        }

        private void PermForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
