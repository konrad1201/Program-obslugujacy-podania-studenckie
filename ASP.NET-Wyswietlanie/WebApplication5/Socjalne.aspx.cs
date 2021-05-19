using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dapper;
using System.Web.UI.HtmlControls;
using MySql.Data.MySqlClient;
namespace WebApplication5
{
    public partial class Socjalne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView4.DataSource = null;
            if (TextBox1.Text != "")
            {
                int numer_indeksu = Convert.ToInt32(TextBox1.Text);

                var lista = new List<Socjalne_Studenci>();


                using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
                {
                    lista = connection.Query<Socjalne_Studenci>($"select Department, Index_Number, Year, Semester, Income " +
                        $" from Studenci  where( Index_Number ='{numer_indeksu}' and Income!=0 )   ").ToList();

                }

                if( lista[0].Income < 300)
                {
                  GridView4.DataSource = lista;
                  GridView4.DataBind();
                    GridView5.DataSource = null;
                    GridView5.DataBind();
                }
                else
                {
                    GridView5.DataSource = lista;
                    GridView5.DataBind();
                    GridView4.DataSource = null;
                    GridView4.DataBind();

                }
                     
                
              
            }
        }
    }
}