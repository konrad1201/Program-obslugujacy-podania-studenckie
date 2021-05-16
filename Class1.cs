using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Projekt_Programowanie_Obiektowe
{
    public class Student
    {
        private string FirstName;
        private string LastName;
        private int Department;
        private int Year;
        private int Index_Number;
        private int Semester;
        private int Study_Level;
        private string Average;
        private double Family_Money;
        private int Family_Members;
        private string Bank_Account_Number;
        private double Distance;
        private string Achievements;
        private int Deficit;
        private string Points;

        private string myVar;

        public string FullInfo
        {
            get
            {
                return $"{FirstName} {LastName} {Department} {Index_Number} {Study_Level} {Year} {Semester} {Average} {Achievements} {Deficit}  ";
            }
        }


        public string Achievements_P
        {
            get
            {
                return Achievements ;
            }



            set
            {
                Achievements = value;
            }
        }

        public int Deficit_P
        {
            get
            {
                return Deficit;
            }



            set
            {
                Deficit = value;
            }
        }

        public double Distance_P
        {
            get
            {
                return Distance;
            }



            set
            {
                Distance = value;
            }
        }

        public string Average_P
        {
            get
            {
                return Average;
            }



            set
            {
                Average = value;
            }
        }

        public int Index_Number_P
        {
            get
            {
                return Index_Number;
            }



            set
            {
                Index_Number = value;
            }
        }

        public string FirstName_P
        {
            get
            {
                return FirstName;
            }



            set
            {
                FirstName = value;
            }
        }

        public string LastName_p
        {
            get
            {
                return LastName;
            }



            set
            {
                LastName = value;
            }
        }



        public string Bank_Account_Number_p
        {
            get
            {
                return Bank_Account_Number;
            }



            set
            {
                Bank_Account_Number = value;
            }
        }



        public int Department_p
        {
            get
            {
                return Department;
            }



            set
            {
                Department = value;
            }
        }



        public int Year_p
        {
            get
            {
                return Year;
            }



            set
            {
                Year = value;
            }
        }



        public int Semester_P
        {
            get
            {
                return Semester;
            }



            set
            {
                Semester = value;
            }
        }

        public string Points_p
        {
            get
            {
                return Points;
            }



            set
            {
                Points = value;
            }
        }

        public int Study_Level_p
        {
            get
            {
                return Study_Level;
            }



            set
            {
                Study_Level = value;
            }
        }
    }



}