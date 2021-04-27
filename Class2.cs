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
                var output = connection.Query<Student>($"select * from Dane  ").ToList();
                return output;
            }
        }

    }
}
