namespace TestCompanyUkrPochta
{
    partial class Positions
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
            this.components = new System.ComponentModel.Container();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Gridposition = new System.Windows.Forms.DataGridView();
            this.Должность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.positionname_textbox = new System.Windows.Forms.TextBox();
            this.Addposition_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.update_textname = new System.Windows.Forms.TextBox();
            this.updateid_label = new System.Windows.Forms.Label();
            this.delete_lebel = new System.Windows.Forms.Label();
            this.name_update_text = new System.Windows.Forms.TextBox();
            this.info_model = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridposition)).BeginInit();
            this.SuspendLayout();
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataSource = typeof(TestCompanyUkrPochta.db.Position);
            // 
            // Gridposition
            // 
            this.Gridposition.AllowUserToAddRows = false;
            this.Gridposition.AllowUserToDeleteRows = false;
            this.Gridposition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridposition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Должность,
            this.update,
            this.delete});
            this.Gridposition.Location = new System.Drawing.Point(283, 42);
            this.Gridposition.Name = "Gridposition";
            this.Gridposition.ReadOnly = true;
            this.Gridposition.RowHeadersWidth = 51;
            this.Gridposition.RowTemplate.Height = 29;
            this.Gridposition.Size = new System.Drawing.Size(427, 396);
            this.Gridposition.TabIndex = 2;
            this.Gridposition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridposition_CellContentClick);
            // 
            // Должность
            // 
            this.Должность.HeaderText = "Position";
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
            // positionname_textbox
            // 
            this.positionname_textbox.Location = new System.Drawing.Point(3, 58);
            this.positionname_textbox.Name = "positionname_textbox";
            this.positionname_textbox.Size = new System.Drawing.Size(235, 27);
            this.positionname_textbox.TabIndex = 3;
            this.positionname_textbox.TextChanged += new System.EventHandler(this.positionname_textbox_TextChanged);
            // 
            // Addposition_button
            // 
            this.Addposition_button.Location = new System.Drawing.Point(3, 91);
            this.Addposition_button.Name = "Addposition_button";
            this.Addposition_button.Size = new System.Drawing.Size(235, 29);
            this.Addposition_button.TabIndex = 4;
            this.Addposition_button.Text = "Добавить";
            this.Addposition_button.UseVisualStyleBackColor = true;
            this.Addposition_button.Click += new System.EventHandler(this.Addposition_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(0, 207);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(238, 27);
            this.update_button.TabIndex = 6;
            this.update_button.Text = "Редактировать";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // update_textname
            // 
            this.update_textname.Location = new System.Drawing.Point(125, 161);
            this.update_textname.Name = "update_textname";
            this.update_textname.Size = new System.Drawing.Size(113, 27);
            this.update_textname.TabIndex = 9;
            // 
            // updateid_label
            // 
            this.updateid_label.AutoSize = true;
            this.updateid_label.Location = new System.Drawing.Point(0, 101);
            this.updateid_label.Name = "updateid_label";
            this.updateid_label.Size = new System.Drawing.Size(9, 20);
            this.updateid_label.TabIndex = 10;
            this.updateid_label.Text = "\r\n";
            // 
            // delete_lebel
            // 
            this.delete_lebel.AutoSize = true;
            this.delete_lebel.Location = new System.Drawing.Point(0, 161);
            this.delete_lebel.Name = "delete_lebel";
            this.delete_lebel.Size = new System.Drawing.Size(0, 20);
            this.delete_lebel.TabIndex = 11;
            // 
            // name_update_text
            // 
            this.name_update_text.Location = new System.Drawing.Point(3, 161);
            this.name_update_text.Name = "name_update_text";
            this.name_update_text.Size = new System.Drawing.Size(116, 27);
            this.name_update_text.TabIndex = 14;
            this.name_update_text.TextChanged += new System.EventHandler(this.name_update_text_TextChanged);
            this.name_update_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_update_text_KeyPress);
            // 
            // info_model
            // 
            this.info_model.AutoSize = true;
            this.info_model.Location = new System.Drawing.Point(7, 28);
            this.info_model.Name = "info_model";
            this.info_model.Size = new System.Drawing.Size(0, 20);
            this.info_model.TabIndex = 15;
            // 
            // Positions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.info_model);
            this.Controls.Add(this.name_update_text);
            this.Controls.Add(this.delete_lebel);
            this.Controls.Add(this.updateid_label);
            this.Controls.Add(this.update_textname);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.Addposition_button);
            this.Controls.Add(this.positionname_textbox);
            this.Controls.Add(this.Gridposition);
            this.Name = "Positions";
            this.Text = "Positions";
            this.Load += new System.EventHandler(this.Positions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridposition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource positionBindingSource;
        private DataGridView Gridposition;
        private TextBox positionname_textbox;
        private Button Addposition_button;
        private Button update_button;
        private TextBox update_textname;
        private Label updateid_label;
        private Label delete_lebel;
        private TextBox name_update_text;
        private Label info_model;
        private DataGridViewTextBoxColumn Должность;
        private DataGridViewButtonColumn update;
        private DataGridViewButtonColumn delete;
    }
}