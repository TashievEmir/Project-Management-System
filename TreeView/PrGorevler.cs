using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.TreeView
{
    public class PrGorevler
    {
        [Key]
        public int PrGorevlerId { get; set; }
        public string gorKmTas { get; set; }
        public string gorev { get; set; }
        public string gorev2 { get; set; }
    }
}
