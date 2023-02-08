using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project_Management_System
{
    public partial class Form1 : Form
    {
        Form_Proje form_Project = new Form_Proje();
        bool signIn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            using (ProjectContext db = new ProjectContext())
            {           
                var comparingPerson = db.Persons.Where(x => x.Name == tB_Nickname.Text).Select(x =>new { x.Name, x.Password }).OrderBy(x=>x).ThenBy(x=>x).ToList(); 
                foreach(var person in comparingPerson)
                {
                    if (tB_Nickname.Text == person.Name && tB_Password.Text == person.Password)
                    {
                        signIn = true;
                        break;
                    }
                }
                if (signIn)
                {
                    this.Hide();
                    form_Project.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect name or password");
                }
            }              
        }
    }
}
