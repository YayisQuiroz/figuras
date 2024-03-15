using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasApp
{
    internal class FiguraGeometrica
    {
        #region propiedades
        protected double b;
        protected double h;
        protected double area;
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        public double Area
        {
            get { return area; }
        }
        #endregion
        #region constructor
        public FiguraGeometrica()
        {
            b = 0;
            h = 0;
            area = 0;
        }
        public FiguraGeometrica(double b, double h, double area)
        {
            this.b = b;
            this.h = h;
            this.area = area;

        }
        #endregion
        public virtual double calcular()
        {
            return area;
        }

    }
}
