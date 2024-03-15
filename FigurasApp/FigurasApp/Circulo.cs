using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasApp
{
    internal class Circulo : FiguraGeometrica
    {
        protected double radio;
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public Circulo()
        {
            b = 0;
            h = 0;
            area = 0;
            radio = 0;
        }
        public override double calcular()
        {
            area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
    }
}
