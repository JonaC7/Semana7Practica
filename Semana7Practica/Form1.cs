using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana7Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola, este es mi primer formulario");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            MessageBox.Show(mensaje);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            if (num1 == 0 && num2 == 0)
            {
                MessageBox.Show("Ingreae datos");
            }
            var suma = num1 + num2;
            MessageBox.Show(suma.ToString());
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            
            string itemSelected = comboOpciones.Text;
            switch(itemSelected)
            {
                case "Suma":
                    break
                case "Resta":
                    break
            }
            MessageBox.Show(itemSelected);
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
