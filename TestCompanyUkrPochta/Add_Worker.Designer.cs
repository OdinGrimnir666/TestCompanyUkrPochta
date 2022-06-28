namespace TestCompanyUkrPochta
{
    partial class Add_Worker
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
            this.Employee_number = new System.Windows.Forms.TextBox();
            this.Namee = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.Addres = new System.Windows.Forms.TextBox();
            this.NumberPhone = new System.Windows.Forms.TextBox();
            this.fatherland = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.label_number = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.surname_lanel = new System.Windows.Forms.Label();
            this.fatherland_label = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_addres = new System.Windows.Forms.Label();
            this.depatament_label = new System.Windows.Forms.Label();
            this.position_label = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.kpi_label = new System.Windows.Forms.Label();
            this.Departamet = new System.Windows.Forms.ComboBox();
            this.Position = new System.Windows.Forms.ComboBox();
            this.KPI = new System.Windows.Forms.ComboBox();
            this.Add_Batton = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Info_label = new System.Windows.Forms.Label();
            this.Info_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Employee_number
            // 
            this.Employee_number.Location = new System.Drawing.Point(12, 70);
            this.Employee_number.Name = "Employee_number";
            this.Employee_number.Size = new System.Drawing.Size(197, 27);
            this.Employee_number.TabIndex = 0;
            // 
            // Namee
            // 
            this.Namee.Location = new System.Drawing.Point(12, 127);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(197, 27);
            this.Namee.TabIndex = 1;
            this.Namee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(263, 250);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(197, 27);
            this.Salary.TabIndex = 2;
            this.Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salary_KeyPress);
            // 
            // Addres
            // 
            this.Addres.BackColor = System.Drawing.Color.White;
            this.Addres.Location = new System.Drawing.Point(263, 70);
            this.Addres.Name = "Addres";
            this.Addres.Size = new System.Drawing.Size(197, 27);
            this.Addres.TabIndex = 5;
            // 
            // NumberPhone
            // 
            this.NumberPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberPhone.Location = new System.Drawing.Point(12, 310);
            this.NumberPhone.MaxLength = 12;
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.Size = new System.Drawing.Size(197, 27);
            this.NumberPhone.TabIndex = 6;
            this.NumberPhone.TextChanged += new System.EventHandler(this.NumberPhone_TextChanged);
            this.NumberPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberPhone_KeyPress);
            // 
            // fatherland
            // 
            this.fatherland.Location = new System.Drawing.Point(12, 250);
            this.fatherland.Name = "fatherland";
            this.fatherland.Size = new System.Drawing.Size(197, 27);
            this.fatherland.TabIndex = 7;
            this.fatherland.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fatherland_KeyPress_1);
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(12, 188);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(197, 27);
            this.Surname.TabIndex = 8;
            this.Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Surname_KeyPress);
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(21, 47);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(135, 20);
            this.label_number.TabIndex = 11;
            this.label_number.Text = "Номер работника";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 104);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(39, 20);
            this.label_name.TabIndex = 12;
            this.label_name.Text = "Имя";
            // 
            // surname_lanel
            // 
            this.surname_lanel.AutoSize = true;
            this.surname_lanel.Location = new System.Drawing.Point(12, 165);
            this.surname_lanel.Name = "surname_lanel";
            this.surname_lanel.Size = new System.Drawing.Size(73, 20);
            this.surname_lanel.TabIndex = 13;
            this.surname_lanel.Text = "Фамилия";
            // 
            // fatherland_label
            // 
            this.fatherland_label.AutoSize = true;
            this.fatherland_label.Location = new System.Drawing.Point(12, 227);
            this.fatherland_label.Name = "fatherland_label";
            this.fatherland_label.Size = new System.Drawing.Size(66, 20);
            this.fatherland_label.TabIndex = 14;
            this.fatherland_label.Text = "Очество";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(12, 287);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(127, 20);
            this.label_phone.TabIndex = 15;
            this.label_phone.Text = "Номер телефона";
            // 
            // label_addres
            // 
            this.label_addres.AutoSize = true;
            this.label_addres.Location = new System.Drawing.Point(263, 47);
            this.label_addres.Name = "label_addres";
            this.label_addres.Size = new System.Drawing.Size(51, 20);
            this.label_addres.TabIndex = 16;
            this.label_addres.Text = "Адрес";
            // 
            // depatament_label
            // 
            this.depatament_label.AutoSize = true;
            this.depatament_label.Location = new System.Drawing.Point(263, 104);
            this.depatament_label.Name = "depatament_label";
            this.depatament_label.Size = new System.Drawing.Size(101, 20);
            this.depatament_label.TabIndex = 17;
            this.depatament_label.Text = "Департамент";
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Location = new System.Drawing.Point(263, 165);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(86, 20);
            this.position_label.TabIndex = 18;
            this.position_label.Text = "Должность";
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(263, 227);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(51, 20);
            this.label_salary.TabIndex = 19;
            this.label_salary.Text = "Оклад";
            // 
            // kpi_label
            // 
            this.kpi_label.AutoSize = true;
            this.kpi_label.Location = new System.Drawing.Point(263, 287);
            this.kpi_label.Name = "kpi_label";
            this.kpi_label.Size = new System.Drawing.Size(40, 20);
            this.kpi_label.TabIndex = 20;
            this.kpi_label.Text = "КПИ";
            // 
            // Departamet
            // 
            this.Departamet.FormattingEnabled = true;
            this.Departamet.Location = new System.Drawing.Point(263, 126);
            this.Departamet.Name = "Departamet";
            this.Departamet.Size = new System.Drawing.Size(197, 28);
            this.Departamet.TabIndex = 21;
            this.Departamet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Departamet_KeyPress);
            // 
            // Position
            // 
            this.Position.FormattingEnabled = true;
            this.Position.Location = new System.Drawing.Point(263, 188);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(197, 28);
            this.Position.TabIndex = 22;
            this.Position.UseWaitCursor = true;
            this.Position.SelectedIndexChanged += new System.EventHandler(this.Position_SelectedIndexChanged);
            this.Position.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Position_KeyPress);
            // 
            // KPI
            // 
            this.KPI.FormattingEnabled = true;
            this.KPI.Location = new System.Drawing.Point(263, 310);
            this.KPI.Name = "KPI";
            this.KPI.Size = new System.Drawing.Size(197, 28);
            this.KPI.TabIndex = 23;
            this.KPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KPI_KeyPress);
            // 
            // Add_Batton
            // 
            this.Add_Batton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Add_Batton.Location = new System.Drawing.Point(12, 364);
            this.Add_Batton.Name = "Add_Batton";
            this.Add_Batton.Size = new System.Drawing.Size(194, 39);
            this.Add_Batton.TabIndex = 24;
            this.Add_Batton.Text = "Добавить Работника";
            this.Add_Batton.UseVisualStyleBackColor = false;
            this.Add_Batton.Click += new System.EventHandler(this.Add_Batton_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.Red;
            this.Delete_Button.Location = new System.Drawing.Point(263, 364);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(197, 39);
            this.Delete_Button.TabIndex = 25;
            this.Delete_Button.Text = "Удалить работника";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.Yellow;
            this.Clear_Button.Location = new System.Drawing.Point(478, 70);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(151, 27);
            this.Clear_Button.TabIndex = 26;
            this.Clear_Button.Text = "Очистит поля";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Info_label
            // 
            this.Info_label.AutoSize = true;
            this.Info_label.Location = new System.Drawing.Point(21, 15);
            this.Info_label.Name = "Info_label";
            this.Info_label.Size = new System.Drawing.Size(0, 20);
            this.Info_label.TabIndex = 27;
            // 
            // Info_Error
            // 
            this.Info_Error.AutoSize = true;
            this.Info_Error.Location = new System.Drawing.Point(20, 12);
            this.Info_Error.Name = "Info_Error";
            this.Info_Error.Size = new System.Drawing.Size(0, 20);
            this.Info_Error.TabIndex = 28;
            // 
            // Add_Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.Info_Error);
            this.Controls.Add(this.Info_label);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Add_Batton);
            this.Controls.Add(this.KPI);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Departamet);
            this.Controls.Add(this.kpi_label);
            this.Controls.Add(this.label_salary);
            this.Controls.Add(this.position_label);
            this.Controls.Add(this.depatament_label);
            this.Controls.Add(this.label_addres);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.fatherland_label);
            this.Controls.Add(this.surname_lanel);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.fatherland);
            this.Controls.Add(this.NumberPhone);
            this.Controls.Add(this.Addres);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Namee);
            this.Controls.Add(this.Employee_number);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "Add_Worker";
            this.Text = "работник";
            this.Load += new System.EventHandler(this.Add_Worker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Employee_number;
        private TextBox Namee;
        private TextBox Salary;
        private TextBox Addres;
        private TextBox NumberPhone;
        private TextBox fatherland;
        private TextBox Surname;
        private Label label_number;
        private Label label_name;
        private Label surname_lanel;
        private Label fatherland_label;
        private Label label_phone;
        private Label label_addres;
        private Label depatament_label;
        private Label position_label;
        private Label label_salary;
        private Label kpi_label;
        private ComboBox Departamet;
        private ComboBox Position;
        private ComboBox KPI;
        private Button Add_Batton;
        private Button Delete_Button;
        private Button Clear_Button;
        private Label Info_label;
        private Label Info_Error;
    }
}