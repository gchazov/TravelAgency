namespace TravelAgency.Forms
{
    partial class ContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractForm));
            this.contracts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employee_add = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.client_add = new System.Windows.Forms.ComboBox();
            this.tour_add = new System.Windows.Forms.ComboBox();
            this.date_add = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.canceladditbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employee_edit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.canceleditbtn = new System.Windows.Forms.Button();
            this.client_edit = new System.Windows.Forms.ComboBox();
            this.editbtn = new System.Windows.Forms.Button();
            this.tour_edit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_edit = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdf = new System.Windows.Forms.Button();
            this.excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contracts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contracts
            // 
            this.contracts.AllowUserToAddRows = false;
            this.contracts.AllowUserToDeleteRows = false;
            this.contracts.AllowUserToResizeColumns = false;
            this.contracts.AllowUserToResizeRows = false;
            this.contracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contracts.BackgroundColor = System.Drawing.Color.LightGray;
            this.contracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contracts.Location = new System.Drawing.Point(17, 50);
            this.contracts.Margin = new System.Windows.Forms.Padding(4);
            this.contracts.MultiSelect = false;
            this.contracts.Name = "contracts";
            this.contracts.ReadOnly = true;
            this.contracts.RowHeadersWidth = 51;
            this.contracts.RowTemplate.Height = 24;
            this.contracts.Size = new System.Drawing.Size(772, 220);
            this.contracts.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.employee_add);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.client_add);
            this.groupBox1.Controls.Add(this.tour_add);
            this.groupBox1.Controls.Add(this.date_add);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.canceladditbtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(25, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // employee_add
            // 
            this.employee_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employee_add.FormattingEnabled = true;
            this.employee_add.Location = new System.Drawing.Point(10, 176);
            this.employee_add.Name = "employee_add";
            this.employee_add.Size = new System.Drawing.Size(255, 30);
            this.employee_add.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Выберите сотрудника:";
            // 
            // client_add
            // 
            this.client_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.client_add.FormattingEnabled = true;
            this.client_add.Location = new System.Drawing.Point(10, 118);
            this.client_add.Name = "client_add";
            this.client_add.Size = new System.Drawing.Size(255, 30);
            this.client_add.TabIndex = 6;
            // 
            // tour_add
            // 
            this.tour_add.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tour_add.FormattingEnabled = true;
            this.tour_add.Location = new System.Drawing.Point(10, 60);
            this.tour_add.Name = "tour_add";
            this.tour_add.Size = new System.Drawing.Size(255, 30);
            this.tour_add.TabIndex = 5;
            this.tour_add.SelectedIndexChanged += new System.EventHandler(this.city_add_SelectedIndexChanged);
            // 
            // date_add
            // 
            this.date_add.Location = new System.Drawing.Point(11, 235);
            this.date_add.Name = "date_add";
            this.date_add.Size = new System.Drawing.Size(221, 30);
            this.date_add.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(349, 22);
            this.label12.TabIndex = 16;
            this.label12.Text = "Введите дату заключения договора:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Выберите клиента:";
            // 
            // canceladditbtn
            // 
            this.canceladditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceladditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceladditbtn.Location = new System.Drawing.Point(108, 272);
            this.canceladditbtn.Name = "canceladditbtn";
            this.canceladditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceladditbtn.TabIndex = 10;
            this.canceladditbtn.Text = "Отменить";
            this.canceladditbtn.UseVisualStyleBackColor = false;
            this.canceladditbtn.Click += new System.EventHandler(this.canceladditbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Lime;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbtn.Location = new System.Drawing.Point(10, 272);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(95, 38);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите тур:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(820, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть панель редактирования";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(820, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить выбранный";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.Location = new System.Drawing.Point(820, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.employee_edit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.canceleditbtn);
            this.groupBox2.Controls.Add(this.client_edit);
            this.groupBox2.Controls.Add(this.editbtn);
            this.groupBox2.Controls.Add(this.tour_edit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.date_edit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(484, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 318);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактировать";
            // 
            // employee_edit
            // 
            this.employee_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employee_edit.FormattingEnabled = true;
            this.employee_edit.ItemHeight = 22;
            this.employee_edit.Location = new System.Drawing.Point(10, 176);
            this.employee_edit.Name = "employee_edit";
            this.employee_edit.Size = new System.Drawing.Size(255, 30);
            this.employee_edit.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Выберите сотрудника:";
            // 
            // canceleditbtn
            // 
            this.canceleditbtn.BackColor = System.Drawing.Color.Crimson;
            this.canceleditbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canceleditbtn.Location = new System.Drawing.Point(111, 271);
            this.canceleditbtn.Name = "canceleditbtn";
            this.canceleditbtn.Size = new System.Drawing.Size(95, 38);
            this.canceleditbtn.TabIndex = 16;
            this.canceleditbtn.Text = "Отменить";
            this.canceleditbtn.UseVisualStyleBackColor = false;
            this.canceleditbtn.Click += new System.EventHandler(this.canceleditbtn_Click);
            // 
            // client_edit
            // 
            this.client_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.client_edit.FormattingEnabled = true;
            this.client_edit.ItemHeight = 22;
            this.client_edit.Location = new System.Drawing.Point(10, 118);
            this.client_edit.Name = "client_edit";
            this.client_edit.Size = new System.Drawing.Size(255, 30);
            this.client_edit.TabIndex = 12;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.Orange;
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editbtn.Location = new System.Drawing.Point(10, 271);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(95, 38);
            this.editbtn.TabIndex = 15;
            this.editbtn.Text = "Изменить";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // tour_edit
            // 
            this.tour_edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tour_edit.FormattingEnabled = true;
            this.tour_edit.ItemHeight = 22;
            this.tour_edit.Location = new System.Drawing.Point(10, 60);
            this.tour_edit.Name = "tour_edit";
            this.tour_edit.Size = new System.Drawing.Size(255, 30);
            this.tour_edit.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Выберите тур:";
            // 
            // date_edit
            // 
            this.date_edit.Location = new System.Drawing.Point(11, 235);
            this.date_edit.Name = "date_edit";
            this.date_edit.Size = new System.Drawing.Size(221, 30);
            this.date_edit.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Выберите клиента:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Введите дату заключения договора:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(261, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Таблица \"Договоры\"";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(17, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 344);
            this.panel1.TabIndex = 8;
            // 
            // pdf
            // 
            this.pdf.BackColor = System.Drawing.Color.IndianRed;
            this.pdf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pdf.Location = new System.Drawing.Point(17, 19);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(130, 24);
            this.pdf.TabIndex = 9;
            this.pdf.Text = "Договор в PDF";
            this.pdf.UseVisualStyleBackColor = false;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // excel
            // 
            this.excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.excel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.excel.Location = new System.Drawing.Point(714, 20);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(75, 23);
            this.excel.TabIndex = 17;
            this.excel.Text = "Excel";
            this.excel.UseVisualStyleBackColor = false;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(989, 281);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contracts);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договоры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContractForm_FormClosing);
            this.Load += new System.EventHandler(this.ContractForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contracts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contracts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button canceladditbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker date_add;
        private System.Windows.Forms.ComboBox client_add;
        private System.Windows.Forms.ComboBox tour_add;
        private System.Windows.Forms.Button canceleditbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.ComboBox employee_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox employee_edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox client_edit;
        private System.Windows.Forms.ComboBox tour_edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.Button excel;
    }
}