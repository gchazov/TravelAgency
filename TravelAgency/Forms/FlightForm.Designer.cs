namespace TravelAgency.Forms
{
    partial class FlightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightForm));
            this.flights = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tour_add = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.flight_company_add = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.airport_to_add = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.airport_from_add = new System.Windows.Forms.ComboBox();
            this.date_arr_add = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.date_dep_add = new System.Windows.Forms.DateTimePicker();
            this.clear_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.canceladditbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.id_add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clear_edit = new System.Windows.Forms.Button();
            this.tour_edit = new System.Windows.Forms.ComboBox();
            this.canceleditbtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.editbtn = new System.Windows.Forms.Button();
            this.flight_company_edit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.airport_to_edit = new System.Windows.Forms.ComboBox();
            this.id_edit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.date_dep_edit = new System.Windows.Forms.DateTimePicker();
            this.airport_from_edit = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.date_arr_edit = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.excel = new System.Windows.Forms.Button();
            this.pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flights)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flights
            // 
            this.flights.AllowUserToAddRows = false;
            this.flights.AllowUserToDeleteRows = false;
            this.flights.AllowUserToResizeColumns = false;
            this.flights.AllowUserToResizeRows = false;
            this.flights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flights.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.flights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flights.Location = new System.Drawing.Point(17, 50);
            this.flights.Margin = new System.Windows.Forms.Padding(4);
            this.flights.Name = "flights";
            this.flights.ReadOnly = true;
            this.flights.RowHeadersWidth = 51;
            this.flights.RowTemplate.Height = 24;
            this.flights.Size = new System.Drawing.Size(818, 220);
            this.flights.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tour_add);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.flight_company_add);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.airport_to_add);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.airport_from_add);
            this.groupBox1.Controls.Add(this.date_arr_add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_dep_add);
            this.groupBox1.Controls.Add(this.clear_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.canceladditbtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.id_add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(25, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 439);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Выберите тур:";
            // 
            // tour_add
            // 
            this.tour_add.FormattingEnabled = true;
            this.tour_add.Location = new System.Drawing.Point(10, 355);
            this.tour_add.Name = "tour_add";
            this.tour_add.Size = new System.Drawing.Size(274, 30);
            this.tour_add.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(205, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Введите авиакомпанию:";
            // 
            // flight_company_add
            // 
            this.flight_company_add.Location = new System.Drawing.Point(209, 57);
            this.flight_company_add.MaxLength = 45;
            this.flight_company_add.Name = "flight_company_add";
            this.flight_company_add.Size = new System.Drawing.Size(216, 30);
            this.flight_company_add.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Выберите аэропорт прибытия:";
            // 
            // airport_to_add
            // 
            this.airport_to_add.FormattingEnabled = true;
            this.airport_to_add.Location = new System.Drawing.Point(10, 297);
            this.airport_to_add.Name = "airport_to_add";
            this.airport_to_add.Size = new System.Drawing.Size(274, 30);
            this.airport_to_add.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Выберите аэропорт вылета:";
            // 
            // airport_from_add
            // 
            this.airport_from_add.FormattingEnabled = true;
            this.airport_from_add.Location = new System.Drawing.Point(10, 239);
            this.airport_from_add.Name = "airport_from_add";
            this.airport_from_add.Size = new System.Drawing.Size(274, 30);
            this.airport_from_add.TabIndex = 9;
            // 
            // date_arr_add
            // 
            this.date_arr_add.Location = new System.Drawing.Point(10, 181);
            this.date_arr_add.Name = "date_arr_add";
            this.date_arr_add.Size = new System.Drawing.Size(226, 30);
            this.date_arr_add.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Выберите дату прибытия:";
            // 
            // date_dep_add
            // 
            this.date_dep_add.Location = new System.Drawing.Point(10, 115);
            this.date_dep_add.Name = "date_dep_add";
            this.date_dep_add.Size = new System.Drawing.Size(226, 30);
            this.date_dep_add.TabIndex = 7;
            // 
            // clear_add
            // 
            this.clear_add.BackColor = System.Drawing.Color.Violet;
            this.clear_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_add.Location = new System.Drawing.Point(209, 391);
            this.clear_add.Name = "clear_add";
            this.clear_add.Size = new System.Drawing.Size(95, 38);
            this.clear_add.TabIndex = 14;
            this.clear_add.Text = "Очистить";
            this.clear_add.UseVisualStyleBackColor = false;
            this.clear_add.Click += new System.EventHandler(this.clear_btn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите код рейса:";
            // 
            // canceladditbtn
            // 
            this.canceladditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceladditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceladditbtn.Location = new System.Drawing.Point(108, 391);
            this.canceladditbtn.Name = "canceladditbtn";
            this.canceladditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceladditbtn.TabIndex = 13;
            this.canceladditbtn.Text = "Отменить";
            this.canceladditbtn.UseVisualStyleBackColor = false;
            this.canceladditbtn.Click += new System.EventHandler(this.canceladditbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Lime;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbtn.Location = new System.Drawing.Point(10, 391);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(95, 38);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // id_add
            // 
            this.id_add.Location = new System.Drawing.Point(10, 57);
            this.id_add.MaxLength = 7;
            this.id_add.Name = "id_add";
            this.id_add.Size = new System.Drawing.Size(126, 30);
            this.id_add.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите дату вылета:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(858, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть панель редактирования";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(858, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить выбранные";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.Location = new System.Drawing.Point(858, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.clear_edit);
            this.groupBox2.Controls.Add(this.tour_edit);
            this.groupBox2.Controls.Add(this.canceleditbtn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.editbtn);
            this.groupBox2.Controls.Add(this.flight_company_edit);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.airport_to_edit);
            this.groupBox2.Controls.Add(this.id_edit);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.date_dep_edit);
            this.groupBox2.Controls.Add(this.airport_from_edit);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.date_arr_edit);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(503, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 439);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактировать";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 22);
            this.label9.TabIndex = 40;
            this.label9.Text = "Выберите тур:";
            // 
            // clear_edit
            // 
            this.clear_edit.BackColor = System.Drawing.Color.Violet;
            this.clear_edit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_edit.Location = new System.Drawing.Point(208, 392);
            this.clear_edit.Name = "clear_edit";
            this.clear_edit.Size = new System.Drawing.Size(95, 38);
            this.clear_edit.TabIndex = 24;
            this.clear_edit.Text = "Очистить";
            this.clear_edit.UseVisualStyleBackColor = false;
            this.clear_edit.Click += new System.EventHandler(this.clear_edit_Click);
            // 
            // tour_edit
            // 
            this.tour_edit.FormattingEnabled = true;
            this.tour_edit.Location = new System.Drawing.Point(11, 355);
            this.tour_edit.Name = "tour_edit";
            this.tour_edit.Size = new System.Drawing.Size(274, 30);
            this.tour_edit.TabIndex = 21;
            // 
            // canceleditbtn
            // 
            this.canceleditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceleditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceleditbtn.Location = new System.Drawing.Point(107, 391);
            this.canceleditbtn.Name = "canceleditbtn";
            this.canceleditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceleditbtn.TabIndex = 23;
            this.canceleditbtn.Text = "Отменить";
            this.canceleditbtn.UseVisualStyleBackColor = false;
            this.canceleditbtn.Click += new System.EventHandler(this.canceleditbtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(206, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 22);
            this.label10.TabIndex = 38;
            this.label10.Text = "Введите авиакомпанию:";
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Orange;
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editbtn.Location = new System.Drawing.Point(6, 391);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(95, 38);
            this.editbtn.TabIndex = 22;
            this.editbtn.Text = "Изменить";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // flight_company_edit
            // 
            this.flight_company_edit.Location = new System.Drawing.Point(210, 57);
            this.flight_company_edit.MaxLength = 45;
            this.flight_company_edit.Name = "flight_company_edit";
            this.flight_company_edit.Size = new System.Drawing.Size(216, 30);
            this.flight_company_edit.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(7, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 22);
            this.label14.TabIndex = 29;
            this.label14.Text = "Введите код рейса:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "Выберите аэропорт прибытия:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(7, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(230, 22);
            this.label15.TabIndex = 27;
            this.label15.Text = "Выберите дату вылета:";
            // 
            // airport_to_edit
            // 
            this.airport_to_edit.FormattingEnabled = true;
            this.airport_to_edit.Location = new System.Drawing.Point(11, 297);
            this.airport_to_edit.Name = "airport_to_edit";
            this.airport_to_edit.Size = new System.Drawing.Size(274, 30);
            this.airport_to_edit.TabIndex = 20;
            // 
            // id_edit
            // 
            this.id_edit.Location = new System.Drawing.Point(11, 57);
            this.id_edit.MaxLength = 7;
            this.id_edit.Name = "id_edit";
            this.id_edit.Size = new System.Drawing.Size(126, 30);
            this.id_edit.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(278, 22);
            this.label12.TabIndex = 34;
            this.label12.Text = "Выберите аэропорт вылета:";
            // 
            // date_dep_edit
            // 
            this.date_dep_edit.Location = new System.Drawing.Point(11, 115);
            this.date_dep_edit.Name = "date_dep_edit";
            this.date_dep_edit.Size = new System.Drawing.Size(226, 30);
            this.date_dep_edit.TabIndex = 17;
            // 
            // airport_from_edit
            // 
            this.airport_from_edit.FormattingEnabled = true;
            this.airport_from_edit.Location = new System.Drawing.Point(11, 239);
            this.airport_from_edit.Name = "airport_from_edit";
            this.airport_from_edit.Size = new System.Drawing.Size(274, 30);
            this.airport_from_edit.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(7, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 22);
            this.label13.TabIndex = 31;
            this.label13.Text = "Выберите дату прибытия:";
            // 
            // date_arr_edit
            // 
            this.date_arr_edit.Location = new System.Drawing.Point(11, 181);
            this.date_arr_edit.Name = "date_arr_edit";
            this.date_arr_edit.Size = new System.Drawing.Size(226, 30);
            this.date_arr_edit.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(261, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(349, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Таблица \"Авиарейсы\"";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(17, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 462);
            this.panel1.TabIndex = 8;
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.excel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excel.Location = new System.Drawing.Point(98, 20);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(75, 23);
            this.excel.TabIndex = 14;
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
            this.pdf.TabIndex = 13;
            this.pdf.Text = "PDF";
            this.pdf.UseVisualStyleBackColor = false;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1035, 283);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flights);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авиарейсы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightForm_FormClosing);
            this.Load += new System.EventHandler(this.FlightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flights)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView flights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button canceladditbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox id_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_add;
        private System.Windows.Forms.Button clear_edit;
        private System.Windows.Forms.Button canceleditbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox flight_company_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox airport_to_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox airport_from_add;
        private System.Windows.Forms.DateTimePicker date_arr_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_dep_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tour_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tour_edit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox flight_company_edit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox airport_to_edit;
        private System.Windows.Forms.TextBox id_edit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker date_dep_edit;
        private System.Windows.Forms.ComboBox airport_from_edit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker date_arr_edit;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button pdf;
    }
}