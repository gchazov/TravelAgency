namespace TravelAgency.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.employees = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.office_add = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.position_add = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clear_add = new System.Windows.Forms.Button();
            this.passport_add = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phone_add = new System.Windows.Forms.TextBox();
            this.address_add = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canceladditbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.name_add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.name_edit = new System.Windows.Forms.TextBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.canceleditbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.office_edit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.position_edit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clear_edit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.passport_edit = new System.Windows.Forms.TextBox();
            this.phone_edit = new System.Windows.Forms.TextBox();
            this.address_edit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.excel = new System.Windows.Forms.Button();
            this.pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employees
            // 
            this.employees.AllowUserToAddRows = false;
            this.employees.AllowUserToDeleteRows = false;
            this.employees.AllowUserToResizeColumns = false;
            this.employees.AllowUserToResizeRows = false;
            this.employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employees.BackgroundColor = System.Drawing.Color.Moccasin;
            this.employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees.Location = new System.Drawing.Point(17, 50);
            this.employees.Margin = new System.Windows.Forms.Padding(4);
            this.employees.Name = "employees";
            this.employees.ReadOnly = true;
            this.employees.RowHeadersWidth = 51;
            this.employees.RowTemplate.Height = 24;
            this.employees.Size = new System.Drawing.Size(772, 220);
            this.employees.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.office_add);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.position_add);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.clear_add);
            this.groupBox1.Controls.Add(this.passport_add);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.phone_add);
            this.groupBox1.Controls.Add(this.address_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.canceladditbtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.name_add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(36, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 429);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // office_add
            // 
            this.office_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.office_add.FormattingEnabled = true;
            this.office_add.Location = new System.Drawing.Point(9, 346);
            this.office_add.Name = "office_add";
            this.office_add.Size = new System.Drawing.Size(263, 25);
            this.office_add.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(5, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 18);
            this.label12.TabIndex = 16;
            this.label12.Text = "Выберите адрес работы:";
            // 
            // position_add
            // 
            this.position_add.Location = new System.Drawing.Point(10, 288);
            this.position_add.MaxLength = 45;
            this.position_add.Name = "position_add";
            this.position_add.Size = new System.Drawing.Size(264, 25);
            this.position_add.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Введите должность: ";
            // 
            // clear_add
            // 
            this.clear_add.BackColor = System.Drawing.Color.Violet;
            this.clear_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_add.Location = new System.Drawing.Point(209, 383);
            this.clear_add.Name = "clear_add";
            this.clear_add.Size = new System.Drawing.Size(95, 38);
            this.clear_add.TabIndex = 13;
            this.clear_add.Text = "Очистить";
            this.clear_add.UseVisualStyleBackColor = false;
            this.clear_add.Click += new System.EventHandler(this.clear_btn);
            // 
            // passport_add
            // 
            this.passport_add.Location = new System.Drawing.Point(10, 173);
            this.passport_add.MaxLength = 10;
            this.passport_add.Name = "passport_add";
            this.passport_add.Size = new System.Drawing.Size(264, 25);
            this.passport_add.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Введите паспорт:";
            // 
            // phone_add
            // 
            this.phone_add.Location = new System.Drawing.Point(10, 230);
            this.phone_add.MaxLength = 11;
            this.phone_add.Name = "phone_add";
            this.phone_add.Size = new System.Drawing.Size(179, 25);
            this.phone_add.TabIndex = 8;
            // 
            // address_add
            // 
            this.address_add.Location = new System.Drawing.Point(10, 115);
            this.address_add.MaxLength = 45;
            this.address_add.Name = "address_add";
            this.address_add.Size = new System.Drawing.Size(264, 25);
            this.address_add.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите телефон:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите ФИО: ";
            // 
            // canceladditbtn
            // 
            this.canceladditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceladditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceladditbtn.Location = new System.Drawing.Point(108, 383);
            this.canceladditbtn.Name = "canceladditbtn";
            this.canceladditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceladditbtn.TabIndex = 12;
            this.canceladditbtn.Text = "Отменить";
            this.canceladditbtn.UseVisualStyleBackColor = false;
            this.canceladditbtn.Click += new System.EventHandler(this.canceladditbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Lime;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbtn.Location = new System.Drawing.Point(10, 383);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(95, 38);
            this.addbtn.TabIndex = 11;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // name_add
            // 
            this.name_add.Location = new System.Drawing.Point(10, 57);
            this.name_add.MaxLength = 45;
            this.name_add.Name = "name_add";
            this.name_add.Size = new System.Drawing.Size(264, 25);
            this.name_add.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите адрес:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(820, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить сотрудника";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(820, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать выбранного";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(820, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить выбранного";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.Location = new System.Drawing.Point(820, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите адрес:";
            // 
            // name_edit
            // 
            this.name_edit.Location = new System.Drawing.Point(10, 57);
            this.name_edit.MaxLength = 45;
            this.name_edit.Name = "name_edit";
            this.name_edit.Size = new System.Drawing.Size(264, 25);
            this.name_edit.TabIndex = 14;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Orange;
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editbtn.Location = new System.Drawing.Point(10, 382);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(95, 38);
            this.editbtn.TabIndex = 20;
            this.editbtn.Text = "Изменить";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // canceleditbtn
            // 
            this.canceleditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceleditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceleditbtn.Location = new System.Drawing.Point(111, 382);
            this.canceleditbtn.Name = "canceleditbtn";
            this.canceleditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceleditbtn.TabIndex = 21;
            this.canceleditbtn.Text = "Отменить";
            this.canceleditbtn.UseVisualStyleBackColor = false;
            this.canceleditbtn.Click += new System.EventHandler(this.canceleditbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.office_edit);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.position_edit);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.clear_edit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.passport_edit);
            this.groupBox2.Controls.Add(this.phone_edit);
            this.groupBox2.Controls.Add(this.address_edit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.canceleditbtn);
            this.groupBox2.Controls.Add(this.editbtn);
            this.groupBox2.Controls.Add(this.name_edit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(581, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 429);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактировать";
            // 
            // office_edit
            // 
            this.office_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.office_edit.FormattingEnabled = true;
            this.office_edit.Location = new System.Drawing.Point(9, 346);
            this.office_edit.Name = "office_edit";
            this.office_edit.Size = new System.Drawing.Size(263, 25);
            this.office_edit.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(208, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Выберите адрес работы:";
            // 
            // position_edit
            // 
            this.position_edit.Location = new System.Drawing.Point(10, 289);
            this.position_edit.MaxLength = 45;
            this.position_edit.Name = "position_edit";
            this.position_edit.Size = new System.Drawing.Size(264, 25);
            this.position_edit.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Введите должность: ";
            // 
            // clear_edit
            // 
            this.clear_edit.BackColor = System.Drawing.Color.Violet;
            this.clear_edit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_edit.Location = new System.Drawing.Point(212, 383);
            this.clear_edit.Name = "clear_edit";
            this.clear_edit.Size = new System.Drawing.Size(95, 38);
            this.clear_edit.TabIndex = 22;
            this.clear_edit.Text = "Очистить";
            this.clear_edit.UseVisualStyleBackColor = false;
            this.clear_edit.Click += new System.EventHandler(this.clear_edit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Введите паспорт:";
            // 
            // passport_edit
            // 
            this.passport_edit.Location = new System.Drawing.Point(10, 173);
            this.passport_edit.MaxLength = 10;
            this.passport_edit.Name = "passport_edit";
            this.passport_edit.Size = new System.Drawing.Size(264, 25);
            this.passport_edit.TabIndex = 16;
            // 
            // phone_edit
            // 
            this.phone_edit.Location = new System.Drawing.Point(10, 231);
            this.phone_edit.MaxLength = 11;
            this.phone_edit.Name = "phone_edit";
            this.phone_edit.Size = new System.Drawing.Size(179, 25);
            this.phone_edit.TabIndex = 17;
            // 
            // address_edit
            // 
            this.address_edit.Location = new System.Drawing.Point(10, 115);
            this.address_edit.MaxLength = 45;
            this.address_edit.Name = "address_edit";
            this.address_edit.Size = new System.Drawing.Size(264, 25);
            this.address_edit.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите ФИО:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(261, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Таблица \"Сотрудники\"";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(17, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 453);
            this.panel1.TabIndex = 8;
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.excel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excel.Location = new System.Drawing.Point(98, 20);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(75, 23);
            this.excel.TabIndex = 16;
            this.excel.Text = "Excel";
            this.excel.UseVisualStyleBackColor = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // pdf
            // 
            this.pdf.BackColor = System.Drawing.Color.Red;
            this.pdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pdf.Location = new System.Drawing.Point(17, 20);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(75, 23);
            this.pdf.TabIndex = 15;
            this.pdf.Text = "PDF";
            this.pdf.UseVisualStyleBackColor = false;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(973, 284);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeForm_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button canceladditbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox name_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_edit;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button canceleditbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone_add;
        private System.Windows.Forms.TextBox address_add;
        private System.Windows.Forms.TextBox phone_edit;
        private System.Windows.Forms.TextBox address_edit;
        private System.Windows.Forms.TextBox passport_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passport_edit;
        private System.Windows.Forms.Button clear_add;
        private System.Windows.Forms.Button clear_edit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox position_add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox position_edit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox office_add;
        private System.Windows.Forms.ComboBox office_edit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button pdf;
    }
}