using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Projekt_Programowanie_Obiektowe
{
    public class Student
    {
        private string Name;
        private string Surname;
        private int Department;
        private int Year;
        private int Semester;
        private int Level;
        private double Average;
        private double Family_Money;
        private int Family_Members;
        private string Bank_Account_Number;
        private double Distance;

        private string myVar;

        public string FullInfo
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }


        public string Name_p
        {
            get
            {
                return Name;
            }



            set
            {
                Name = value;
            }
        }

        public string Surname_p
        {
            get
            {
                return Surname;
            }



            set
            {
                Surname = value;
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



        public int Level_p
        {
            get
            {
                return Level;
            }



            set
            {
                Level = value;
            }
        }
    }



}