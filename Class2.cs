using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Projekt_Programowanie_Obiektowe
{
    public class DataAccess
    {
     public List<Student> GetPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("StudenciDB")))
            {
                var output = connection.Query<Student>($"select * from DaneRektor  ").ToList();
                return output;
            }
        }

        public void SendStudent(string FN, string LN, int DP, int IN, int SL, int Y, string Avg, int Ach, int Def, int sem, string Bank)
        {                       
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("StudenciDB")))
            {
                connection.Execute($"INSERT INTO dbo.DaneRektor (FirstName,LastName,Department,Index_Number,Study_Level,Year,Average,Achievements,Deficit,Semester,Bank_Account_Number) VALUES ('{FN}', '{LN}', '{DP}','{IN}','{SL}','{Y}','{Avg}','{Ach}','{Def}','{sem}','{Bank}')");

            }
        }
    }
}
