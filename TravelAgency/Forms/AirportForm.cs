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
    public partial class AirportForm : Form
    {
        int originalHeight;
        public AirportForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AirportForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            City.GetCity();
            comboBox1.DataSource = City.dtCity;
            comboBox1.DisplayMember = "Название";
            comboBox2.DataSource = City.dtCity;
            comboBox2.DisplayMember = "Название";
            Airport.GetAirport();
            
            airports.DataSource = Airport.dtAirport;
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
            clear_add_btn_Click(sender, e);
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
            clear_edit_btn_Click(sender, e);
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
            clear_add_btn_Click(sender, e);
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
            clear_edit_btn_Click(sender, e);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (Airport.ValidateIATA(textBox1.Text)
                && textBox2.Text != ""
                && comboBox1.Text != "")
            {
                string query = $"SELECT id FROM airport WHERE id = \"{textBox1.Text}\"";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Аэропорт с таким кодом уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_add_btn_Click(sender, e);
                }
                else
                {
                    if (Airport.AddAirport(textBox1.Text, textBox2.Text, comboBox1.Text))
                    {
                        MessageBox.Show("Аэропорт добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear_add_btn_Click(sender, e);
                        Airport.GetAirport();
                    }
                    else
                    {
                        MessageBox.Show("Аэропорт не был добавлен!");
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
            if (airports.SelectedRows.Count > 0)
            {
                var result = Airport.DeleteAirport(airports.Rows[airports.SelectedRows[0].Index].Cells[0].Value.ToString());
                Airport.GetAirport();
                if (result) MessageBox.Show($"Аэропорт успешно удалён!");
            }
            else
            {
                MessageBox.Show("Запись не выбрана!");
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != ""
                && Airport.ValidateIATA(textBox6.Text)
                && comboBox2.Text != "")
            {
                string query = $"SELECT id FROM airport WHERE id = \"{textBox6.Text}\" AND " +
                    $"name = \"{textBox5.Text}\" AND city_id =" +
                    $"(SELECT id FROM city WHERE  city.name = \"{comboBox2.Text}\")";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой аэропорт уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear_edit_btn_Click(sender, e);
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = airports.SelectedRows[0];
                        string IATA_old = row.Cells["IATA код"].Value.ToString();
                        string name_old = row.Cells["Название"].Value.ToString();
                        string city_id_old = row.Cells["Город"].Value.ToString();
                        if (Airport.EditAirport(IATA_old, name_old, city_id_old,
                            textBox6.Text.ToUpper(), textBox5.Text, comboBox2.Text))
                        {
                            MessageBox.Show("Аэропорт добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear_add_btn_Click(sender, e);
                            Airport.GetAirport();
                        }
                        else
                        {
                            MessageBox.Show("Аэропорт не был добавлен!");
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

        private void clear_add_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void clear_edit_btn_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
