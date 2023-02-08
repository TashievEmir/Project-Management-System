using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System
{
    public class Project
    { 
       // [Key]
        public int ProjectId { get; set; }

        public string Name { get; set; }

        [ForeignKey("PersonManager")]
        public int Manager { get; set; }
        public Person PersonManager { get; set; }

        public string Purpose { get; set; }

        [ForeignKey("PrStatus")]
        public int Status { get; set; }
        public PrStatus PrStatus { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Payment { get; set; }
        public string PaymentType { get; set; }
        public int TeamAmount { get; set; }

        [ForeignKey("TypeName")]
        public int PrType { get; set; }
        public ProjectType TypeName { get; set; }
    }
}
