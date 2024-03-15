using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.B = Int32.Parse(txtbase.Text);
            MessageBox.Show("el area de un cuadrado de las medidas: " + cuadrado.B + " y " + cuadrado.B + " es: " + cuadrado.calcular());
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            Triangulo triangulo= new Triangulo();
            triangulo.B = Int32.Parse(txtbase.Text);
            triangulo.H = Int32.Parse(txtaltura.Text);
            MessageBox.Show("el area de un triangulo de las medidas: " + triangulo.B + " y " + triangulo.H + " es: " + triangulo.calcular());
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            Rectangulo rectangulo= new Rectangulo();
            rectangulo.B = Int32.Parse(txtbase.Text);
            rectangulo.H = Int32.Parse(txtaltura.Text);
            MessageBox.Show("el area de un rectangulo de las medidas: " + rectangulo.B + " y " + rectangulo.H + " es: " + rectangulo.calcular());

        }
    }
}
