﻿using System;
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
    public partial class HotelForm : Form
    {
        int originalHeight;
        public HotelForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            City.GetCity();
            addCity.DisplayMember = "Название";
            editCity.DataSource = City.dtCity;
            editCity.DisplayMember = "Название";
            Hotel.GetHotel();
            hotels.DataSource = Hotel.dtHotel;
            addCity.DataSource = City.dtCity;
            
            string[] stars = new string[] { "1", "2", "3", "4", "5", "-" };
            stars_add.DataSource = stars;
            stars_edit.DataSource = stars;
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
                string query = $"SELECT id FROM hotel WHERE name = \"{name_field_add.Text}\" " +
                    $"AND city_id = (SELECT id FROM city WHERE name = \"{addCity.Text}\") AND " +
                    $"stars = {stars_add.Text}";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Отель с таким кодом уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    name_field_add.Text = "";
                }
                else
                {
                    if (Hotel.AddHotel(name_field_add.Text, addCity.Text, stars_add.Text))
                    {
                        MessageBox.Show("Отель добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        name_field_add.Text = "";
                        name_field_add.Text = "";
                        Hotel.GetHotel();
                    }
                    else
                    {
                        MessageBox.Show("Отель не был добавлен!");
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
            if (hotels.SelectedRows.Count > 0)
            {
                string name, stars, city;
                foreach(DataGridViewRow row in hotels.SelectedRows)
                {
                    name = row.Cells["Название"].Value.ToString();
                    stars = row.Cells["Количество звёзд"].Value.ToString();
                    city = row.Cells["Город"].Value.ToString();
                    Hotel.DeleteHotel(name, stars, city);
                }
                Hotel.GetHotel();
                MessageBox.Show($"Все выбранные отели успешно удалены!");
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
                string query = $"SELECT id FROM hotel WHERE name =\"{name_field_edit.Text}\" AND " +
                    $"city_id = (SELECT id FROM city WHERE name = \"{addCity.Text}\");";
                DBconnection.msCommand.CommandText = query;
                Object res = DBconnection.msCommand.ExecuteScalar();
                if (res != null)
                {
                    MessageBox.Show("Такой отель уже есть!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    name_field_edit.Text = "";
                }
                else
                {
                    try
                    {
                        DataGridViewRow row = hotels.SelectedRows[0];
                        string old_name = row.Cells["Название"].Value.ToString();
                        string old_city = row.Cells["Город"].Value.ToString();
                        string old_stars = row.Cells["Количество звёзд"].Value.ToString();
                        if (Hotel.EditHotel(old_name, name_field_edit.Text, old_city, editCity.Text, 
                            old_stars, stars_edit.Text))
                        {
                            MessageBox.Show("Данные об отеле изменены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            name_field_edit.Text = "";
                            Hotel.GetHotel();
                        }
                        else
                        {
                            MessageBox.Show("Данные об отеле не были изменены!");
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