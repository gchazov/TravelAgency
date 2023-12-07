using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Tables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgency.Forms
{
    public partial class OfficeForm : Form
    {
        int originalHeight;
        public OfficeForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OfficeForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            Office.GetOffice();
            offices.DataSource = Office.dtOffice;
            
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
            address_add.Text = "";
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
            address_edit.Text = "";
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
            address_add.Text = "";
            CEO_add.Text = "";
            phone_add.Text = "";
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
            address_edit.Text = "";
            CEO_edit.Text = "";
            phone_edit.Text = "";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (address_add.Text != ""
                && CEO_add.Text != "" &&
                phone_add.Text != "")

            {
                string query = $"SELECT id FROM office WHERE address = \"{address_add.Text}\" " +
                    $"AND CEO_name = \"{CEO_add.Text}\" AND " +
                    $"phone = \"{phone_add.Text}\"";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Филиал с таким кодом уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    address_add.Text = "";
                    CEO_add.Text = "";
                    phone_add.Text = "";
                }
                else
                {
                    if (Office.AddOffice(address_add.Text, CEO_add.Text, phone_add.Text))
                    {
                        MessageBox.Show("Филиал добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        address_add.Text = "";
                        address_add.Text = "";
                        Office.GetOffice();
                    }
                    else
                    {
                        MessageBox.Show("Филиал не был добавлен!");
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
            if (offices.SelectedRows.Count > 0)
            {
                string address, CEO, phone;
                foreach(DataGridViewRow row in offices.SelectedRows)
                {
                    address = row.Cells["Адрес"].Value.ToString();
                    CEO = row.Cells["ФИО директора"].Value.ToString();
                    phone = row.Cells["Телефон"].Value.ToString();
                    Office.DeleteOffice(address, CEO, phone);
                }
                Office.GetOffice();
                MessageBox.Show($"Все выбранные филиалы успешно удалены!");
            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (address_edit.Text != "" &&
                CEO_edit.Text != "" &&
                phone_edit.Text != "")
            {
                string query = $"SELECT id FROM office WHERE address =\"{address_edit.Text}\" AND " +
                    $"CEO_name = \"{CEO_edit.Text}\" AND phone = \"{phone_edit.Text}\";";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой филиал уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    address_edit.Text = "";
                    CEO_edit.Text = "";
                    phone_edit.Text = "";
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = offices.SelectedRows[0];
                        string old_address = row.Cells["Адрес"].Value.ToString();
                        string old_CEO = row.Cells["ФИО директора"].Value.ToString();
                        string old_phone = row.Cells["Телефон"].Value.ToString();
                        if (Office.EditOffice(old_address, address_edit.Text, old_CEO, CEO_edit.Text, 
                            old_phone, phone_edit.Text))
                        {
                            MessageBox.Show("Данные о филиале изменены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            address_edit.Text = "";
                            Office.GetOffice();
                        }
                        else
                        {
                            MessageBox.Show("Данные о филиале не были изменены!");
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
    }
}
