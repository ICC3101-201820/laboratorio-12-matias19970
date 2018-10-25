using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace MVC
{
    public delegate void AgregarComidaDelegate(string nombre, int carbohidratos, int proteinas, int grasas);

    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hay suscritos?
            if (OnAgregarComida != null)
            {
                // Notificar a los suscritos
                OnAgregarComida.Invoke(nombreTextBox.Text, Int32.Parse(carbohidratosTextBox.Text), Int32.Parse(proteinasTextBox.Text), Int32.Parse(grasasTextBox.Text));
            }
        }

        public void AgregarComida(Comida comida)
        {
            comidasList.Items.Add(comida);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void proteinasTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void grasasTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
