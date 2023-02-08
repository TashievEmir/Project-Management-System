using Project_Management_System.TreeView;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System
{
    public class ProjectContext:DbContext
    {
        public ProjectContext() : base("DbConnection") { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<ProjectType> projectTypes { get; set; }
        public DbSet<PrStatus> prStatuses { get; set; }
        public DbSet<ProjectKmTas> projectKmTases { get; set; }
        public DbSet<PrGorevler> projectGorevlers { get; set; }
    }
}
