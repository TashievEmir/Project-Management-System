using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System
{
    public class PrStatus
    {
        [Key]
        public int statusId { get; set; }
        public string statusName { get; set; }
    }
}
