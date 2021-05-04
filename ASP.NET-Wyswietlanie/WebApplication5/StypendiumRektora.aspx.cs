using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Dapper;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                int wydzial = Convert.ToInt32(TextBox1.Text);

                var lista = new List<Studenci_Rektor>();
                using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
                {
                    lista = connection.Query<Studenci_Rektor>($"select Department, Index_Number, Year, Semester, Average from Studenci where Department ='{wydzial}' ").ToList();

                }

                GridView1.DataSource = lista;
                GridView1.DataBind();
            }
        }

        
    }
}