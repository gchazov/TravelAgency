﻿namespace TravelAgency.Forms
{
    partial class HotelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            this.hotels = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.stars_add = new System.Windows.Forms.ComboBox();
            this.addCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.canceladditbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.name_field_add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.name_field_edit = new System.Windows.Forms.TextBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.canceleditbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clear_edit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.stars_edit = new System.Windows.Forms.ComboBox();
            this.editCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdf = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hotels)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotels
            // 
            this.hotels.AllowUserToAddRows = false;
            this.hotels.AllowUserToDeleteRows = false;
            this.hotels.AllowUserToResizeColumns = false;
            this.hotels.AllowUserToResizeRows = false;
            this.hotels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hotels.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.hotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotels.Location = new System.Drawing.Point(17, 50);
            this.hotels.Margin = new System.Windows.Forms.Padding(4);
            this.hotels.Name = "hotels";
            this.hotels.ReadOnly = true;
            this.hotels.RowHeadersWidth = 51;
            this.hotels.RowTemplate.Height = 24;
            this.hotels.Size = new System.Drawing.Size(596, 220);
            this.hotels.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.clear_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.stars_add);
            this.groupBox1.Controls.Add(this.addCity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.canceladditbtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.name_field_add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(18, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clear_add
            // 
            this.clear_add.BackColor = System.Drawing.Color.Violet;
            this.clear_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_add.Location = new System.Drawing.Point(210, 247);
            this.clear_add.Name = "clear_add";
            this.clear_add.Size = new System.Drawing.Size(95, 38);
            this.clear_add.TabIndex = 10;
            this.clear_add.Text = "Очистить";
            this.clear_add.UseVisualStyleBackColor = false;
            this.clear_add.Click += new System.EventHandler(this.clear_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выберите кол-во звёзд:";
            // 
            // stars_add
            // 
            this.stars_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stars_add.FormattingEnabled = true;
            this.stars_add.Location = new System.Drawing.Point(10, 206);
            this.stars_add.Name = "stars_add";
            this.stars_add.Size = new System.Drawing.Size(247, 35);
            this.stars_add.TabIndex = 7;
            // 
            // addCity
            // 
            this.addCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCity.FormattingEnabled = true;
            this.addCity.Location = new System.Drawing.Point(10, 131);
            this.addCity.Name = "addCity";
            this.addCity.Size = new System.Drawing.Size(247, 35);
            this.addCity.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите название: ";
            // 
            // canceladditbtn
            // 
            this.canceladditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceladditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceladditbtn.Location = new System.Drawing.Point(109, 247);
            this.canceladditbtn.Name = "canceladditbtn";
            this.canceladditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceladditbtn.TabIndex = 9;
            this.canceladditbtn.Text = "Отменить";
            this.canceladditbtn.UseVisualStyleBackColor = false;
            this.canceladditbtn.Click += new System.EventHandler(this.canceladditbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Lime;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbtn.Location = new System.Drawing.Point(11, 247);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(95, 38);
            this.addbtn.TabIndex = 8;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // name_field_add
            // 
            this.name_field_add.Location = new System.Drawing.Point(10, 57);
            this.name_field_add.MaxLength = 20;
            this.name_field_add.Name = "name_field_add";
            this.name_field_add.Size = new System.Drawing.Size(247, 36);
            this.name_field_add.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите город:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(635, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть панель редактирования";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(635, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить выбранные";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.Location = new System.Drawing.Point(635, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите город:";
            // 
            // name_field_edit
            // 
            this.name_field_edit.Location = new System.Drawing.Point(10, 57);
            this.name_field_edit.MaxLength = 20;
            this.name_field_edit.Name = "name_field_edit";
            this.name_field_edit.Size = new System.Drawing.Size(264, 36);
            this.name_field_edit.TabIndex = 11;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Orange;
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editbtn.Location = new System.Drawing.Point(9, 247);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(95, 38);
            this.editbtn.TabIndex = 14;
            this.editbtn.Text = "Изменить";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // canceleditbtn
            // 
            this.canceleditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceleditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceleditbtn.Location = new System.Drawing.Point(110, 247);
            this.canceleditbtn.Name = "canceleditbtn";
            this.canceleditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceleditbtn.TabIndex = 15;
            this.canceleditbtn.Text = "Отменить";
            this.canceleditbtn.UseVisualStyleBackColor = false;
            this.canceleditbtn.Click += new System.EventHandler(this.canceleditbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clear_edit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.stars_edit);
            this.groupBox2.Controls.Add(this.editCity);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.canceleditbtn);
            this.groupBox2.Controls.Add(this.editbtn);
            this.groupBox2.Controls.Add(this.name_field_edit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(410, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 291);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактировать";
            // 
            // clear_edit
            // 
            this.clear_edit.BackColor = System.Drawing.Color.Violet;
            this.clear_edit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_edit.Location = new System.Drawing.Point(211, 247);
            this.clear_edit.Name = "clear_edit";
            this.clear_edit.Size = new System.Drawing.Size(95, 38);
            this.clear_edit.TabIndex = 16;
            this.clear_edit.Text = "Очистить";
            this.clear_edit.UseVisualStyleBackColor = false;
            this.clear_edit.Click += new System.EventHandler(this.clear_edit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Выберите кол-во звёзд:";
            // 
            // stars_edit
            // 
            this.stars_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stars_edit.FormattingEnabled = true;
            this.stars_edit.Location = new System.Drawing.Point(10, 206);
            this.stars_edit.Name = "stars_edit";
            this.stars_edit.Size = new System.Drawing.Size(247, 35);
            this.stars_edit.TabIndex = 13;
            // 
            // editCity
            // 
            this.editCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editCity.FormattingEnabled = true;
            this.editCity.Location = new System.Drawing.Point(10, 130);
            this.editCity.Name = "editCity";
            this.editCity.Size = new System.Drawing.Size(247, 35);
            this.editCity.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите название:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(261, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Таблица \"Отели\"";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(17, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 316);
            this.panel1.TabIndex = 8;
            // 
            // pdf
            // 
            this.pdf.BackColor = System.Drawing.Color.Red;
            this.pdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pdf.Location = new System.Drawing.Point(17, 20);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(75, 23);
            this.pdf.TabIndex = 11;
            this.pdf.Text = "PDF";
            this.pdf.UseVisualStyleBackColor = false;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.excel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excel.Location = new System.Drawing.Point(98, 20);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(75, 23);
            this.excel.TabIndex = 12;
            this.excel.Text = "Excel";
            this.excel.UseVisualStyleBackColor = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(810, 281);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hotels);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "HotelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отели";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotelForm_FormClosing);
            this.Load += new System.EventHandler(this.HotelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotels)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hotels;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button canceladditbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox name_field_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_field_edit;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button canceleditbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox addCity;
        private System.Windows.Forms.ComboBox editCity;
        private System.Windows.Forms.ComboBox stars_add;
        private System.Windows.Forms.ComboBox stars_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clear_add;
        private System.Windows.Forms.Button clear_edit;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.Button excel;
    }
}