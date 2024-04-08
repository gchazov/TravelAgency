namespace TravelAgency.Forms
{
    partial class TourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourForm));
            this.tours = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hotel_add = new System.Windows.Forms.ComboBox();
            this.city_add = new System.Windows.Forms.ComboBox();
            this.cost_add = new System.Windows.Forms.TextBox();
            this.duration_add = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_add = new System.Windows.Forms.DateTimePicker();
            this.meal_add = new System.Windows.Forms.TextBox();
            this.accomodation_add = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.clear_add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.canceladditbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.name_add = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hotel_edit = new System.Windows.Forms.ComboBox();
            this.clear_edit = new System.Windows.Forms.Button();
            this.city_edit = new System.Windows.Forms.ComboBox();
            this.canceleditbtn = new System.Windows.Forms.Button();
            this.cost_edit = new System.Windows.Forms.TextBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.duration_edit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_edit = new System.Windows.Forms.TextBox();
            this.date_edit = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.meal_edit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.accomodation_edit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdf = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tours)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tours
            // 
            this.tours.AllowUserToAddRows = false;
            this.tours.AllowUserToDeleteRows = false;
            this.tours.AllowUserToResizeColumns = false;
            this.tours.AllowUserToResizeRows = false;
            this.tours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tours.BackgroundColor = System.Drawing.Color.Thistle;
            this.tours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tours.Location = new System.Drawing.Point(17, 50);
            this.tours.Margin = new System.Windows.Forms.Padding(4);
            this.tours.Name = "tours";
            this.tours.ReadOnly = true;
            this.tours.RowHeadersWidth = 51;
            this.tours.RowTemplate.Height = 24;
            this.tours.Size = new System.Drawing.Size(772, 220);
            this.tours.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.hotel_add);
            this.groupBox1.Controls.Add(this.city_add);
            this.groupBox1.Controls.Add(this.cost_add);
            this.groupBox1.Controls.Add(this.duration_add);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.date_add);
            this.groupBox1.Controls.Add(this.meal_add);
            this.groupBox1.Controls.Add(this.accomodation_add);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.clear_add);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.canceladditbtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.name_add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(25, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 429);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // hotel_add
            // 
            this.hotel_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotel_add.FormattingEnabled = true;
            this.hotel_add.Location = new System.Drawing.Point(10, 173);
            this.hotel_add.Name = "hotel_add";
            this.hotel_add.Size = new System.Drawing.Size(180, 30);
            this.hotel_add.TabIndex = 8;
            // 
            // city_add
            // 
            this.city_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.city_add.FormattingEnabled = true;
            this.city_add.Location = new System.Drawing.Point(10, 115);
            this.city_add.Name = "city_add";
            this.city_add.Size = new System.Drawing.Size(180, 30);
            this.city_add.TabIndex = 6;
            this.city_add.SelectedIndexChanged += new System.EventHandler(this.city_add_SelectedIndexChanged);
            // 
            // cost_add
            // 
            this.cost_add.Location = new System.Drawing.Point(230, 289);
            this.cost_add.MaxLength = 45;
            this.cost_add.Name = "cost_add";
            this.cost_add.Size = new System.Drawing.Size(108, 30);
            this.cost_add.TabIndex = 11;
            // 
            // duration_add
            // 
            this.duration_add.Location = new System.Drawing.Point(205, 150);
            this.duration_add.MaxLength = 45;
            this.duration_add.Name = "duration_add";
            this.duration_add.Size = new System.Drawing.Size(69, 30);
            this.duration_add.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(197, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Введите длительность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(226, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Введите стоимость:";
            // 
            // date_add
            // 
            this.date_add.Location = new System.Drawing.Point(10, 347);
            this.date_add.Name = "date_add";
            this.date_add.Size = new System.Drawing.Size(221, 30);
            this.date_add.TabIndex = 12;
            // 
            // meal_add
            // 
            this.meal_add.Location = new System.Drawing.Point(10, 288);
            this.meal_add.MaxLength = 45;
            this.meal_add.Name = "meal_add";
            this.meal_add.Size = new System.Drawing.Size(205, 30);
            this.meal_add.TabIndex = 10;
            // 
            // accomodation_add
            // 
            this.accomodation_add.Location = new System.Drawing.Point(10, 231);
            this.accomodation_add.MaxLength = 45;
            this.accomodation_add.Name = "accomodation_add";
            this.accomodation_add.Size = new System.Drawing.Size(243, 30);
            this.accomodation_add.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(5, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Введите дату начала:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "Введите тип питания:";
            // 
            // clear_add
            // 
            this.clear_add.BackColor = System.Drawing.Color.Violet;
            this.clear_add.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_add.Location = new System.Drawing.Point(209, 383);
            this.clear_add.Name = "clear_add";
            this.clear_add.Size = new System.Drawing.Size(95, 38);
            this.clear_add.TabIndex = 15;
            this.clear_add.Text = "Очистить";
            this.clear_add.UseVisualStyleBackColor = false;
            this.clear_add.Click += new System.EventHandler(this.clear_btn);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Выберите отель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Введите тип проживания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите название:";
            // 
            // canceladditbtn
            // 
            this.canceladditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceladditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceladditbtn.Location = new System.Drawing.Point(108, 383);
            this.canceladditbtn.Name = "canceladditbtn";
            this.canceladditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceladditbtn.TabIndex = 14;
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
            this.addbtn.TabIndex = 13;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // name_add
            // 
            this.name_add.Location = new System.Drawing.Point(10, 57);
            this.name_add.MaxLength = 45;
            this.name_add.Name = "name_add";
            this.name_add.Size = new System.Drawing.Size(264, 30);
            this.name_add.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите город:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(820, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 92);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть панель редактирования";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(820, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить выбранные";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.Location = new System.Drawing.Point(820, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hotel_edit);
            this.groupBox2.Controls.Add(this.clear_edit);
            this.groupBox2.Controls.Add(this.city_edit);
            this.groupBox2.Controls.Add(this.canceleditbtn);
            this.groupBox2.Controls.Add(this.cost_edit);
            this.groupBox2.Controls.Add(this.editbtn);
            this.groupBox2.Controls.Add(this.duration_edit);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.name_edit);
            this.groupBox2.Controls.Add(this.date_edit);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.meal_edit);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.accomodation_edit);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(484, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 429);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактировать";
            // 
            // hotel_edit
            // 
            this.hotel_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotel_edit.FormattingEnabled = true;
            this.hotel_edit.Location = new System.Drawing.Point(10, 173);
            this.hotel_edit.Name = "hotel_edit";
            this.hotel_edit.Size = new System.Drawing.Size(180, 30);
            this.hotel_edit.TabIndex = 19;
            // 
            // clear_edit
            // 
            this.clear_edit.BackColor = System.Drawing.Color.Violet;
            this.clear_edit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_edit.Location = new System.Drawing.Point(212, 383);
            this.clear_edit.Name = "clear_edit";
            this.clear_edit.Size = new System.Drawing.Size(95, 38);
            this.clear_edit.TabIndex = 26;
            this.clear_edit.Text = "Очистить";
            this.clear_edit.UseVisualStyleBackColor = false;
            this.clear_edit.Click += new System.EventHandler(this.clear_edit_Click);
            // 
            // city_edit
            // 
            this.city_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.city_edit.FormattingEnabled = true;
            this.city_edit.Location = new System.Drawing.Point(10, 115);
            this.city_edit.Name = "city_edit";
            this.city_edit.Size = new System.Drawing.Size(180, 30);
            this.city_edit.TabIndex = 17;
            this.city_edit.SelectedIndexChanged += new System.EventHandler(this.city_edit_SelectedIndexChanged);
            // 
            // canceleditbtn
            // 
            this.canceleditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceleditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceleditbtn.Location = new System.Drawing.Point(111, 382);
            this.canceleditbtn.Name = "canceleditbtn";
            this.canceleditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceleditbtn.TabIndex = 25;
            this.canceleditbtn.Text = "Отменить";
            this.canceleditbtn.UseVisualStyleBackColor = false;
            this.canceleditbtn.Click += new System.EventHandler(this.canceleditbtn_Click);
            // 
            // cost_edit
            // 
            this.cost_edit.Location = new System.Drawing.Point(230, 289);
            this.cost_edit.MaxLength = 45;
            this.cost_edit.Name = "cost_edit";
            this.cost_edit.Size = new System.Drawing.Size(108, 30);
            this.cost_edit.TabIndex = 22;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Orange;
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editbtn.Location = new System.Drawing.Point(10, 382);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(95, 38);
            this.editbtn.TabIndex = 24;
            this.editbtn.Text = "Изменить";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // duration_edit
            // 
            this.duration_edit.Location = new System.Drawing.Point(205, 150);
            this.duration_edit.MaxLength = 45;
            this.duration_edit.Name = "duration_edit";
            this.duration_edit.Size = new System.Drawing.Size(69, 30);
            this.duration_edit.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 22);
            this.label16.TabIndex = 30;
            this.label16.Text = "Введите название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(197, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "Введите длительность:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(6, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(168, 22);
            this.label17.TabIndex = 28;
            this.label17.Text = "Выберите город:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(226, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Введите стоимость:";
            // 
            // name_edit
            // 
            this.name_edit.Location = new System.Drawing.Point(10, 57);
            this.name_edit.MaxLength = 45;
            this.name_edit.Name = "name_edit";
            this.name_edit.Size = new System.Drawing.Size(264, 30);
            this.name_edit.TabIndex = 16;
            // 
            // date_edit
            // 
            this.date_edit.Location = new System.Drawing.Point(10, 347);
            this.date_edit.Name = "date_edit";
            this.date_edit.Size = new System.Drawing.Size(221, 30);
            this.date_edit.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(247, 22);
            this.label15.TabIndex = 31;
            this.label15.Text = "Введите тип проживания:";
            // 
            // meal_edit
            // 
            this.meal_edit.Location = new System.Drawing.Point(10, 288);
            this.meal_edit.MaxLength = 45;
            this.meal_edit.Name = "meal_edit";
            this.meal_edit.Size = new System.Drawing.Size(205, 30);
            this.meal_edit.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 22);
            this.label14.TabIndex = 32;
            this.label14.Text = "Выберите отель";
            // 
            // accomodation_edit
            // 
            this.accomodation_edit.Location = new System.Drawing.Point(10, 231);
            this.accomodation_edit.MaxLength = 45;
            this.accomodation_edit.Name = "accomodation_edit";
            this.accomodation_edit.Size = new System.Drawing.Size(243, 30);
            this.accomodation_edit.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 22);
            this.label13.TabIndex = 33;
            this.label13.Text = "Введите тип питания:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(5, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 22);
            this.label11.TabIndex = 34;
            this.label11.Text = "Введите дату начала:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(261, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Таблица \"Туры\"";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(17, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 453);
            this.panel1.TabIndex = 8;
            // 
            // pdf
            // 
            this.pdf.BackColor = System.Drawing.Color.Red;
            this.pdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pdf.Location = new System.Drawing.Point(17, 20);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(75, 23);
            this.pdf.TabIndex = 9;
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
            this.excel.TabIndex = 10;
            this.excel.Text = "Excel";
            this.excel.UseVisualStyleBackColor = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // TourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(996, 278);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tours);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TourForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Туры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TourForm_FormClosing);
            this.Load += new System.EventHandler(this.TourForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tours)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button canceladditbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox name_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clear_add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker date_add;
        private System.Windows.Forms.TextBox meal_add;
        private System.Windows.Forms.TextBox accomodation_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cost_add;
        private System.Windows.Forms.TextBox duration_add;
        private System.Windows.Forms.ComboBox hotel_add;
        private System.Windows.Forms.ComboBox city_add;
        private System.Windows.Forms.ComboBox hotel_edit;
        private System.Windows.Forms.Button clear_edit;
        private System.Windows.Forms.ComboBox city_edit;
        private System.Windows.Forms.Button canceleditbtn;
        private System.Windows.Forms.TextBox cost_edit;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.TextBox duration_edit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_edit;
        private System.Windows.Forms.DateTimePicker date_edit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox meal_edit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox accomodation_edit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.Button excel;
    }
}