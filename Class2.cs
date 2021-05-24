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

        public void SendStudent(string FN, string LN, int DP, int IN, int SL, int Y, string Avg, string Ach, int Def, int sem, string Bank, string sps)
        {                       
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
            {
                connection.Execute($"INSERT INTO Studenci (FirstName,LastName,Department,Index_Number,Study_Level,Year,Average,Achievements,Deficit,Semester,Bank_Account_Number,sps) VALUES ('{FN}', '{LN}', '{DP}','{IN}','{SL}','{Y}','{Avg}','{Ach}','{Def}','{sem}','{Bank}','{sps}')");

            }
        }

        public void SendStudent(string FN, string LN, int DP, int IN, int SL, int Y, int Inc, int Dis,  int sem, string Bank)
        {
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
            {
                connection.Execute($"INSERT INTO Studenci (FirstName,LastName,Department,Index_Number,Study_Level,Year,Income,Distance,Semester,Bank_Account_Number) VALUES ('{FN}', '{LN}', '{DP}','{IN}','{SL}','{Y}','{Inc}','{Dis}','{sem}','{Bank}')");

            }
        }


        public void SendStudent(string FN, string LN, int DP, int IN, int SL, int Y,  int Inc, int Dis, int sem, string Bank, string Avg, string Ach, int Def, string sps)
        {
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
            {
                connection.Execute($"INSERT INTO Studenci (FirstName,LastName,Department,Index_Number,Study_Level,Year,Income,Distance,Semester,Bank_Account_Number,Average,Achievements,Deficit,sps) VALUES ('{FN}', '{LN}', '{DP}','{IN}','{SL}','{Y}','{Inc}','{Dis}','{sem}','{Bank}','{Avg}','{Ach}','{Def}','{sps}')");

            }
        }


        public void SendStudent(string FN, string LN, int DP, int IN, int SL, int Y, int Inc, int sem, string Bank)
        {
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
            {
                connection.Execute($"INSERT INTO Studenci (FirstName,LastName,Department,Index_Number,Study_Level,Year,Income,Semester,Bank_Account_Number) VALUES ('{FN}', '{LN}', '{DP}','{IN}','{SL}','{Y}','{Inc}','{sem}','{Bank}')");

            }
        }


    }
}
