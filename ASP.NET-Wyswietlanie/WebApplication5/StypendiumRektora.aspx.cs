using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Dapper;
using System.Web.UI.HtmlControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var link = new HtmlLink();
            link.Href = "~/Content/bootstrap-superhero.css";
            link.Attributes.Add("rel", "stylesheet");
            link.Attributes.Add("type", "text/css");
            Page.Header.Controls.Add(link);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                int wydzial = Convert.ToInt32(TextBox1.Text);

                var lista = new List<Studenci_Rektor>();
                var zakwalfikowani = new List<Studenci_Rektor>();
                var niezakwalfikowani = new List<Studenci_Rektor>();
                using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
                {
                    lista = connection.Query<Studenci_Rektor>($"select Department, Index_Number, Year, Semester, Average, Achievements, sps" +
                        $" from Studenci  where( Department ='{wydzial}' and sps>3) order by sps desc ").ToList();

                }
                int i = lista.Count();
                zakwalfikowani = lista.GetRange(0, 6);
                niezakwalfikowani = lista.GetRange(6, i-6);
                GridView1.DataSource = zakwalfikowani;
                GridView1.DataBind();
                GridView3.DataSource = niezakwalfikowani;
                GridView3.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }
    }
}