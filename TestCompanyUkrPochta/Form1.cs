using System.Diagnostics;
using System.Text;
using TestCompanyUkrPochta.db;

namespace TestCompanyUkrPochta
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            SetGrid();
            SetData();
        }

        private void SetData()
        {
            using (var db = new CompanyContext())
            {
                foreach (var item in db.Departments)
                {

                    combo_depatametn.Items.Add(item.NameDepartment);


                }
                combo_depatametn.Items.Add("Все Отделы");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var Position = new Positions();
            Position.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var Departament = new Depatament();
            Departament.Show();
        }

        private void Add_Worker_menu_button_Click(object sender, EventArgs e)
        {
            var formworker = new Add_Worker();
            formworker.Show();
        }




        private void SetGrid(string combo_depatametn = "")
        {

            WorkerGrid.Rows.Clear();
            using (var context = new CompanyContext())
            {
                IOrderedQueryable<Worker>? listpossition;


                if (context.Workers.Count() > 0)
                {
                    if (combo_depatametn == "Все Отделы" | combo_depatametn == "")
                    {
                        listpossition = (IOrderedQueryable<Worker>?)context.Workers.OrderBy(x => x.id);
                    }
                    else
                    {
                        listpossition = (IOrderedQueryable<Worker>?)context.Workers.Where(x => x.DepartmentId == context.Departments.Single(x => x.NameDepartment == combo_depatametn).id);
                    }
                    foreach (var item in listpossition)
                    {

                        string depatrament;
                        string position;
                        string kpi;

                        WorkerGrid.Rows.Add(
                            item.Employee_number,
                            $"{item.Name} {item.Surname} {item.Fatherland}"
                 ,
                            item.NumberPhone,
                            depatrament = item.PositionId != null ? context.Positions.Single(x => x.id == item.PositionId).NamePosition : "Нет Должности",
                            position = item.DepartmentId != null ? context.Departments.Single(x => x.id == item.DepartmentId).NameDepartment : "Нет Отдела",
                            item.Address,
                            item.Salary,
                            kpi = item.KPIid != null ? context.KPI.Single(x => x.id == item.KPIid).Grade : "Нет Kpi",
                            item.Salary + item.Salary * context.KPI.Single(x => x.id == item.KPIid).Surcharge / 100,
                            new DataGridViewButtonColumn().Text = "Редактироваб"

                            );
                    }
                }

            };



        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void WorkerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == WorkerGrid.Columns["update"].Index && e.RowIndex >= 0)
            {
                String testValue1 = (String)WorkerGrid[0, e.RowIndex].Value;
                if (testValue1.Trim() != "")
                {

                    var addworker = new Add_Worker(testValue1);
                    addworker.Show();
                }

            }
        }

        private void Update_Grid_Click(object sender, EventArgs e)
        {
            SetGrid(combo_depatametn.Text);
        }

        private void combo_depatametn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new Payments().Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        public async void Create_Report()
        {

            Process.Start("explorer.exe", @"C:\Users\qwerty\source\repos\TestCompanyUkrPochta\TestCompanyUkrPochta\bin\Debug\net6.0-windows");

            string path = "Report.csv";

            if(WorkerGrid.Rows.Count==0)
            {
                return;
            }

            using (StreamWriter writer = new StreamWriter(new FileStream(path ,FileMode.OpenOrCreate), Encoding.GetEncoding(65001)))
            {

                
                writer.Write("Номер;И.Ф.О;Телефон;Должность;Отдел;Адрес;Оклад;КПИ;Премия "+"\n");
                for (int i = 0; i < WorkerGrid.Rows.Count; i++)
                {

                    for (int j = 0; j < WorkerGrid.Columns.Count - 1; j++)
                    {
                        writer.Write(WorkerGrid.Rows[i].Cells[j].Value.ToString() + ";");
                    }
                    writer.Write("\n");


                }

            }
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            Create_Report();
        }
    }
}