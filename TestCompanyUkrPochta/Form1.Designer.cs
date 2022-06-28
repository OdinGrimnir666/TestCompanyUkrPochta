using TestCompanyUkrPochta.db;

namespace TestCompanyUkrPochta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

            using var db = new CompanyContext();


            Console.Write(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\n");

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Add_Worker_menu_button = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkerGrid = new System.Windows.Forms.DataGridView();
            this.Update_Grid = new System.Windows.Forms.Button();
            this.combo_depatametn = new System.Windows.Forms.ComboBox();
            this.Report_Button = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesunamefather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_Worker_menu_button,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip2.Size = new System.Drawing.Size(1366, 28);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // Add_Worker_menu_button
            // 
            this.Add_Worker_menu_button.Name = "Add_Worker_menu_button";
            this.Add_Worker_menu_button.Size = new System.Drawing.Size(192, 24);
            this.Add_Worker_menu_button.Text = "Добавление сотрудника";
            this.Add_Worker_menu_button.Click += new System.EventHandler(this.Add_Worker_menu_button_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 24);
            this.toolStripMenuItem2.Text = "Должность";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(64, 24);
            this.toolStripMenuItem3.Text = "Отдел";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(85, 24);
            this.toolStripMenuItem4.Text = "Выплаты";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // WorkerGrid
            // 
            this.WorkerGrid.AllowUserToAddRows = false;
            this.WorkerGrid.AllowUserToDeleteRows = false;
            this.WorkerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.namesunamefather,
            this.dataGridViewTextBoxColumn2,
            this.Position,
            this.Department,
            this.dataGridViewTextBoxColumn3,
            this.Salary,
            this.KPI,
            this.Prize,
            this.Update});
            this.WorkerGrid.Location = new System.Drawing.Point(0, 107);
            this.WorkerGrid.Name = "WorkerGrid";
            this.WorkerGrid.ReadOnly = true;
            this.WorkerGrid.RowHeadersWidth = 51;
            this.WorkerGrid.RowTemplate.Height = 29;
            this.WorkerGrid.Size = new System.Drawing.Size(1300, 360);
            this.WorkerGrid.TabIndex = 1;
            this.WorkerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkerGrid_CellContentClick);
            // 
            // Update_Grid
            // 
            this.Update_Grid.BackColor = System.Drawing.Color.Yellow;
            this.Update_Grid.Location = new System.Drawing.Point(6, 31);
            this.Update_Grid.Name = "Update_Grid";
            this.Update_Grid.Size = new System.Drawing.Size(215, 28);
            this.Update_Grid.TabIndex = 2;
            this.Update_Grid.Text = "Обновить";
            this.Update_Grid.UseMnemonic = false;
            this.Update_Grid.UseVisualStyleBackColor = false;
            this.Update_Grid.Click += new System.EventHandler(this.Update_Grid_Click);
            // 
            // combo_depatametn
            // 
            this.combo_depatametn.FormattingEnabled = true;
            this.combo_depatametn.Location = new System.Drawing.Point(227, 31);
            this.combo_depatametn.Name = "combo_depatametn";
            this.combo_depatametn.Size = new System.Drawing.Size(129, 28);
            this.combo_depatametn.TabIndex = 3;
            this.combo_depatametn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo_depatametn_KeyPress);
            // 
            // Report_Button
            // 
            this.Report_Button.Location = new System.Drawing.Point(371, 30);
            this.Report_Button.Name = "Report_Button";
            this.Report_Button.Size = new System.Drawing.Size(216, 28);
            this.Report_Button.TabIndex = 4;
            this.Report_Button.Text = "Отчет";
            this.Report_Button.UseVisualStyleBackColor = true;
            this.Report_Button.Click += new System.EventHandler(this.Report_Button_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // namesunamefather
            // 
            this.namesunamefather.HeaderText = "И.Ф.О";
            this.namesunamefather.MinimumWidth = 6;
            this.namesunamefather.Name = "namesunamefather";
            this.namesunamefather.ReadOnly = true;
            this.namesunamefather.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Position
            // 
            this.Position.HeaderText = "Должность";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 125;
            // 
            // Department
            // 
            this.Department.HeaderText = "Отдел";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Оклад";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 125;
            // 
            // KPI
            // 
            this.KPI.HeaderText = "КПИ";
            this.KPI.MinimumWidth = 6;
            this.KPI.Name = "KPI";
            this.KPI.ReadOnly = true;
            this.KPI.Width = 125;
            // 
            // Prize
            // 
            this.Prize.HeaderText = "Премия";
            this.Prize.MinimumWidth = 6;
            this.Prize.Name = "Prize";
            this.Prize.ReadOnly = true;
            this.Prize.Width = 125;
            // 
            // Update
            // 
            this.Update.HeaderText = "Редактировать";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 450);
            this.Controls.Add(this.Report_Button);
            this.Controls.Add(this.combo_depatametn);
            this.Controls.Add(this.Update_Grid);
            this.Controls.Add(this.WorkerGrid);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem главноеМенюToolStripMenuItem;
        private ToolStripMenuItem редактированиеToolStripMenuItem;
        private ToolStripMenuItem добавлениеРаботникаToolStripMenuItem;
        private ToolStripMenuItem выплатыToolStripMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private ToolStripMenuItem отделToolStripMenuItem;
        private ToolStripMenuItem должностьToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem Add_Worker_menu_button;
        private DataGridView WorkerGrid;
        private Button Update_Grid;
        private ComboBox combo_depatametn;
        private Button Report_Button;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn namesunamefather;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn KPI;
        private DataGridViewTextBoxColumn Prize;
        private DataGridViewButtonColumn Update;
    }
}