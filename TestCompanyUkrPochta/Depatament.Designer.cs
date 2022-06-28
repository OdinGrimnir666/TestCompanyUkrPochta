namespace TestCompanyUkrPochta
{
    partial class Depatament
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
            this.info_model = new System.Windows.Forms.Label();
            this.name_update_depatramen_text = new System.Windows.Forms.TextBox();
            this.updateid_label = new System.Windows.Forms.Label();
            this.update_textname = new System.Windows.Forms.TextBox();
            this.update_depatr_button = new System.Windows.Forms.Button();
            this.AddDepartamen_button = new System.Windows.Forms.Button();
            this.departament_textbox = new System.Windows.Forms.TextBox();
            this.Grid_Depatament = new System.Windows.Forms.DataGridView();
            this.Должность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Depatament)).BeginInit();
            this.SuspendLayout();
            // 
            // info_model
            // 
            this.info_model.AutoSize = true;
            this.info_model.Location = new System.Drawing.Point(48, 20);
            this.info_model.Name = "info_model";
            this.info_model.Size = new System.Drawing.Size(0, 20);
            this.info_model.TabIndex = 25;
            // 
            // name_update_depatramen_text
            // 
            this.name_update_depatramen_text.Location = new System.Drawing.Point(12, 129);
            this.name_update_depatramen_text.Name = "name_update_depatramen_text";
            this.name_update_depatramen_text.Size = new System.Drawing.Size(134, 27);
            this.name_update_depatramen_text.TabIndex = 24;
            this.name_update_depatramen_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_update_depatramen_text_KeyPress);
            // 
            // updateid_label
            // 
            this.updateid_label.AutoSize = true;
            this.updateid_label.Location = new System.Drawing.Point(12, 20);
            this.updateid_label.Name = "updateid_label";
            this.updateid_label.Size = new System.Drawing.Size(9, 20);
            this.updateid_label.TabIndex = 22;
            this.updateid_label.Text = "\r\n";
            // 
            // update_textname
            // 
            this.update_textname.Location = new System.Drawing.Point(152, 129);
            this.update_textname.Name = "update_textname";
            this.update_textname.Size = new System.Drawing.Size(149, 27);
            this.update_textname.TabIndex = 21;
            // 
            // update_depatr_button
            // 
            this.update_depatr_button.Location = new System.Drawing.Point(12, 162);
            this.update_depatr_button.Name = "update_depatr_button";
            this.update_depatr_button.Size = new System.Drawing.Size(289, 27);
            this.update_depatr_button.TabIndex = 19;
            this.update_depatr_button.Text = "Редактировать";
            this.update_depatr_button.UseVisualStyleBackColor = true;
            this.update_depatr_button.Click += new System.EventHandler(this.update_depatr_button_Click);
            // 
            // AddDepartamen_button
            // 
            this.AddDepartamen_button.Location = new System.Drawing.Point(12, 85);
            this.AddDepartamen_button.Name = "AddDepartamen_button";
            this.AddDepartamen_button.Size = new System.Drawing.Size(289, 29);
            this.AddDepartamen_button.TabIndex = 18;
            this.AddDepartamen_button.Text = "Добавить";
            this.AddDepartamen_button.UseVisualStyleBackColor = true;
            this.AddDepartamen_button.Click += new System.EventHandler(this.AddDepartamen_button_Click);
            // 
            // departament_textbox
            // 
            this.departament_textbox.Location = new System.Drawing.Point(12, 52);
            this.departament_textbox.Name = "departament_textbox";
            this.departament_textbox.Size = new System.Drawing.Size(289, 27);
            this.departament_textbox.TabIndex = 17;
            // 
            // Grid_Depatament
            // 
            this.Grid_Depatament.AllowUserToAddRows = false;
            this.Grid_Depatament.AllowUserToDeleteRows = false;
            this.Grid_Depatament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Depatament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Должность,
            this.update,
            this.delete});
            this.Grid_Depatament.Location = new System.Drawing.Point(307, 52);
            this.Grid_Depatament.Name = "Grid_Depatament";
            this.Grid_Depatament.ReadOnly = true;
            this.Grid_Depatament.RowHeadersWidth = 51;
            this.Grid_Depatament.RowTemplate.Height = 29;
            this.Grid_Depatament.Size = new System.Drawing.Size(429, 386);
            this.Grid_Depatament.TabIndex = 16;
            this.Grid_Depatament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Depatament_CellContentClick);
            // 
            // Должность
            // 
            this.Должность.HeaderText = "Название Отдела";
            this.Должность.MinimumWidth = 6;
            this.Должность.Name = "Должность";
            this.Должность.ReadOnly = true;
            this.Должность.Width = 125;
            // 
            // update
            // 
            this.update.HeaderText = "Редактировать";
            this.update.MinimumWidth = 6;
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "Удалить";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 125;
            // 
            // Depatament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.info_model);
            this.Controls.Add(this.name_update_depatramen_text);
            this.Controls.Add(this.updateid_label);
            this.Controls.Add(this.update_textname);
            this.Controls.Add(this.update_depatr_button);
            this.Controls.Add(this.AddDepartamen_button);
            this.Controls.Add(this.departament_textbox);
            this.Controls.Add(this.Grid_Depatament);
            this.Name = "Depatament";
            this.Text = "Отдел";
            this.Load += new System.EventHandler(this.Depatament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Depatament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label info_model;
        private TextBox name_update_depatramen_text;
        private Label updateid_label;
        private TextBox update_textname;
        private Button update_depatr_button;
        private Button AddDepartamen_button;
        private TextBox departament_textbox;
        private DataGridView Grid_Depatament;
        private DataGridViewTextBoxColumn Должность;
        private DataGridViewTextBoxColumn update;
        private DataGridViewTextBoxColumn delete;
    }
}