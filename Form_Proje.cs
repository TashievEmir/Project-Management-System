using DevExpress.Data.ODataLinq.Helpers;
using Project_Management_System.PhoneNumbers;
using Project_Management_System.TreeView;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class Form_Proje : Form
    {
        bool sidebarExpand;
        bool toolStripCondition;
        Form_KapsamProjectTask form_KapsamProjectTask;
        Form_RegistrationEmployee form_registrationEmployee;
        Form_CreateProject form_CreateProject;
        CreateTreeView createTree = new CreateTreeView();

        string checkedRBName;
        public Form_Proje()
        {
            InitializeComponent();
            toolStrip.Hide();
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripCondition == true)
            {
                toolStrip.Hide();
                toolStripCondition = false;
            }
            else
            {
                toolStrip.Show();
                toolStripCondition = true;
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripCondition == true)
            {
                toolStrip.Hide();
                toolStripCondition = false;
            }
            else
            {
                toolStrip.Show();
                toolStripCondition = true;
            }
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripCondition == true)
            {
                toolStrip.Hide();
                toolStripCondition = false;
            }
            else
            {
                toolStrip.Show();
                toolStripCondition = true;
            }
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripCondition == true)
            {
                toolStrip.Hide();
                toolStripCondition = false;
            }
            else
            {
                toolStrip.Show();
                toolStripCondition = true;
            }
        }
        //For openeing or closing sidebar
        private void lbC_PLanning_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        //showing the existing projects
        private void sBtn_ProjectTask_Click(object sender, EventArgs e)
        {
            if (!IsFormActivated(form_KapsamProjectTask))
            {
                form_KapsamProjectTask = new Form_KapsamProjectTask();
                form_KapsamProjectTask.MdiParent = this;
                form_KapsamProjectTask.Show();
                using (ProjectContext db = new ProjectContext())
                {
                    foreach (var item in db.Projects)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(form_KapsamProjectTask.dataGridView1);
                        newRow.Cells[0].Value = item.ProjectId;
                        newRow.Cells[1].Value = item.Name;
                        var manag = db.Persons.Where(x => x.PersonId == item.Manager).OrderBy(x => x.PersonId).ThenBy(z => z.Name).Select(y => y.Name).ToList();
                        newRow.Cells[2].Value = manag[0];
                        newRow.Cells[3].Value = item.Purpose;
                        var st = db.prStatuses.Where(x => x.statusId == item.Status).OrderBy(x => x.statusId).ThenBy(y => y.statusName).Select(x => x.statusName).ToList();
                        newRow.Cells[4].Value = st[0];
                        newRow.Cells[5].Value = item.StartDate;
                        newRow.Cells[6].Value = item.EndDate;
                        newRow.Cells[7].Value = item.Payment;
                        newRow.Cells[8].Value = item.PaymentType;
                        newRow.Cells[9].Value = item.TeamAmount;
                        var typ = db.projectTypes.Where(x => x.Id == item.PrType).OrderBy(x => x.Id).ThenBy(x => x.Name).Select(x => x.Name).ToList();
                        newRow.Cells[10].Value = typ[0];
                        checkProjectStatus(newRow, item.StartDate, item.EndDate, item.Status);
                        form_KapsamProjectTask.dataGridView1.Rows.Add(newRow);
                    }
                }
            }
            else
            {
                form_KapsamProjectTask.MdiParent = this;
                form_KapsamProjectTask.Show();
            }

        }
        /*call function of controling the statuse of project*/
        private void checkProjectStatus(DataGridViewRow newRow, DateTime startDate, DateTime endDate, int status)
        {
            if (startDate > DateTime.Now && status == 1)
                newRow.DefaultCellStyle.BackColor = Color.Gray;
            else if (startDate < DateTime.Now && status == 1)
                newRow.DefaultCellStyle.BackColor = Color.Red;
            else if (endDate < DateTime.Now && status == 2)
                newRow.DefaultCellStyle.BackColor = Color.Red;
            else if (status == 3)
                newRow.DefaultCellStyle.BackColor = Color.Green;
            else
                newRow.DefaultCellStyle.BackColor = Color.Aqua;
        }
        //for sidebar
        private void timer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                fLPanel.Width -= 10;
                if (fLPanel.Width == fLPanel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timer.Stop();
                }
            }
            else
            {
                fLPanel.Width += 10;
                if (fLPanel.Width == fLPanel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timer.Stop();
                }
            }
        }
        // adding new project
        private void sBtn_Project_Click(object sender, EventArgs e)
        {
            if (!IsFormActivated(form_CreateProject))
            {
                form_CreateProject = new Form_CreateProject();
                form_CreateProject.MdiParent = this;
                form_CreateProject.Show();
                using (ProjectContext db = new ProjectContext())
                {
                    //make choosing the project manager among existing person
                    foreach (var item in db.Persons)
                    {
                        form_CreateProject.cB_managers.Items.Add(item.Name);
                    }
                    //make choosing the project types among existing types
                    foreach (var item in db.projectTypes)
                    {
                        form_CreateProject.cB_prTypes.Items.Add(item.Name);
                    }
                }
            }
            else
            {
                form_CreateProject.MdiParent = this;
                form_CreateProject.Show();
            }
        }
        //function which control is form active or not
        private bool IsFormActivated(Form form)
        {
            bool isOpened = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form != null)
                    {
                        if (form.Name == item.Name)
                        {
                            xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                            isOpened = true;
                        }
                    }
                    else break;
                }
            }
            return isOpened;
        }
        // opens Employee form
        private void sBtn_Employee_Click(object sender, EventArgs e)
        {
            if (!IsFormActivated(form_registrationEmployee))
            {
                form_registrationEmployee = new Form_RegistrationEmployee();
                form_registrationEmployee.MdiParent = this;
                form_registrationEmployee.Show();
            }
            else
            {
                form_registrationEmployee.MdiParent = this;
                form_registrationEmployee.Show();
            }
        }
        // control checked radio button
        private bool checkedRB()
        {
            if (form_CreateProject.rBt_weekly.Checked == true) { checkedRBName = "weekly"; return true; }
            else if (form_CreateProject.rBt_monthly.Checked == true) { checkedRBName = "monthly"; return true; }
            else if (form_CreateProject.rBt_yearly.Checked == true) { checkedRBName = "yearly"; return true; }
            else return false;
        }
        private bool checkAllBlanketsFilled()
        {
            if (form_CreateProject.tEdit_projectName.Text != null && form_CreateProject.tEdit_projectName.Text != "" &&
                form_CreateProject.cB_managers.Text != null && form_CreateProject.cB_managers.Text != "" &&
                form_CreateProject.tEd_prPurpose.Text != null && form_CreateProject.tEd_prPurpose.Text != "" &&
                form_CreateProject.startDate.Text != null && form_CreateProject.startDate.Text != "" &&
                form_CreateProject.endDate.Text != null && form_CreateProject.endDate.Text != "" &&
                form_CreateProject.cLB_projectStatus.Text != null && form_CreateProject.cLB_projectStatus.Text != "" &&
                form_CreateProject.tEd_payment.Text != null && form_CreateProject.tEd_payment.Text != "" &&
                form_CreateProject.nUD_teamAmount.Value != null && form_CreateProject.cB_prTypes.Text != "" &&
                form_CreateProject.cB_prTypes.Text != null && checkedRB()
                    ) return true;
            else return false;
        }
        //save new data
        private void tSBtn_Save_Click(object sender, EventArgs e)
        {
            var currentPageName = xtraTabbedMdiManager1.SelectedPage;

            if (currentPageName == null)
            {
                MessageBox.Show("There is no opened page!");
            }
            else if (currentPageName.Text == "Form_KapsamProjectTask")
            {
                MessageBox.Show("Save button doesn't work with ProjectTask tab!");
            }
            else if (currentPageName.Text == "Form_RegistrationEmployee")
            {
                if (form_registrationEmployee.tEdit_username.Text != null && form_registrationEmployee.tEdit_username.Text != "" &&
                    form_registrationEmployee.tEdit_password.Text != null && form_registrationEmployee.tEdit_password.Text != "")
                {
                    string personName = form_registrationEmployee.tEdit_username.Text;
                    string personSurname = form_registrationEmployee.tEdit_surname.Text;
                    short personAge = Convert.ToInt16(form_registrationEmployee.nUpD_age.Value);
                    string personPassword = form_registrationEmployee.tEdit_password.Text;
                    string personStatus = form_registrationEmployee.cBEdit_status.Text;
                    string personProject = form_registrationEmployee.tEdit_project.Text;
                    string personPhoneNumber = form_registrationEmployee.tE_phoneNumber.Text;
                    using (ProjectContext db = new ProjectContext())
                    {
                        Person person = new Person
                        {
                            Name = personName,
                            Surname = personSurname,
                            Age = personAge,
                            Password = personPassword,
                            Status = personStatus,
                            PersonProject = personProject,
                            PhoneNumbers=personPhoneNumber
                        };
                        db.Persons.Add(person);
                        db.SaveChanges();
                        MessageBox.Show("The datas succesfully saved");
                    }
                }
                else
                {
                    MessageBox.Show("For create account you must fill the name and password!");
                }
            }
            else if (currentPageName.Text == "Form_CreateProject")
            {
                if (checkAllBlanketsFilled())
                {
                    string prName = form_CreateProject.tEdit_projectName.Text;
                    string prManager = form_CreateProject.cB_managers.Text;
                    string prPurpose = form_CreateProject.tEd_prPurpose.Text;
                    string prStatus = form_CreateProject.cLB_projectStatus.Text;
                    DateTime startDate = Convert.ToDateTime(form_CreateProject.startDate.Text);
                    DateTime endDate = Convert.ToDateTime(form_CreateProject.endDate.Text);
                    int prPayment = Convert.ToInt32(form_CreateProject.tEd_payment.Text);
                    string paymentType = checkedRBName;
                    short teamAmount = Convert.ToInt16(form_CreateProject.nUD_teamAmount.Value);
                    string prType = form_CreateProject.cB_prTypes.Text;

                    using (ProjectContext db = new ProjectContext())
                    {
                        Person person = db.Persons.FirstOrDefault(x => x.Name == prManager);
                        PrStatus prstat = db.prStatuses.FirstOrDefault(x => x.statusName == prStatus);
                        ProjectType projectType = db.projectTypes.FirstOrDefault(x => x.Name == prType);
                        if (person.Name != null && person.Name != "" &&
                            prstat.statusName != null && prstat.statusName != "" &&
                            projectType.Name != null && projectType.Name != "")
                        {
                            Project project = new Project
                            {
                                Name = prName,
                                Manager = person.PersonId,
                                Purpose = prPurpose,
                                Status = prstat.statusId,
                                StartDate = startDate,
                                EndDate = endDate,
                                Payment = prPayment,
                                PaymentType = paymentType,
                                TeamAmount = teamAmount,
                                PrType = projectType.Id
                            };
                            db.Projects.Add(project);
                            db.SaveChanges();
                            MessageBox.Show("The datas succesfully saved");
                        }
                        else
                        {
                            MessageBox.Show("The such manager or status or prTtype doesn't exist ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("For create project you must fill all blankets!");
                }
            }
            else
            {
                if (checkBlanksOfNewMilestone())
                {
                    string prName, kmTas, kmTas2, gorev, gorev2, gorev3, gorev4;
                    prName = createTree.cb_pr.Text;
                    kmTas = createTree.tB_kmTas.Text;
                    kmTas2 = createTree.tB_kmTas2.Text;
                    gorev = createTree.tB_gorev.Text;
                    gorev2 = createTree.tB_gorev2.Text;
                    gorev3 = createTree.tB_gorev3.Text;
                    gorev4 = createTree.tB_gorev4.Text;
                    using (ProjectContext db = new ProjectContext())
                    {
                        ProjectKmTas projectKmTas = new ProjectKmTas
                        {
                            prName = prName,
                            kmTas = kmTas,
                            kmTas2 = kmTas2
                        };
                        db.projectKmTases.Add(projectKmTas);
                        db.SaveChanges();
                        PrGorevler prGorevler = new PrGorevler
                        {
                            gorKmTas = kmTas,
                            gorev = gorev,
                            gorev2 = gorev2
                        };
                        db.projectGorevlers.Add(prGorevler);
                        db.SaveChanges();
                        PrGorevler prgorevler = new PrGorevler
                        {
                            gorKmTas = kmTas2,
                            gorev = gorev3,
                            gorev2 = gorev4
                        };
                        db.projectGorevlers.Add(prgorevler);
                        db.SaveChanges();
                    }
                    MessageBox.Show("The datas have saved successfully!");
                }
                else
                {
                    MessageBox.Show("Fill all blanks!");
                }
            }
        }
        private bool checkBlanksOfNewMilestone()
        {
            if (createTree.cb_pr.Text == null && createTree.cb_pr.Text == "" &&
            createTree.tB_kmTas.Text == null && createTree.tB_kmTas.Text == "" &&
            createTree.tB_kmTas2.Text == null && createTree.tB_kmTas2.Text == "" &&
            createTree.tB_gorev.Text == null && createTree.tB_gorev.Text == "" &&
            createTree.tB_gorev2.Text == null && createTree.tB_gorev2.Text == "" &&
            createTree.tB_gorev3.Text == null && createTree.tB_gorev3.Text == "" &&
            createTree.tB_gorev4.Text == null && createTree.tB_gorev4.Text == ""
                ) return true;
            else return false;
        }
        // clear the blankes in the forms
        private void tSBtn_Refresh_Click(object sender, EventArgs e)
        {
            var currentPageName = xtraTabbedMdiManager1.SelectedPage;
            if (currentPageName.Text == "Form_CreateProject")
            {
                form_CreateProject.tEdit_projectName.Text = "";
                form_CreateProject.cB_managers.Text = "";
                form_CreateProject.tEd_prPurpose.Text = "";
                form_CreateProject.startDate.Text = "";
                form_CreateProject.endDate.Text = "";
                form_CreateProject.cLB_projectStatus.Text = "";
                form_CreateProject.tEd_payment.Text = "";
                form_CreateProject.cB_prTypes.Text = "";
                form_CreateProject.rBt_weekly.Checked = false;
                form_CreateProject.rBt_monthly.Checked = false;
                form_CreateProject.rBt_yearly.Checked = false;
            }
            else if (currentPageName.Text == "Form_KapsamProjectTask")
            {
                using (ProjectContext db = new ProjectContext())
                {
                    form_KapsamProjectTask.dataGridView1.Rows.Clear();
                    foreach (var item in db.Projects)
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(form_KapsamProjectTask.dataGridView1);
                        newRow.Cells[0].Value = item.ProjectId;
                        newRow.Cells[1].Value = item.Name;
                        var manag = db.Persons.Where(x => x.PersonId == item.Manager).OrderBy(x=>x.PersonId).ThenBy(z=>z.Name).Select(y=>y.Name).ToList();
                        newRow.Cells[2].Value = manag[0];
                        newRow.Cells[3].Value = item.Purpose;
                        var st = db.prStatuses.Where(x => x.statusId == item.Status).OrderBy(x=>x.statusId).ThenBy(y=>y.statusName).Select(x => x.statusName).ToList();
                        newRow.Cells[4].Value = st[0];
                        newRow.Cells[5].Value = item.StartDate;
                        newRow.Cells[6].Value = item.EndDate;
                        newRow.Cells[7].Value = item.Payment;
                        newRow.Cells[8].Value = item.PaymentType;
                        newRow.Cells[9].Value = item.TeamAmount;
                        var typ = db.projectTypes.Where(x => x.Id == item.PrType).OrderBy(x=>x.Id).ThenBy(x=>x.Name).Select(x=>x.Name).ToList();
                        newRow.Cells[10].Value = typ[0];
                        checkProjectStatus(newRow, item.StartDate, item.EndDate, item.Status);
                        form_KapsamProjectTask.dataGridView1.Rows.Add(newRow);
                    }
                }
            }
            else if (currentPageName.Text == "Form_RegistrationEmployee")
            {
                form_registrationEmployee.tEdit_username.Text = "";
                form_registrationEmployee.tEdit_surname.Text = "";
                form_registrationEmployee.tEdit_password.Text = "";
                form_registrationEmployee.tEdit_project.Text = "";
                form_registrationEmployee.cBEdit_status.Text = "";
                form_registrationEmployee.nUpD_age.Value = 18;
            }
            else
            {
                createTree.cb_pr.Text = "";
                createTree.tB_kmTas.Text = "";
                createTree.tB_kmTas2.Text = "";
                createTree.tB_gorev.Text = "";
                createTree.tB_gorev2.Text = "";
                createTree.tB_gorev3.Text = "";
                createTree.tB_gorev4.Text = "";
            }
        }
        // opens the new form
        private void tSBtn_New_Click(object sender, EventArgs e)
        {
            var currentPageName = xtraTabbedMdiManager1.SelectedPage;
            if (currentPageName == null)
            {
                MessageBox.Show("There is no opened page!");
            }
            else if (currentPageName.Text == "Form_KapsamProjectTask")
            {
                Form_KapsamProjectTask createProjectTaskTab = new Form_KapsamProjectTask();
                createProjectTaskTab.MdiParent = this;
                createProjectTaskTab.Show();
            }
            else if (currentPageName.Text == "Form_RegistrationEmployee")
            {
                Form_RegistrationEmployee registrationEmployeeTab = new Form_RegistrationEmployee();
                registrationEmployeeTab.MdiParent = this;
                registrationEmployeeTab.Show();
            }
            else
            {
                Form_CreateProject createProjectTab = new Form_CreateProject();
                createProjectTab.MdiParent = this;
                createProjectTab.Show();
            }
        }
        // delete the one project from project list in database
        private void tSBtn_Delete_Click(object sender, EventArgs e)
        {
            var currentPageName = xtraTabbedMdiManager1.SelectedPage;

            if (currentPageName == null)
            {
                MessageBox.Show("There is no opened page!");
            }
            else if (currentPageName.Text == "Form_KapsamProjectTask")
            {
                if (form_KapsamProjectTask.dataGridView1.SelectedRows == null)
                {
                    MessageBox.Show("At first you need choose row for deleting");
                }
                else
                {
                    foreach (DataGridViewRow row in form_KapsamProjectTask.dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);

                        using (ProjectContext db = new ProjectContext())
                        {
                            var selRow = db.Projects.FirstOrDefault(x => x.ProjectId == id);
                            db.Projects.Remove(selRow);
                            db.SaveChanges();
                        }
                        form_KapsamProjectTask.dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else if (currentPageName.Text == "Form_RegistrationEmployee")
            {
                MessageBox.Show("Delete button works only with a row in dataGridView");
            }
            else
            {
                MessageBox.Show("Delete button works only with a row in dataGridView");
            }
        }
        // close active form
        private void tSBtn_Back_Click(object sender, EventArgs e)
        {
            var tempForm = ActiveMdiChild;
            if (tempForm == null)
            {
                MessageBox.Show("There isn't opened tab");
            }
            else ActiveMdiChild.Close();
        }

        private void tSBtn_Forward_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have not able to implement it :(:(");
        }

        // allow to see the milestones of the chosen project from datagridview
        private void tSBtn_Cancel_Click(object sender, EventArgs e)
        {
            var currentPageName = xtraTabbedMdiManager1.SelectedPage;

            if (currentPageName == null)
            {
                MessageBox.Show("There is no opened page!");
            }
            else if (currentPageName.Text == "Form_KapsamProjectTask")
            {
                if (form_KapsamProjectTask.dataGridView1.SelectedRows == null)
                    MessageBox.Show("At first you need choose row for see milestones");
                else
                {
                    string prName, kmTas, kmTas2, gorev, gorev2, gorev3, gorev4;
                    foreach (DataGridViewRow row in form_KapsamProjectTask.dataGridView1.SelectedRows)
                    {
                        prName = row.Cells[1].Value.ToString();
                        if (prName == null || prName == "")
                        {
                            MessageBox.Show("At first you need choose row for see milestones");
                            break;
                        }
                        using (ProjectContext db = new ProjectContext())
                        {
                            var rowKmTas = db.projectKmTases.FirstOrDefault(x => x.prName == prName);
                            kmTas = rowKmTas.kmTas;
                            kmTas2 = rowKmTas.kmTas2;
                            var rowGorevler = db.projectGorevlers.FirstOrDefault(x => x.gorKmTas == kmTas);
                            gorev = rowGorevler.gorev;
                            gorev2 = rowGorevler.gorev2;
                            rowGorevler = db.projectGorevlers.FirstOrDefault(y => y.gorKmTas == kmTas2);
                            gorev3 = rowGorevler.gorev;
                            gorev4 = rowGorevler.gorev2;
                        }
                        TreeNode parentNode = new TreeNode(prName);
                        parentNode.Nodes.Add(kmTas);
                        parentNode.Nodes[0].Nodes.Add(gorev);
                        parentNode.Nodes[0].Nodes.Add(gorev2);
                        parentNode.Nodes.Add(kmTas2);
                        parentNode.Nodes[1].Nodes.Add(gorev3);
                        parentNode.Nodes[1].Nodes.Add(gorev4);
                        Form_TreeView form_TreeView = new Form_TreeView();
                        form_TreeView.treeView1.Nodes.Add(parentNode);
                        form_TreeView.Show();
                    }
                }
            }
            else if (currentPageName.Text == "Form_RegistrationEmployee")
            {
                MessageBox.Show("Milestones button works only with a row in dataGridView");
            }
            else
            {
                MessageBox.Show("Milestones button works only with a row in dataGridView");
            }
        }
        // form of create milestone
        private void tSBtn_NewMilestones_Click(object sender, EventArgs e)
        {
            if (!IsFormActivated(createTree))
            {
                createTree = new CreateTreeView();
                createTree.MdiParent = this;
                createTree.Show();
                using (ProjectContext db = new ProjectContext())
                {
                    foreach (var item in db.Projects)
                    {
                        createTree.cb_pr.Items.Add(item.Name);
                    }
                }
            }
            else
            {
                createTree.MdiParent = this;
                createTree.Show();
            }
        }
        //show phone numbers of employees
        private void tSBtn_PhoneNumber_Click(object sender, EventArgs e)
        {
            var currentPageName = xtraTabbedMdiManager1.SelectedPage;

            if (currentPageName == null)
            {
                MessageBox.Show("There is no opened page!");
            }
            else if (currentPageName.Text == "Form_KapsamProjectTask")
            {
                if (form_KapsamProjectTask.dataGridView1.SelectedRows == null)
                    MessageBox.Show("At first you need choose row for see milestones");
                else
                {
                    Dictionary<string, string> phoneNum = new Dictionary<string, string>();
                    string prName;
                    foreach (DataGridViewRow row in form_KapsamProjectTask.dataGridView1.SelectedRows)
                    {
                        prName = row.Cells[1].Value.ToString();
                        if (prName == null || prName == "")
                        {
                            MessageBox.Show("At first you need choose row for see milestones");
                            break;
                        }
                        string dbConnect = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                        using (SqlConnection sqlConnection = new SqlConnection(dbConnect))
                        {
                            sqlConnection.Open();
                            string cmd= $"use Vize SELECT ProjectId FROM Projects WHERE Name='{prName}'";
                            SqlCommand command = new SqlCommand(cmd,sqlConnection);
                            SqlDataReader reader = command.ExecuteReader();

                            cmd= "SELECT Name,PhoneNumbers,PersonProject FROM People";
                            SqlCommand command2 = new SqlCommand(cmd,sqlConnection);
                            SqlDataReader reader2 = command2.ExecuteReader();
                            if (reader2.HasRows)
                            {
                                reader.Read();
                                string prId = reader["ProjectId"].ToString();
                                while (reader2.Read() )
                                {    
                                    string prId2 = reader2["PersonProject"].ToString();
                                    if (prId == prId2)
                                    {
                                        phoneNum.Add(reader2.GetValue(0).ToString(), reader2.GetValue(1).ToString());
                                    }
                                }
                            }
                            TreeNode parentNode = new TreeNode(prName);
                            int i = 0;
                            foreach (var item in phoneNum)
                            {
                                parentNode.Nodes.Add(item.Key);
                                parentNode.Nodes[i].Nodes.Add(item.Value);
                                i++;
                            }
                            Form_PhoneNumbers form_PhoneNumbers = new Form_PhoneNumbers();
                            form_PhoneNumbers.tView_PhoneNumber.Nodes.Add(parentNode);
                            form_PhoneNumbers.Show();
                        } 

                        /*using (ProjectContext db = new ProjectContext())
                        {
                            var projectId = db.Projects.FirstOrDefault(x=>x.Name==prName);
                            foreach (var items in db.Persons)
                            {
                                if (items.PersonProject == projectId.ProjectId.ToString())
                                {
                                    phoneNum.Add(items.Name,items.PhoneNumbers);
                                }
                            }
                        }
                        TreeNode parentNode = new TreeNode(prName);
                        int i = 0;
                        foreach (var item in phoneNum)
                        {
                            parentNode.Nodes.Add(item.Key);
                            parentNode.Nodes[i].Nodes.Add(item.Value);
                            i++;
                        }
                        Form_PhoneNumbers form_PhoneNumbers = new Form_PhoneNumbers();
                        form_PhoneNumbers.tView_PhoneNumber.Nodes.Add(parentNode);
                        form_PhoneNumbers.Show();*/
                    }
                }
            }
            else if (currentPageName.Text == "Form_RegistrationEmployee")
            {
                MessageBox.Show("Phone numbers button works only with a row in dataGridView");
            }
            else
            {
                MessageBox.Show("Phone numbers button works only with a row in dataGridView");
            }
        }
    }
}
