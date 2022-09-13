using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboInteres_SelectedIndexChanged(object sender, EventArgs e)
        {
           
      
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            string itemSelected = comboInteres.Text;
            double cap = double.Parse(txtCapital.Text);
            double inte = double.Parse(txtTasadeinteres.Text);
            double tiemp = double.Parse(txtTiempo.Text);
            switch (itemSelected)
            {
                case "Anual":
                    if (cap == 0 && inte == 0 && tiemp == 0)
                    {
                        MessageBox.Show("Ingrese datos");
                    }
                    var Anual = cap * inte * tiemp;
                    MessageBox.Show(Anual.ToString());
                    break;
                case "Mensual":
                    if (cap == 0 && inte == 0 && tiemp == 0)
                    {
                        MessageBox.Show("Ingrese datos");
                    }
                    var Mensual = cap * inte * (tiemp / 12);
                    MessageBox.Show(Mensual.ToString());
                    break;
                case "Diario":
                    if (cap == 0 && inte == 0 && tiemp == 0)
                    {
                        MessageBox.Show("Ingrese datos");
                    }
                    var Diario = cap * inte * (tiemp / 360);
                    MessageBox.Show(Diario.ToString());
                    break;
            }
                
        }
    }
}
