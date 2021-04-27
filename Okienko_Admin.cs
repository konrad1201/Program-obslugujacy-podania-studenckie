using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Programowanie_Obiektowe
{
    public partial class Okienko_Admin : Form
    {
        public Okienko_Admin()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Okienko_Rektor Okno = new Okienko_Rektor();
            Okno.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EdycjaDanych Okno_Edycji = new EdycjaDanych();
            Okno_Edycji.Show();
        }
    }
}
