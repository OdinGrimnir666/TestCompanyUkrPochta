using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestCompanyUkrPochta.db;

namespace TestCompanyUkrPochta
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
            SetBox();
            depatr_label.Text = "Все отделы";
            Set_Payments();
        }



        public void SetBox()
        {
            using (var db = new CompanyContext())
            {
                var depatamet_list = db.Departments;

                foreach (var item in depatamet_list)
                {
                    Depatament_Box.Items.Add(item.NameDepartment);
                }
                Depatament_Box.Items.Add("Все отделы");
            }
        }

        public void Set_Payments(string str = "")
        {

            decimal payments = 0;
            using (var db = new CompanyContext())
            {
                IOrderedQueryable<Worker>? listpossition;
                if (str == ""| str=="Все отделы")
                {
                    listpossition = (IOrderedQueryable<Worker>?)db.Workers.OrderBy(x=>x.id);
                }
                else
                {
                    listpossition = (IOrderedQueryable<Worker>?)db.Workers.Where(x => x.DepartmentId == db.Departments.Single(x => x.NameDepartment == Depatament_Box.Text).id);
                }

                foreach (var item in listpossition)
                {
                    payments += item.Salary + item.Salary * db.KPI.Single(x => x.id == item.KPIid).Surcharge / 100;
                }
                depatr_label.Text = Depatament_Box.Text;
                money_lebel.Text = Math.Round(payments,2).ToString()+"грн";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            Set_Payments(Depatament_Box.Text);
        }

        private void Filter_Button_Click(object sender, EventArgs e)
        {
            Set_Payments(Depatament_Box.Text);
        }
    }
}
