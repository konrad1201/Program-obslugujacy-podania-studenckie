using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projekt_Programowanie_Obiektowe
{
    public class DataAccess
    {
     public List<Student> GetPeople(int department_choice)
        {
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
            {
                var output = connection.Query<Student>($"select * from Studenci where Department = '{department_choice}' ").ToList();
                return output;
            }
        }

        public void SendStudent(string FN, string LN, int DP, int IN, int SL, int Y, string Avg, int Ach, int Def, int sem, string Bank)
        {                       
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
            {
                connection.Execute($"INSERT INTO Studenci (FirstName,LastName,Department,Index_Number,Study_Level,Year,Average,Achievements,Deficit,Semester,Bank_Account_Number) VALUES ('{FN}', '{LN}', '{DP}','{IN}','{SL}','{Y}','{Avg}','{Ach}','{Def}','{sem}','{Bank}')");

            }
        }
    }
}
