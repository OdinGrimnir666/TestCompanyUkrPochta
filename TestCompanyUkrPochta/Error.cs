using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCompanyUkrPochta
{
    public partial class Error : Form
    {

        public Error()
        {

            InitializeComponent();
        }
        public Error(string str_error)
        {
            InitializeComponent();
            Eror_label.Text = str_error;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        public void Haide()
        {
            this.Close();
        }
        private void Haide_Button_Click(object sender, EventArgs e)
        {
            Haide();
        }
    }
}
