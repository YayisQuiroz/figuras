using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasApp
{
    internal class Rectangulo : FiguraGeometrica
    {
        public Rectangulo()
        {
            b = 0;
            h = 0;
            area = 0;
        }
        public override double calcular()
        {
            area = b * h;
            return area;
        }
    }
}
