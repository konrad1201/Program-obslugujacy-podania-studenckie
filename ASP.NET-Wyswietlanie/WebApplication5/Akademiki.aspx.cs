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
    public partial class WebForm3 : System.Web.UI.Page
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

                var lista = new List<Akademiki_Studenci>();
                var zakwalfikowani = new List<Akademiki_Studenci>();
               
                using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("StudencidB")))
                {
                    lista = connection.Query<Akademiki_Studenci>($"select Department, Index_Number, Year, Semester, Distance" +
                        $" from Studenci  where( Department ='{wydzial}' and Distance>40 )   order by Distance desc ").ToList();

                }
                int i = lista.Count();
                zakwalfikowani = lista.GetRange(0, i);
                
                GridView2.DataSource = zakwalfikowani;
                GridView2.DataBind();
                
            }
        }
    }
}