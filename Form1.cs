using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
            try
            {
                DataAccess db = new DataAccess();

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
                S_obj.Achievements_P = Convert.ToString(achievements_textbox.Text);
                S_obj.Bank_Account_Number_p = Convert.ToString(Bank_account_textBox.Text);
                S_obj.Points_p = Convert.ToString((0.6 * Convert.ToDouble(S_obj.Average_P.Replace(".", ","))) + (0.4 * Convert.ToDouble(S_obj.Achievements_P)));
                double Average_check = Convert.ToDouble(S_obj.Average_P.Replace(".",","));
                int Index_Length = S_obj.Index_Number_P.ToString().Length;
            if (S_obj.Deficit_P > 0 || Average_check < 4)
            {
                MessageBox.Show("Nie możesz mieć stypendium, nie spelniasz warunkow!");
            }
            else if ((S_obj.Study_Level_p == 1 && S_obj.Semester_P > 7) || (S_obj.Study_Level_p == 2 && S_obj.Semester_P > 3))

            {
                MessageBox.Show("Wpisałeś zły semestr!");
            }

           

            else if (S_obj.Year_p > 4 || S_obj.Study_Level_p > 2)
            {
                MessageBox.Show("Błędny rok lub stopień studiów");
            }

            else if (Index_Length != 6)
            {
                MessageBox.Show("Błędny numer indeksu");
            }
                else if (S_obj.Year_p == 1 && S_obj.Semester_P > 2)
                {
                    MessageBox.Show("Błędny rok i semestr");
                }
                else if (S_obj.Year_p == 2 && (S_obj.Semester_P > 4 || S_obj.Semester_P < 3))
                {
                    MessageBox.Show("Błędny rok i semestr");
                }



                else if (S_obj.Year_p == 3 && (S_obj.Semester_P > 6 || S_obj.Semester_P < 5))
                {
                    MessageBox.Show("Błędny rok i semestr");
                }
                else if (S_obj.Year_p == 4 && S_obj.Semester_P != 7)
                {
                    MessageBox.Show("Błędny rok i semestr");
                }



                else if (db.CheckIndex(S_obj.Index_Number_P))
                {
                    MessageBox.Show("Osoba z takim numerem indeksu jest juz w bazie!");
                }
                else if(db.CheckIndex(S_obj.Index_Number_P))
              {
               MessageBox.Show("Osoba z takim numerem indeksu jest juz w bazie!");
            }
            else
            {

                db.SendStudent(S_obj.FirstName_P, S_obj.LastName_p, S_obj.Department_p, S_obj.Index_Number_P, S_obj.Study_Level_p, S_obj.Year_p, S_obj.Average_P, S_obj.Achievements_P, S_obj.Deficit_P, S_obj.Semester_P, S_obj.Bank_Account_Number_p, S_obj.Points_p);
                MessageBox.Show("Operacja zakończona sukcesem!");
            }

            }
            catch (System.FormatException)
            {
               MessageBox.Show("Sprawdź poprawność wprowadzonych danych!");
            }
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

        private void Akademiki_Button_Send_Click(object sender, EventArgs e)

        {
            try
            {
                DataAccess db = new DataAccess();

                Student S_obj = new Student();
                S_obj.Department_p = Convert.ToInt32(A_Department_textbox.Text);
                S_obj.FirstName_P = Convert.ToString(A_Name_textbox.Text);
                S_obj.LastName_p = Convert.ToString(A_surname_textbox.Text);
                S_obj.Year_p = Convert.ToInt32(A_year_textbox.Text);
                S_obj.Index_Number_P = Convert.ToInt32(A_Index_Number_textbox.Text);
                S_obj.Study_Level_p = Convert.ToInt32(A_Study_level_textbox.Text);
                S_obj.Semester_P = Convert.ToInt32(A_Semester_textbox.Text);
                S_obj.Bank_Account_Number_p = Convert.ToString(A_Bank_account_textBox.Text);
                S_obj.Distance_P = Convert.ToInt32(A_Distance_textbox.Text);
                S_obj.Income_P = Convert.ToInt32(A_Income_textbox.Text);

                int Index_Length = S_obj.Index_Number_P.ToString().Length;
                
                
                 if ((S_obj.Study_Level_p == 1 && S_obj.Semester_P > 7) || (S_obj.Study_Level_p == 2 && S_obj.Semester_P > 3))

                {
                    MessageBox.Show("Wpisałeś zły semestr!");
                }



                else if (S_obj.Year_p > 4 || S_obj.Study_Level_p > 2)
                {
                    MessageBox.Show("Błędny rok lub stopień studiów");
                }

                else if (Index_Length != 6)
                {
                    MessageBox.Show("Błędny numer indeksu");
                }
                else if (S_obj.Year_p == 1 && S_obj.Semester_P > 2)
                {
                    MessageBox.Show("Błędny rok i semestr");
                }
                else if (S_obj.Year_p == 2 && (S_obj.Semester_P > 4 || S_obj.Semester_P < 3))
                {
                    MessageBox.Show("Błędny rok i semestr");
                }



                else if (S_obj.Year_p == 3 && (S_obj.Semester_P > 6 || S_obj.Semester_P < 5))
                {
                    MessageBox.Show("Błędny rok i semestr");
                }
                else if (S_obj.Year_p == 4 && S_obj.Semester_P != 7)
                {
                    MessageBox.Show("Błędny rok i semestr");
                }



                else if (db.CheckIndex(S_obj.Index_Number_P))
                {
                    MessageBox.Show("Osoba z takim numerem indeksu jest juz w bazie!");
                }
                else if (db.CheckIndex(S_obj.Index_Number_P))
                {
                    MessageBox.Show("Osoba z takim numerem indeksu jest juz w bazie!");
                }
                else
                {


                    db.SendStudent(S_obj.FirstName_P, S_obj.LastName_p, S_obj.Department_p, S_obj.Index_Number_P, S_obj.Study_Level_p,
                        S_obj.Year_p, S_obj.Income_P, S_obj.Distance_P, S_obj.Semester_P, S_obj.Bank_Account_Number_p);
                    MessageBox.Show("Operacja zakończona sukcesem!");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Sprawdź poprawność wprowadzonych danych!");
            }
        }
        private void Socjalne_Button_Send_Click(object sender, EventArgs e)

        {
            try
            {
                Student S_obj = new Student();
                S_obj.Department_p = Convert.ToInt32(S_Department_textbox.Text);
                S_obj.FirstName_P = Convert.ToString(S_Name_textbox.Text);
                S_obj.LastName_p = Convert.ToString(S_surname_textbox.Text);
                S_obj.Year_p = Convert.ToInt32(S_year_textbox.Text);
                S_obj.Index_Number_P = Convert.ToInt32(S_Index_Number_textbox.Text);
                S_obj.Study_Level_p = Convert.ToInt32(S_Study_level_textbox.Text);
                S_obj.Semester_P = Convert.ToInt32(S_Semester_textbox.Text);
                S_obj.Bank_Account_Number_p = Convert.ToString(S_Bank_account_textBox.Text);
                S_obj.Income_P = Convert.ToInt32(S_Income_textbox.Text);

                DataAccess db = new DataAccess();
                int Index_Length = S_obj.Index_Number_P.ToString().Length;

                if ((S_obj.Study_Level_p == 1 && S_obj.Semester_P > 7) || (S_obj.Study_Level_p == 2 && S_obj.Semester_P > 3))

                {
                    MessageBox.Show("Wpisałeś zły semestr!");
                }
                else if (S_obj.Year_p > 4 || S_obj.Study_Level_p > 2)
                {
                    MessageBox.Show("Błędny rok lub stopień studiów");
                }

                else if (Index_Length != 6)
                {
                    MessageBox.Show("Błędny numer indeksu");
                }
                else if (S_obj.Year_p == 1 && S_obj.Semester_P > 2)
                {
                    MessageBox.Show("Błędny rok i semestr");
                }
                else if (S_obj.Year_p == 2 && (S_obj.Semester_P > 4 || S_obj.Semester_P < 3))
                {
                    MessageBox.Show("Błędny rok i semestr");
                }



                else if (S_obj.Year_p == 3 && (S_obj.Semester_P > 6 || S_obj.Semester_P < 5))
                {
                    MessageBox.Show("Błędny rok i semestr");
                }
                else if (S_obj.Year_p == 4 && S_obj.Semester_P != 7)
                {
                    MessageBox.Show("Błędny rok i semestr");
                }



                else if (db.CheckIndex(S_obj.Index_Number_P))
                {
                    MessageBox.Show("Osoba z takim numerem indeksu jest juz w bazie!");
                }
                else if (db.CheckIndex(S_obj.Index_Number_P))
                {
                    MessageBox.Show("Osoba z takim numerem indeksu jest juz w bazie!");
                }
                else
                {
                   
                    db.SendStudent(S_obj.FirstName_P, S_obj.LastName_p, S_obj.Department_p, S_obj.Index_Number_P, S_obj.Study_Level_p, S_obj.Year_p, S_obj.Income_P, S_obj.Semester_P, S_obj.Bank_Account_Number_p);
                    MessageBox.Show("Operacja zakończona sukcesem!");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Sprawdź poprawność wprowadzonych danych!");
            }


           
        }
    }
    
}
