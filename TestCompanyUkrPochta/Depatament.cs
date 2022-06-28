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
    public partial class Depatament : Form
    {

        public Depatament()
        {
            InitializeComponent();
            Ddd_depatament_Grid();
        }

        private void AddDepartamen_button_Click(object sender, EventArgs e)
        {
            string name = departament_textbox.Text;

            if(name=="")
            {
                info_error("Не может быть название пустое", Color.Red);
                return;

            }

            using (var db = new CompanyContext())
            {
                try
                {

                    db.Departments.Add(new Department { NameDepartment = name });
                    db.SaveChanges();
                    Ddd_depatament_Grid();
                    info_error("Успешно добавила должность", Color.Green);
                }
                catch
                {
                    info_error("Нельзя добавлять одинаковую должность", Color.Red);
                    departament_textbox.Text = "";

                }
                finally
                {
                    Ddd_depatament_Grid();
                }

            };



        }


        private void Ddd_depatament_Grid()
        {

            Grid_Depatament.Rows.Clear();
            using (var db = new CompanyContext())
            {


                Grid_Depatament.Rows.Clear();

                if (db.Departments.Count() > 0)
                {
                    var listpossition = db.Departments.ToList();
                    foreach (var item in listpossition)
                    {
                        Grid_Depatament.Rows.Add(item.NameDepartment,
                            new DataGridViewButtonColumn().Text = "Редактирова",
                            new DataGridViewButtonColumn().Text = "Удаить");
                    }
                }
            };

        }




        private void info_error(string eroor, Color color)
        {
            info_model.Text = eroor;
            info_model.ForeColor = color;
        }

        private void Depatament_Load(object sender, EventArgs e)
        {

        }


        private void update_depatr_button_Click(object sender, EventArgs e)
        {
            if (update_textname.Text != "" && name_update_depatramen_text.Text != "")
            {
                using (var db = new CompanyContext())
                {


                    try
                    {
                        var position = db.Departments.Single(x => x.NameDepartment == name_update_depatramen_text.Text);
                        position.NameDepartment = update_textname.Text.Trim();
                        db.SaveChanges();
                        info_error("Обновление данных успешно завершилась", Color.Green);
                        Ddd_depatament_Grid();
                        name_update_depatramen_text.Text = "";
                        update_textname.Text = "";

                    }
                    catch
                    {
                        info_error("Произошла ошибка с обновление данных", Color.Red);
                    }
                }
            }

        }

        private void Grid_Depatament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Grid_Depatament.Columns["update"].Index && e.RowIndex >= 0)
            {
                String testValue1 = (String)Grid_Depatament[0, e.RowIndex].Value;
                name_update_depatramen_text.Text = testValue1;


            }
            else if (e.ColumnIndex == Grid_Depatament.Columns["delete"].Index && e.RowIndex >= 0)
            {
                String testValue1 = (String)Grid_Depatament[0, e.RowIndex].Value;
                DeleteDepatamet(testValue1);


            }
        }

        private void DeleteDepatamet(string testValue1)
        {
            using (var db = new CompanyContext())
            {
                var worker_delete_pos = db.Workers.Where(x => x.PositionId == db.Positions.Single(x => x.NamePosition == testValue1).id);

                foreach (var item in worker_delete_pos)
                {
                    item.PositionId = null;
                }

                var delPos = db.Departments.Single(x => x.NameDepartment == testValue1);
                db.Remove(delPos);
                db.SaveChanges();
                Ddd_depatament_Grid();
                name_update_depatramen_text.Text = "";
                update_textname.Text = "";
            };
        }

        private void name_update_depatramen_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
