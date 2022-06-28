namespace TestCompanyUkrPochta
{
    partial class Payments
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
            this.Depatament_Box = new System.Windows.Forms.ComboBox();
            this.Filter_Button = new System.Windows.Forms.Button();
            this.depatr_label = new System.Windows.Forms.Label();
            this.money_lebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Depatament_Box
            // 
            this.Depatament_Box.FormattingEnabled = true;
            this.Depatament_Box.Location = new System.Drawing.Point(19, 30);
            this.Depatament_Box.Name = "Depatament_Box";
            this.Depatament_Box.Size = new System.Drawing.Size(372, 28);
            this.Depatament_Box.TabIndex = 0;
            this.Depatament_Box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.Depatament_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // Filter_Button
            // 
            this.Filter_Button.Location = new System.Drawing.Point(19, 73);
            this.Filter_Button.Name = "Filter_Button";
            this.Filter_Button.Size = new System.Drawing.Size(372, 41);
            this.Filter_Button.TabIndex = 1;
            this.Filter_Button.Text = "Отфильтровать";
            this.Filter_Button.UseVisualStyleBackColor = true;
            this.Filter_Button.Click += new System.EventHandler(this.Filter_Button_Click);
            // 
            // depatr_label
            // 
            this.depatr_label.AutoSize = true;
            this.depatr_label.Location = new System.Drawing.Point(19, 136);
            this.depatr_label.Name = "depatr_label";
            this.depatr_label.Size = new System.Drawing.Size(0, 20);
            this.depatr_label.TabIndex = 2;
            // 
            // money_lebel
            // 
            this.money_lebel.AutoSize = true;
            this.money_lebel.Location = new System.Drawing.Point(107, 138);
            this.money_lebel.Name = "money_lebel";
            this.money_lebel.Size = new System.Drawing.Size(0, 20);
            this.money_lebel.TabIndex = 3;
            this.money_lebel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 194);
            this.Controls.Add(this.money_lebel);
            this.Controls.Add(this.depatr_label);
            this.Controls.Add(this.Filter_Button);
            this.Controls.Add(this.Depatament_Box);
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Depatament_Box;
        protected internal Button Filter_Button;
        private Label depatr_label;
        private Label money_lebel;
    }
}