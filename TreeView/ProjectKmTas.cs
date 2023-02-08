using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.TreeView
{
    public class ProjectKmTas
    {
        [Key]
        public int prKmTasId { get; set; }
        public string prName { get; set; }
        public string kmTas { get; set; }
        public string kmTas2 { get; set; }
    }
}
