using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasApp
{
    internal class Triangulo : FiguraGeometrica
    {
        public Triangulo()
        {
            b = 0;
            h = 0;
            area = 0;
        }
        public override double calcular()
        {
            area = (b * h) / 2;
            return area;
        }
    }
}
