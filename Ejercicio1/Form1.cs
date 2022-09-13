using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
         
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string itemSelected = comboBox1.Text;
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            switch (itemSelected)
            {
                case "Suma":

                    if (num1 == 0 && num2 == 0)
                    {
                        MessageBox.Show("Ingrese datos");
                    }
                    var suma = num1 + num2;
                    MessageBox.Show(suma.ToString());
                    break; 

                case "Resta":

                    if (num1 == 0 && num2 == 0)
                    {
                        MessageBox.Show("Ingrese datos");
                    }
                    var resta = num1 - num2;
                    MessageBox.Show(resta.ToString());
                    break;

                case "Multiplicación":

                    if (num1 == 0 && num2 == 0)
                    {
                        MessageBox.Show("Ingrese datos");
                    }
                    var multi = num1 * num2;
                    MessageBox.Show(multi.ToString());
                    break;

                case "Divicion":

                    if (num1 == 0 && num2 == 0)
                    {
                        MessageBox.Show("Ingrese datos");
                    }
                    var divición = num1 / num2;
                    MessageBox.Show(divición.ToString());
                    break;

            }
            MessageBox.Show(itemSelected);
        }
    }
}
