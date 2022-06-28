using System.Data;
using System.Data.SqlClient;
using TestCompanyUkrPochta.db;


namespace TestCompanyUkrPochta
{
    public partial class Positions : Form
    {
        public Positions()
        {

            InitializeComponent();

            Ddd_positionGrid();

        }
        private void Ddd_positionGrid()
        {

            using (var db = new CompanyContext())
            {


                Gridposition.Rows.Clear();

                if (db.Positions.Count() > 0)
                {
                    var listpossition = db.Positions.ToList();
                    foreach (var item in listpossition)
                    {
                        Gridposition.Rows.Add(item.NamePosition,
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
        private void Positions_Load(object sender, EventArgs e)
        {

        }

        private void reloadData_Click(object sender, EventArgs e)
        {
        }


        public void DeletePosition(string Name_Position)
        {
            using(var db =new CompanyContext())
            {
                var worker_delete_pos=db.Workers.Where(x => x.PositionId == db.Positions.Single(x => x.NamePosition == Name_Position).id);

                foreach (var item in worker_delete_pos)
                {
                    item.PositionId = null;
                }

                var delPos = db.Positions.Single(x => x.NamePosition == Name_Position);
                db.Remove(delPos);
                db.SaveChanges();
                Ddd_positionGrid();
                name_update_text.Text = "";
                update_textname.Text = "";
            };
        }


        private void Gridposition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Gridposition.Columns["update"].Index && e.RowIndex >= 0)
            {
                String testValue1 = (String)Gridposition[0, e.RowIndex].Value;
                name_update_text.Text = testValue1;


            }
            else if(e.ColumnIndex == Gridposition.Columns["delete"].Index && e.RowIndex >= 0)
            {
                String testValue1 = (String)Gridposition[0, e.RowIndex].Value;
                DeletePosition(testValue1);


            }

        }

        private void Addposition_button_Click(object sender, EventArgs e)
        {

            using (var db = new CompanyContext())
            {


                string name = positionname_textbox.Text;
                if (name == "")
                {
                    info_error("Не может бытб название пустое", Color.Red);
                    return;

                }


                try
                {

                    db.Positions.Add(new Position { NamePosition = name });
                    db.SaveChanges();
                    Ddd_positionGrid();
                    info_error("Успешно добавила должность", Color.Green);
                }
                catch
                {
                    info_error("Нельзя добавлять одинаковую должность", Color.Red);
                    positionname_textbox.Text = "";
                }
                finally
                {
                    Ddd_positionGrid();
                }
            }

        }





        private void positionname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void remove_button_Click(object sender, EventArgs e)
        {

        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (update_textname.Text != "" && name_update_text.Text != "")
            {
                using (var db = new CompanyContext())
                {


                    try
                    {
                        var position = db.Positions.Single(x => x.NamePosition == name_update_text.Text.Trim());
                        position.NamePosition = update_textname.Text.Trim();
                        db.SaveChanges();
                        info_error("Обновление данных успешно завершилась", Color.Green);
                        Ddd_positionGrid();
                        name_update_text.Text = "";
                        update_textname.Text = "";

                    }
                    catch
                    {
                        info_error("Произошла ошибка с обновление данных", Color.Red);
                    }
                }
            }


        }

        private void id_update_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void name_update_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
