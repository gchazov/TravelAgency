using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Forms;
using TravelAgency.Queries;
using OfficeOpenXml;

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

        private void MainPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            button4_Click(sender, e);
        }

        public static void ExportToPDF(DataGridView dataGridView, string filePath)
        {
            Document doc = new Document(PageSize.A4);

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(baseFont, 9, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font regularFont = new iTextSharp.text.Font(baseFont, 7, iTextSharp.text.Font.NORMAL);


                PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPCell headerCell = new PdfPCell(new Phrase("Туры", boldFont));
                headerCell.Colspan = dataGridView.Columns.Count;
                headerCell.NoWrap = true;
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.AddCell(headerCell);

                string dateTimeText = "Отчёт от " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                PdfPCell dateCell = new PdfPCell(new Phrase(dateTimeText, regularFont));
                dateCell.Colspan = dataGridView.Columns.Count;
                dateCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                pdfTable.AddCell(dateCell);

                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, boldFont));
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        PdfPCell cellPdf = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", regularFont));
                        pdfTable.AddCell(cellPdf);
                    }
                }
                pdfTable.CompleteRow();

                doc.Add(pdfTable);
                MessageBox.Show("Данные успешно экспортированы в PDF.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла непрведвиденная ошибка, попробуйте снова!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                doc.Close();
            }
        }

        public static void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Tours");

                    worksheet.Cells["A1"].Value = "Отчёт от " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
                    worksheet.Cells["A1"].Style.Font.Bold = true;

                    int columnIndex = 1;
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        worksheet.Cells[2, columnIndex].Value = column.HeaderText;
                        worksheet.Cells[2, columnIndex].Style.Font.Bold = true;
                        worksheet.Cells[2, columnIndex].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        columnIndex++;
                    }

                    int rowIndex = 3;
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        columnIndex = 1;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            worksheet.Cells[rowIndex, columnIndex].Value = cell.Value?.ToString() ?? "";
                            columnIndex++;
                        }
                        rowIndex++;
                    }
                    
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    worksheet.Cells[worksheet.Dimension.Address].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    worksheet.Cells[worksheet.Dimension.Address].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    worksheet.Cells[worksheet.Dimension.Address].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    worksheet.Cells[worksheet.Dimension.Address].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);
                }

                MessageBox.Show("Данные успешно экспортированы в Excel.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
