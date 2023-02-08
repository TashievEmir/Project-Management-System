using DevExpress.XtraReports.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class Form_KapsamProjectTask : Form
    {
        public Form_KapsamProjectTask()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    break;
                case 1:
                    var rowName = dataGridView1.Rows[e.RowIndex];
                    string newName = rowName.Cells[1].Value.ToString();
                    int id = Convert.ToInt32(rowName.Cells[0].Value);
                    using (ProjectContext db =new ProjectContext())
                    {
                        var row2=db.Projects.FirstOrDefault(x => x.ProjectId == id);
                        row2.Name = newName;
                        db.SaveChanges();   
                    }
                    break;
                case 2:
                    var rowMan = dataGridView1.Rows[e.RowIndex];
                    string newMan = rowMan.Cells[2].Value.ToString();
                    int idMan = Convert.ToInt32(rowMan.Cells[0].Value);
                    using (ProjectContext db = new ProjectContext())
                    {
                        var row2 = db.Projects.FirstOrDefault(x => x.ProjectId == idMan);
                        foreach (var item in db.Persons)
                        {
                            if (item.Name == newMan)
                            {
                                row2.Manager = item.PersonId;
                            }
                        }
                        db.SaveChanges();
                    }
                    break;
                case 3:
                    var row = dataGridView1.Rows[e.RowIndex];
                    string newPurpose = row.Cells[3].Value.ToString();
                    int idPurpose = Convert.ToInt32(row.Cells[0].Value);
                    using (ProjectContext db = new ProjectContext())
                    {
                        var row2 = db.Projects.FirstOrDefault(x => x.ProjectId == idPurpose);
                        row2.Purpose = newPurpose;
                        db.SaveChanges();
                    }
                    break;
                case 4:
                    var rowSt = dataGridView1.Rows[e.RowIndex];
                    string newSt = rowSt.Cells[4].Value.ToString();
                    int idSt = Convert.ToInt32(rowSt.Cells[0].Value);
                    using (ProjectContext db = new ProjectContext())
                    {
                        var row2 = db.Projects.FirstOrDefault(x => x.ProjectId == idSt);
                        foreach (var item in db.prStatuses)
                        {
                            if (item.statusName == newSt)
                            {
                                row2.Status = item.statusId;
                            }
                        }
                        db.SaveChanges();
                    }
                    break;
                case 5:
                    var rowStDate = dataGridView1.Rows[e.RowIndex];
                    DateTime newStDate = Convert.ToDateTime(rowStDate.Cells[5].Value);
                    int idStDate = Convert.ToInt32(rowStDate.Cells[0].Value);
                    using (ProjectContext db = new ProjectContext())
                    {
                        var row2 = db.Projects.FirstOrDefault(x => x.ProjectId == idStDate);
                        row2.StartDate = newStDate;
                        db.SaveChanges();
                    }
                    break;
                case 6:
                    var rowEndDate = dataGridView1.Rows[e.RowIndex];
                    DateTime newEndDate = Convert.ToDateTime(rowEndDate.Cells[6].Value);
                    int idEndDate = Convert.ToInt32(rowEndDate.Cells[0].Value);
                    using (ProjectContext db = new ProjectContext())
                    {
                        var row2 = db.Projects.FirstOrDefault(x => x.ProjectId == idEndDate);
                        row2.EndDate = newEndDate;
                        db.SaveChanges();
                    }
                    break;
                case 7:
                    var rowPay = dataGridView1.Rows[e.RowIndex];
                    int newPay = Convert.ToInt32(rowPay.Cells[7].Value);
                    int idPay = Convert.ToInt32(rowPay.Cells[0].Value);
                    using (ProjectContext db = new ProjectContext())
                    {
                        var row2 = db.Projects.FirstOrDefault(x => x.ProjectId == idPay);
                        row2.Payment = newPay;
                        db.SaveChanges();
                    }
                    break;
                case 8:
                    var rowPayT = dataGridView1.Rows[e.RowIndex];
                    string newPayT = rowPayT.Cells[8].Value.ToString();
                    int idPayT = Convert.ToInt32(rowPayT.Cells[0].Value);
                    using (ProjectContext db = new ProjectContext())
                    {
                        var row2 = db.Projects.FirstOrDefault(x => x.ProjectId == idPayT);
                        row2.PaymentType = newPayT;
                        db.SaveChanges();
                    }
                    break;
                case 9:
                    var rowTeam = dataGridView1.Rows[e.RowIndex];
                    int newTeam = Convert.ToInt32(rowTeam.Cells[9].Value);
                    int idTeam = Convert.ToInt32(rowTeam.Cells[0].Value);
                    using (ProjectContext db = new ProjectContext())
                    {
                        var row2 = db.Projects.FirstOrDefault(x => x.ProjectId == idTeam);
                        row2.TeamAmount = newTeam;
                        db.SaveChanges();
                    }
                    break;
                case 10:
                    var rowPrT = dataGridView1.Rows[e.RowIndex];
                    string newPrT = rowPrT.Cells[10].Value.ToString();
                    int idPrT = Convert.ToInt32(rowPrT.Cells[0].Value);
                    using (ProjectContext db = new ProjectContext())
                    {
                        var row2 = db.Projects.FirstOrDefault(x => x.ProjectId == idPrT);
                        foreach(var item in db.projectTypes)
                        {
                            if (item.Name == newPrT)
                            {
                                row2.PrType = item.Id;
                            }
                        }
                        db.SaveChanges();
                    }
                    break;
                default: break;
            }
        }
    }
}
