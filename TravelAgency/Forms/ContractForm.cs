using Google.Protobuf.WellKnownTypes;
using iTextSharp.text;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using Document = Microsoft.Office.Interop.Word.Document;

namespace TravelAgency.Forms
{
    public partial class ContractForm : Form
    {
        int originalHeight;
        public ContractForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Tour.GetTour();
            tour_add.DataSource = Tour.dtTour;
            tour_add.DisplayMember = "Название";
            tour_edit.DataSource = Tour.dtTour;
            tour_edit.DisplayMember = "Название";

            Tables.Client.GetClient();
            client_add.DataSource = Tables.Client.dtClient;
            client_add.DisplayMember = "ФИО";
            client_edit.DataSource = Tables.Client.dtClient;
            client_edit.DisplayMember = "ФИО";

            Employee.GetEmployee();
            employee_add.DataSource = Employee.dtEmployee;
            employee_add.DisplayMember = "ФИО";
            employee_edit.DataSource = Employee.dtEmployee;
            employee_edit.DisplayMember = "ФИО";

            date_add.Format = DateTimePickerFormat.Custom;
            date_edit.Format = DateTimePickerFormat.Custom;

            date_add.CustomFormat = "yyyy-MM-dd HH:mm";
            date_edit.CustomFormat = "yyyy-MM-dd HH:mm";

            Contract.GetContract();
            contracts.DataSource = Contract.dtContract;
            
            originalHeight = this.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Height == originalHeight)
            {
                this.Height = groupBox1.Height + originalHeight + 40;
            }
            else
            {
                this.Height -= groupBox1.Height + 40;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            clear_btn(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Height == originalHeight)
            {
                this.Height = groupBox2.Height + originalHeight + 40;
            }
            else
            {
                this.Height -= groupBox2.Height + 40;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            clear_edit_Click(sender, e);
        }

        private void canceladditbtn_Click(object sender, EventArgs e)
        {
            if (this.Height == originalHeight)
            {
                this.Height = groupBox1.Height + originalHeight + 40;
            }
            else
            {
                this.Height -= groupBox1.Height + 40;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            clear_btn(sender, e);
        }

        private void canceleditbtn_Click(object sender, EventArgs e)
        {
            if (this.Height == originalHeight)
            {
                this.Height = groupBox2.Height + originalHeight + 40;
            }
            else
            {
                this.Height -= groupBox2.Height + 40;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            clear_edit_Click(sender, e);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (
                tour_add.Text != "" &&
                client_add.Text != ""
                )
            {
                string query = $"SELECT id FROM contract WHERE " +
                    $"tour_id = (SELECT id FROM tour WHERE tour.name = \"{tour_add.Text}\") AND " +
                    $"client_id = (SELECT id FROM client WHERE client.name = \"{client_add.Text}\") AND " +
                    $"employee_id = (SELECT id FROM employee WHERE employee.name = \"{employee_add.Text}\") AND " +
                    $"reg_date = \"{date_add.Text + ":00"}\";";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой договор уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_btn(sender, e);
                }
                else
                {
                    if (Contract.AddContract(tour_add.Text, client_add.Text, employee_add.Text,
                        date_add.Text + ":00"))
                    {
                        MessageBox.Show("Договор добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear_btn(sender, e);
                        Contract.GetContract();
                    }
                    else
                    {
                        MessageBox.Show("Договор не был добавлен!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность заполнения полей!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPanel mp = new MainPanel();
            mp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (contracts.SelectedRows.Count > 0)
            {
                string tour, client, employee, date;
                var res = false;
                foreach (DataGridViewRow row in contracts.SelectedRows)
                {
                    tour = row.Cells["Тур"].Value.ToString();
                    client = row.Cells["Клиент"].Value.ToString();
                    employee = row.Cells["Сотрудник"].Value.ToString();

                    try
                    {
                        date = DateTime.ParseExact(row.Cells["Дата оформления"].Value.ToString(),
                        "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                    }
                    catch
                    {
                        date = DateTime.ParseExact(row.Cells["Дата оформления"].Value.ToString(),
                        "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                    }


                    res = Contract.DeleteContract(tour, client, employee, date);
                    if (!res) break;
                }
                Contract.GetContract();
                if (res) MessageBox.Show($"Все выбранные договоры успешно удалены!");
            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (tour_edit.Text != "")
            {
                string query = $"SELECT id FROM contract WHERE " +
                    $"tour_id = (SELECT id FROM tour WHERE tour.name = \"{tour_edit.Text}\") AND " +
                    $"client_id = (SELECT id FROM client WHERE client.name = \"{client_edit.Text}\") AND " +
                    $"employee_id = (SELECT id FROM employee WHERE employee.name = \"{employee_edit.Text}\") AND " +
                    $"reg_date = \"{date_edit.Text + ":00"}\";";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой договор уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_edit_Click(sender, e);
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = contracts.SelectedRows[0];
                        string old_tour = row.Cells["Тур"].Value.ToString();
                        string old_client = row.Cells["Клиент"].Value.ToString();
                        string old_employee = row.Cells["Сотрудник"].Value.ToString();

                        string old_date;
                        try
                        {
                            old_date = DateTime.ParseExact(row.Cells["Дата оформления"].Value.ToString(),
                            "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                        }
                        catch
                        {
                            old_date = DateTime.ParseExact(row.Cells["Дата оформления"].Value.ToString(),
                            "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm") + ":00";
                        }
                        if (Contract.EditContract(old_tour, tour_edit.Text, old_client, client_edit.Text,
                            old_employee, employee_edit.Text,
                            old_date, date_edit.Text + ":00"))
                        {
                            MessageBox.Show("Данные о договоре изменены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Contract.GetContract();
                        }
                        else
                        {
                            MessageBox.Show("Данные о договоре не были изменены!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Пожалуйста, выберите строку для редактирования!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность заполнения полей!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn(object sender, EventArgs e)
        {
            
        }

        private void clear_edit_Click(object sender, EventArgs e)
        {
            
        }

        private void city_add_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Договор PDF-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                GeneratePdfFromTemplate(sfd.FileName);
                MessageBox.Show("Договор успешно сохранён и готов к печати!");
            }
        }

        private void GeneratePdfFromTemplate(string destinationFilePath)
        {
            string templateFileName = "Договор-Шаблон.docx";
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string sourceFilePath = Path.Combine(solutionDirectory, templateFileName);

            Application wordApp = new Application();

            Document wordDoc = wordApp.Documents.Open(sourceFilePath);

            wordDoc.SaveAs2(destinationFilePath, WdSaveFormat.wdFormatPDF);

            wordDoc.Close();

            wordApp.Quit();
        }
    }
}

