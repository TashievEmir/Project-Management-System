using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System
{
    public class ProjectType
    {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
