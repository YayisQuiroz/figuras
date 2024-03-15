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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo();
            circulo.Radio=Int32.Parse(txtRadio.Text);
            MessageBox.Show("el area de un circulo de radio: " + circulo.Radio + " es: " + circulo.calcular());

        }
    }
}
