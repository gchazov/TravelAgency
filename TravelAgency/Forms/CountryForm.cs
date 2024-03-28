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

namespace TravelAgency.Forms
{
    public partial class CountryForm : Form
    {
        int originalHeight;
        public CountryForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CountryForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Country.GetCountry();
            countries.DataSource = Country.dtCountry;
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
            name_field_add.Text = "";
            id_field_add.Text = "";
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
            name_field_edit.Text = "";
            id_field_edit.Text = "";
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
            id_field_add.Text = "";
            name_field_add.Text = "";
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
            id_field_edit.Text = "";
            name_field_edit.Text = "";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (name_field_add.Text != ""
                && Country.ValidateOKSM(id_field_add.Text))
            {
                string query = $"SELECT id FROM Country WHERE id = \"{id_field_add.Text}\"" +
                    $"OR name = \"{name_field_add.Text}\"";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Страна с таким кодом уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    name_field_add.Text = "";
                    id_field_add.Text = "";
                }
                else
                {
                    if (Country.AddCountry(id_field_add.Text, name_field_add.Text))
                    {
                        MessageBox.Show("Страна добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        name_field_add.Text = "";
                        id_field_add.Text = "";
                        Country.GetCountry();
                    }
                    else
                    {
                        MessageBox.Show("Страна не была добавлена!");
                    }
                }
            }
            else
            {
                id_field_add.Text = "";
                name_field_add.Text = "";
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
            if (countries.SelectedRows.Count > 0)
            {
                var res = Country.DeleteCountry(countries.Rows[countries.SelectedRows[0].Index].Cells[0].Value.ToString());
                Country.GetCountry();
                if (res) MessageBox.Show($"Страна успешно удалена!");
            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (Country.ValidateOKSM(id_field_add.Text)
                && name_field_edit.Text != "")
            {
                string query = $"SELECT id FROM country WHERE name =\"{name_field_edit.Text}\";";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такая страна уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id_field_edit.Text = "";
                    name_field_edit.Text = "";
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = countries.SelectedRows[0];
                        string old_code = row.Cells["ОКСМ код"].Value.ToString();
                        string old_name = row.Cells["Название"].Value.ToString();
                        if (Country.EditCountry(old_code, id_field_edit.Text, old_name, name_field_edit.Text))
                        {
                            MessageBox.Show("Данные о стране изменены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            id_field_edit.Text = "";
                            name_field_edit.Text = "";
                            Country.GetCountry();
                        }
                        else
                        {
                            MessageBox.Show("Данные о стране не были изменены!");
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
