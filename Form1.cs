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
        string Admin_Login = "Admin";
        string Admin_Haslo = "Admin1";
        public Form1()
        {
            InitializeComponent();
            //listBox1.DataSource = people;
           // listBox1.DisplayMember = "FullInfo";
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

        private void Rektor_Button_Send_Click(object sender, EventArgs e)
        {
            Student S_obj = new Student();

            S_obj.Department_p = Convert.ToInt32(Department_textbox.Text);
            S_obj.FirstName_P = Convert.ToString(Name_textbox.Text);
            S_obj.LastName_p = Convert.ToString(surname_textbox.Text);
            S_obj.Year_p = Convert.ToInt32(year_textbox.Text);
            S_obj.Index_Number_P = Convert.ToInt32(Index_Number_textbox.Text);
            S_obj.Study_Level_p = Convert.ToInt32(Study_level_textbox.Text);
            S_obj.Deficit_P = Convert.ToInt32(deficit_textbox.Text);
            S_obj.Average_P = Convert.ToString(average_textbox.Text);
            S_obj.Semester_P = Convert.ToInt32(Semester_textbox.Text);
            S_obj.Achievements_P = Convert.ToInt32(achievements_textbox.Text);
            S_obj.Bank_Account_Number_p = Convert.ToString(Bank_account_textBox.Text);

            if (S_obj.Deficit_P > 0)
            {
                MessageBox.Show("Nie możesz mieć stypendium, masz deficyt!");
            }
            else
            {
                DataAccess db = new DataAccess();
                db.SendStudent(S_obj.FirstName_P, S_obj.LastName_p, S_obj.Department_p, S_obj.Index_Number_P, S_obj.Study_Level_p, S_obj.Year_p, S_obj.Average_P, S_obj.Achievements_P, S_obj.Deficit_P, S_obj.Semester_P, S_obj.Bank_Account_Number_p);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople();
           // listBox1.DataSource = people;
            //listBox1.DisplayMember = "FullInfo";
        }

        

        private void Admin_Log_Button_Click(object sender, EventArgs e)
        {
            if(Admin_Haslo_Textbox.Text == Admin_Haslo && Admin_Login_Textbox.Text == Admin_Login)
            {
                Okienko_Admin Okno = new Okienko_Admin();
                Okno.Show();
            }
            else
            {
                MessageBox.Show("Błędne dane");
            }

            
        }
    }
    
}
