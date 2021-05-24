using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
namespace Projekt_Programowanie_Obiektowe
{
    public partial class EdycjaDanych : Form
    {
        public EdycjaDanych()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numerindeksu = Convert.ToString(Index_Number_Textbox.Text);
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
            {
                connection.Execute($"DELETE FROM Studenci where Index_Number = {numerindeksu}");

            }
        }

        private void Search_for_edition_Click(object sender, EventArgs e)
        {
            String numerindeksu = Convert.ToString(Index_Number_Textbox.Text);
            List<Student> Lista_do_Edycji;
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
            {

                Lista_do_Edycji = connection.Query<Student>($"SELECT * FROM Studenci where Index_Number = '{numerindeksu}'").ToList();
                First_Name_textbox.Text = Lista_do_Edycji[0].FirstName_P;
                Department_textbox.Text = Convert.ToString(Lista_do_Edycji[0].Department_p);
                surname_textbox.Text = Lista_do_Edycji[0].LastName_p;
                deficit_textbox.Text = Convert.ToString(Lista_do_Edycji[0].Deficit_P);
                Bank_account_textBox.Text = Convert.ToString(Lista_do_Edycji[0].Bank_Account_Number_p);
                achievements_textbox.Text = Convert.ToString(Lista_do_Edycji[0].Achievements_P);
                average_textbox.Text = Convert.ToString(Lista_do_Edycji[0].Average_P);
                Study_level_textbox.Text = Convert.ToString(Lista_do_Edycji[0].Study_Level_p);
                year_textbox.Text = Convert.ToString(Lista_do_Edycji[0].Year_p);
                Semester_textbox.Text = Convert.ToString(Lista_do_Edycji[0].Semester_P);
                Distance_textbox.Text = Convert.ToString(Lista_do_Edycji[0].Distance_P);
                income_textbox.Text = Convert.ToString(Lista_do_Edycji[0].Income_P);
                Points_textbox.Text = Lista_do_Edycji[0].Points_p;
            }
        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            String numerindeksu = Convert.ToString(Index_Number_Textbox.Text);
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
            {
                connection.Execute($"UPDATE Studenci SET FirstName = '{First_Name_textbox.Text}', LastName ='{surname_textbox.Text}'," +
                    $" Department = '{Department_textbox.Text}', Study_Level = '{Study_level_textbox.Text}'," +
                    $" Year = '{year_textbox.Text}', Average = '{average_textbox.Text}', Achievements = '{achievements_textbox.Text}'," +
                    $" Deficit = '{deficit_textbox.Text}', Semester = '{Semester_textbox.Text}', Bank_Account_Number = '{Bank_account_textBox.Text}', Distance = '{Distance_textbox.Text}', Income = '{income_textbox.Text}', sps = '{Points_textbox.Text}' " +
                    $" where Index_Number = {numerindeksu}");

            }
            

        }

        private void Add_Student_manually_Click(object sender, EventArgs e)
        {
            Student S_obj = new Student();

            S_obj.Department_p = Convert.ToInt32(Department_textbox.Text);
            S_obj.FirstName_P = Convert.ToString(First_Name_textbox.Text);
            S_obj.LastName_p = Convert.ToString(surname_textbox.Text);
            S_obj.Year_p = Convert.ToInt32(year_textbox.Text);
            S_obj.Index_Number_P = Convert.ToInt32(Index_Number_Textbox.Text);
            S_obj.Study_Level_p = Convert.ToInt32(Study_level_textbox.Text);
            S_obj.Deficit_P = Convert.ToInt32(deficit_textbox.Text);
            S_obj.Average_P = Convert.ToString(average_textbox.Text);
            S_obj.Semester_P = Convert.ToInt32(Semester_textbox.Text);
            S_obj.Achievements_P = Convert.ToString(achievements_textbox.Text);
            S_obj.Bank_Account_Number_p = Convert.ToString(Bank_account_textBox.Text);
            S_obj.Distance_P = Convert.ToInt32(Distance_textbox.Text);
            S_obj.Points_p = Convert.ToString(Points_textbox.Text);
            S_obj.Income_P = Convert.ToInt32(income_textbox.Text);

            if (S_obj.Deficit_P > 0)
            {
                MessageBox.Show("Nie możesz mieć stypendium, masz deficyt!");
            }
            else
            {
                DataAccess db = new DataAccess();
                db.SendStudent(S_obj.FirstName_P, S_obj.LastName_p, S_obj.Department_p, S_obj.Index_Number_P, S_obj.Study_Level_p, S_obj.Year_p, S_obj.Income_P, S_obj.Distance_P, S_obj.Semester_P, S_obj.Bank_Account_Number_p, S_obj.Average_P, S_obj.Achievements_P, S_obj.Deficit_P, S_obj.Points_p);
            }
        }

       
    }
}
