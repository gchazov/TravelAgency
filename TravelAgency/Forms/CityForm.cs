using System;
using System.Drawing;
using System.Windows.Forms;
using TravelAgency.Tables;

namespace TravelAgency.Forms
{
    public partial class CityForm : Form
    {
        int originalHeight;
        public CityForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CityForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            Country.GetCountry();
            addCountry.DataSource = Country.dtCountry.Copy();
            addCountry.DisplayMember = "Название";
            editCountry.DataSource = Country.dtCountry.Copy();
            editCountry.DisplayMember = "Название";
            City.GetCity();
            cities.DataSource = City.dtCity;
            originalHeight = this.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Height == originalHeight)
            {
                this.Height = groupBox1.Height + originalHeight + 40;
                button1.Text = "Скрыть панель редактирования";
                button1.BackColor = Color.Orange;
            }
            else
            {
                this.Height -= groupBox1.Height + 40;
                button1.Text = "Открыть панель редактирования";
                button1.BackColor = Color.Lime;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            name_field_add.Text = "";
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
            name_field_edit.Text = "";
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (name_field_add.Text != "")

            {
                string query = $"SELECT id FROM city WHERE name = \"{name_field_add.Text}\" " +
                    $"AND country_id = (SELECT id FROM country WHERE name = \"{addCountry.Text}\")";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Город с таким кодом уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    name_field_add.Text = "";
                }
                else
                {
                    if (City.AddCity(name_field_add.Text, addCountry.Text))
                    {
                        MessageBox.Show("Город добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        name_field_add.Text = "";
                        name_field_add.Text = "";
                        City.GetCity();
                    }
                    else
                    {
                        MessageBox.Show("Город не был добавлен!");
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
            if (cities.SelectedRows.Count > 0)
            {
                var res = City.DeleteCity(cities.Rows[cities.SelectedRows[0].Index].Cells[0].Value.ToString());
                City.GetCity();
                if (res) MessageBox.Show($"Город успешно удален!");
            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (name_field_edit.Text != "")
            {
                string query = $"SELECT id FROM country WHERE name =\"{name_field_edit.Text}\";";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой город уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    name_field_edit.Text = "";
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = cities.SelectedRows[0];
                        string old_name = row.Cells["Название"].Value.ToString();
                        string old_country = row.Cells["Страна"].Value.ToString();
                        if (City.EditCity(old_name, name_field_edit.Text, old_country, editCountry.Text))
                        {
                            MessageBox.Show("Данные о городе изменены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            name_field_edit.Text = "";
                            City.GetCity();
                        }
                        else
                        {
                            MessageBox.Show("Данные о городе не были изменены!");
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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Города PDF-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToPDF(cities, sfd.FileName);
            }
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            sfd.FileName = "Города Excel-отчет от " + DateTime.Now.ToString("dd-MM-yyyy HH-mm");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MainPanel.ExportToExcel(cities, sfd.FileName);
            }
        }

        private void CityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            button4_Click(sender, e);
        }
    }
}
