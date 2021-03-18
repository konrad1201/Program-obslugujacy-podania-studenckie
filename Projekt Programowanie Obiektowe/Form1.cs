using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Programowanie_Obiektowe
{
    public partial class Form1 : Form
     {
        List<Student> people = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = people;
            listBox1.DisplayMember = "FullInfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Maximized;
        }

        

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void retora_wybor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
  
            private void button1_Click(object sender, EventArgs e)
            {
                Student Student_obj = new Student();



                Student_obj.Department_p = Convert.ToInt32(faculty_textbox.Text);
                Student_obj.Name_p = Convert.ToString(Name_textbox.Text);
                Student_obj.Surname_p = Convert.ToString(surname_textbox.Text);
                Student_obj.Year_p = Convert.ToInt32(year_textbox.Text);
            }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople();
            listBox1.DataSource = people;
            listBox1.DisplayMember = "FullInfo";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
