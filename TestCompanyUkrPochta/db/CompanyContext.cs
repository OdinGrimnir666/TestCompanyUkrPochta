using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCompanyUkrPochta.db
{
    public class CompanyContext : DbContext
    {

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<KPI> KPIS { get; set; }

        public string DbPath { get; set;}

        public CompanyContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Company.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }


    public class Worker
    {
        
        public int id { get; set; }
        public string Employee_number { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string fatherland { get; set; }

        public string NumberPhone { get; set; }

        public string Address { get; set; }

        public int? DepartmentId { get; set; }


        public Department Department { get; set; }

        public int? PositionId { get; set; }


  
        public Position Position { get; set; }
        public int Salary { get; set; }

        public KPI KPI { get; set; }


    }

    public class Position
    {
        public int id { get; set; }

        public string NamePosition { get; set; }

        public List<Worker> Worker { get; set; }
    }

    public class Department
    {
        public int id { get; set; }

        public List<Worker> Worker { get; set; }

        public string NameDepartment { get; set; }
    }

    public class KPI
    {
        public int id { get; set; }

        public string Grade { get; set; }
    }
}
