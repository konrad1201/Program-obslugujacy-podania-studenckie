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
    public partial class Okienko_Rektor : Form
    {
        public Okienko_Rektor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= 1 && numericUpDown1.Value < 14)
            {
                int department_choice = Convert.ToInt32(numericUpDown1.Value);
                List<Student> studenci = new List<Student>();
                DataAccess db = new DataAccess();
                studenci = db.GetPeople(department_choice);
                listBox1.DataSource = studenci;
                listBox1.DisplayMember = "FullInfo";
            }
            else MessageBox.Show("Przekroczono możliwą liczbę wydziału");
        }
    }
}
