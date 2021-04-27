using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Projekt_Programowanie_Obiektowe
{
    public partial class EdycjaDanych : Form
    {
        public EdycjaDanych()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numerindeksu = Convert.ToString(textBox1.Text);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("StudenciDB")))
            {
                connection.Execute($"DELETE FROM dbo.DaneRektor where Index_Number = {numerindeksu}");

            }
        }
    }
}
