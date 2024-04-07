using System;
using System.Windows.Forms;
using TravelAgency.Tables;

namespace TravelAgency.Forms
{
    public partial class EmployeeForm : Form
    {
        int originalHeight;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Office.GetOffice();
            office_add.DataSource = Office.dtOffice.Copy();
            office_add.DisplayMember = "Адрес";
            office_edit.DataSource = Office.dtOffice.Copy();
            office_edit.DisplayMember = "Адрес";

            Employee.GetEmployee();
            employees.DataSource = Employee.dtEmployee;

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
            if (name_add.Text != ""
                && address_add.Text != "" &&
                Office.ValidatePhone(phone_add.Text) &&
                Employee.ValidatePassport(passport_add.Text) &&
                position_add.Text != "")

            {
                string query = $"SELECT id FROM employee WHERE name = \"{name_add.Text}\" " +
                    $"AND address = \"{address_add.Text}\" " +
                    $"AND passport = \"{passport_add.Text}\" AND " +
                    $"phone = \"{phone_add.Text}\" AND " +
                    $"position = \"{position_add.Text}\" AND " +
                    $"office_id = (SELECT office.id FROM office WHERE " +
                    $"office.address = \"{office_add.Text}\")";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой сотрудник уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_btn(sender, e);
                }
                else
                {
                    if (Employee.AddEmployee(name_add.Text, address_add.Text, passport_add.Text, phone_add.Text,
                        position_add.Text, office_add.Text))
                    {
                        MessageBox.Show("Сотрудник добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear_btn(sender, e);
                        Employee.GetEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Сотрудник не был добавлен!");
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
            if (employees.SelectedRows.Count > 0)
            {
                string name, address, passport, phone, position, office;
                var res = false;
                foreach (DataGridViewRow row in employees.SelectedRows)
                {
                    name = row.Cells["ФИО"].Value.ToString();
                    address = row.Cells["Адрес"].Value.ToString();
                    passport = row.Cells["Паспорт"].Value.ToString();
                    phone = row.Cells["Телефон"].Value.ToString();
                    position = row.Cells["Должность"].Value.ToString();
                    office = row.Cells["Адрес работы"].Value.ToString();
                    res = Employee.DeleteEmployee(name, address, passport, phone, position, office);
                    if (!res) break;
                }
                Employee.GetEmployee();
                if (res) MessageBox.Show($"Все выбранные сотрудники успешно удалены!");
            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (name_edit.Text != "" &&
                address_edit.Text != "" &&
                Office.ValidatePhone(phone_edit.Text) &&
                 Employee.ValidatePassport(passport_edit.Text) &&
                 position_edit.Text != "")
            {
                string query = $"SELECT id FROM employee WHERE name =  \"{name_edit.Text}\" " +
                    $"AND address = \"{address_edit.Text}\" " +
                    $"AND passport = \"{passport_edit.Text}\" AND " +
                    $"phone = \"{phone_edit.Text}\" AND " +
                    $"position = \"{position_edit.Text}\" AND " +
                    $"office_id = (SELECT office.id FROM office WHERE " +
                    $"office.address = \"{office_edit.Text}\")";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой сотрудник уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_edit_Click(sender, e);
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = employees.SelectedRows[0];
                        string old_name = row.Cells["ФИО"].Value.ToString();
                        string old_address = row.Cells["Адрес"].Value.ToString();
                        string old_phone = row.Cells["Телефон"].Value.ToString();
                        string old_passport = row.Cells["Паспорт"].Value.ToString();
                        string old_position = row.Cells["Должность"].Value.ToString();
                        string old_office = row.Cells["Адрес работы"].Value.ToString();
                        if (Employee.EditEmployee(old_name, name_edit.Text, old_address, address_edit.Text,
                            old_passport, passport_edit.Text, old_phone, phone_edit.Text,
                            old_position, position_edit.Text, old_office, office_edit.Text))
                        {
                            MessageBox.Show("Данные о сотруднике изменены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            name_edit.Text = "";
                            Employee.GetEmployee();
                        }
                        else
                        {
                            MessageBox.Show("Данные о сотруднике не были изменены!");
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
            name_add.Text = "";
            address_add.Text = "";
            passport_add.Text = "";
            phone_add.Text = "";
            office_add.Text = "";
            position_add.Text = "";
        }

        private void clear_edit_Click(object sender, EventArgs e)
        {
            name_edit.Text = "";
            address_edit.Text = "";
            passport_edit.Text = "";
            phone_edit.Text = "";
            office_add.Text = "";
            position_add.Text = "";
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Сотрудники PDF-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToPDF(employees, sfd.FileName);
            }
        }

        private void excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "Сотрудники Excel-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToExcel(employees, sfd.FileName);
            }
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            button4_Click(sender, e);
        }
    }
}
