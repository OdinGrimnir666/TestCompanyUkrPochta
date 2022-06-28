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
    public partial class Add_Worker : Form
    {


        public Add_Worker()
        {
            InitializeComponent();
            SetData();
            Delete_Button.Visible = false;
            Form1 link;
        }

        public Add_Worker(string number)
        {
            InitializeComponent();
            SetData();
            Set_Update_Worker(number);
            Add_Batton.Text = "Редактировать";
            Employee_number.ReadOnly = true;
            Clear_Button.Visible = false;


        }



        public void Set_Update_Worker(string number)
        {
            try
            {


                using (var db = new CompanyContext())
                {


                    var worker = db.Workers.Single(x => x.Employee_number == number);

                    Employee_number.Text = worker.Employee_number;
                    Namee.Text = worker.Name;
                    Surname.Text = worker.Surname;
                    fatherland.Text = worker.Fatherland;
                    NumberPhone.Text = worker.NumberPhone;
                    Addres.Text = worker.Address;
                    Salary.Text = worker.Salary.ToString();
                    Departamet.Text = worker.PositionId != null ? db.Positions.Single(x => x.id == worker.PositionId).NamePosition : "Нет Должности";
                    Position.Text = worker.DepartmentId != null ? db.Departments.Single(x => x.id == worker.DepartmentId).NameDepartment : "Нет Отдела";
                    KPI.Text = worker.KPIid != null ? db.KPI.Single(x => x.id == worker.KPIid).Grade : "Нет Kpi";


                };
            }
            catch
            {
                return;
            }

        }
        private void Add_Worker_Load(object sender, EventArgs e)
        {

        }



        private void SetData()
        {
            using (var db = new CompanyContext())
            {
                foreach (var item in db.KPI)
                {

                    KPI.Items.Add(item.Grade);

                }

                foreach (var item in db.Positions)
                {

                    Position.Items.Add(item.NamePosition);

                }
                foreach (var item in db.Departments)
                {

                    Departamet.Items.Add(item.NameDepartment);

                }
            }



        }
        public bool Valid()
        {
            if (Namee.Text == "" | Surname.Text == "" | fatherland.Text == ""
                | Departamet.Text == "" | KPI.Text == "" | Position.Text == "" | NumberPhone.Text == "")
            {
                Info_label.Text = $"Не могут быть пустые {label_name.Text} ,{surname_lanel.Text} {fatherland_label.Text} " +
                    $"{kpi_label.Text},{kpi_label.Text} ,{position_label.Text}";
                return false;

            }

            try
            {
                decimal.Parse(Salary.Text);

            }
            catch (Exception e)
            {
                Info_label.Text = $"Не правильно ведено {label_salary.Name} долно ,быть только одна запятая .Округление до стотных";
                return false;
            }





            return true;
        }

        private void Update_Worker(string number)
        {

            try
            {
                using (var db = new CompanyContext())
                {
                    var update_worker = db.Workers.Single(x => x.Employee_number == number);
                    update_worker.Employee_number = Employee_number.Text;
                    update_worker.Name = Namee.Text;
                    update_worker.Surname = Surname.Text;
                    update_worker.Fatherland = fatherland.Text;
                    update_worker.NumberPhone = NumberPhone.Text;
                    update_worker.Address = Addres.Text;
                    update_worker.Salary = Math.Round(decimal.Parse(Salary.Text), 2);
                    update_worker.DepartmentId = db.Departments.Single(x => x.NameDepartment == Departamet.Text).id;
                    update_worker.PositionId = db.Positions.Single(x => x.NamePosition == Position.Text).id;
                    update_worker.KPIid = db.KPI.Single(x => x.Grade == KPI.Text).id;
                    db.SaveChanges();
                    var error = new Error("Вы успешно обновили");
                    error.Show();
                    this.Close();

                }
            }
            catch (InvalidCastException e)
            {
                var error = new Error("Ошибка при обновление ,попробуйте еще раз");
                error.Show();
                this.Close();

            }



        }





        private void AddWorker(string number = null)
        {


            using (var db = new CompanyContext())
            {

                if (db.Workers.Select(x => x.Employee_number) == null)
                {
                    Info_label.Text = "Номер работника существует";
                    return;
                }

                Worker worker = new Worker()
                {
                    Employee_number = Employee_number.Text,
                    Name = Namee.Text,
                    Surname = Surname.Text,
                    Fatherland = fatherland.Text,
                    NumberPhone = NumberPhone.Text,
                    Address = Addres.Text,
                    Salary = Math.Round(decimal.Parse(Salary.Text), 2),
                    Department = db.Departments.Single(x => x.NameDepartment == Departamet.Text),
                    Position = db.Positions.Single(x => x.NamePosition == Position.Text),
                    KPI = db.KPI.Single(x => x.Grade == KPI.Text)



                };

                db.Add(worker);
                db.SaveChanges();

            }



        }
        private void Add_Batton_Click(object sender, EventArgs e)
        {
            Info_label.Text = "";
            if (Valid())
            {
                if (Add_Batton.Text == "Редактировать")
                {
                    Update_Worker(Employee_number.Text);

                }
                else if (Add_Batton.Text == "Добавить Работника")
                {
                    AddWorker();
                    var infovalid = new Error("Успешно добаил работника");
                    infovalid.Show();
                    this.Close();
                }
                //add
            }

        }

        private void NumberPhone_TextChanged(object sender, EventArgs e)
        {


        }

        private void NumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Salary_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;


            if (!Char.IsDigit(number) && number != ',' && number != 8)
            {

                e.Handled = true;
            }
        }

        private bool ValidCHar(char cha, string s = null)
        {
            string str = "йцукенгшщзхъэждлорпавыфячсмиьбю" + s;

            foreach (var item in str)
            {
                if (cha.ToString().ToLower().ToCharArray()[0] == item)
                {
                    return false;
                }

            }
            return true;

        }
        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {


            char number = e.KeyChar;

            if (ValidCHar(number) && e.KeyChar != 8)
            {

                e.Handled = true;
            }
        }

        private void Surname_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (ValidCHar(number) && e.KeyChar != 8)
            {

                e.Handled = true;
            }
        }

        private void fatherland_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (ValidCHar(number) && e.KeyChar != 8)
            {

                e.Handled = true;
            }
        }

        private void Addres_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (ValidCHar(number, "., ") && number != 8)
            {

                e.Handled = true;
            }
        }


        private void Clear_Button_Click(object sender, EventArgs e)
        {

            Employee_number.Text = "";
            Namee.Text = "";
            Surname.Text = "";
            fatherland.Text = "";
            NumberPhone.Text = "";
            Addres.Text = "";
            Salary.Text = "";

        }

        private void KPI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Position_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Departamet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void fatherland_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (ValidCHar(number) && e.KeyChar != 8)
            {

                e.Handled = true;
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            using (var db = new CompanyContext())
            {
                var deletew = db.Workers.Single(x => x.Employee_number == Employee_number.Text);
                db.Remove(deletew);
                db.SaveChanges();
            };
            new Error("Выуспещко удалили работники").Show();
            this.Close();
        }

        private void Position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
