namespace TestCompanyUkrPochta
{
    partial class Error
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
            this.Haide_Button = new System.Windows.Forms.Button();
            this.Eror_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Haide_Button
            // 
            this.Haide_Button.Location = new System.Drawing.Point(64, 123);
            this.Haide_Button.Name = "Haide_Button";
            this.Haide_Button.Size = new System.Drawing.Size(179, 28);
            this.Haide_Button.TabIndex = 0;
            this.Haide_Button.Text = "Закрыть";
            this.Haide_Button.UseVisualStyleBackColor = true;
            this.Haide_Button.Click += new System.EventHandler(this.Haide_Button_Click);
            // 
            // Eror_label
            // 
            this.Eror_label.AutoSize = true;
            this.Eror_label.Location = new System.Drawing.Point(12, 58);
            this.Eror_label.Name = "Eror_label";
            this.Eror_label.Size = new System.Drawing.Size(0, 20);
            this.Eror_label.TabIndex = 1;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 192);
            this.Controls.Add(this.Eror_label);
            this.Controls.Add(this.Haide_Button);
            this.Name = "Error";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Haide_Button;
        private Label Eror_label;
    }
}