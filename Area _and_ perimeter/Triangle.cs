using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area__and__perimeter
{
    internal class Triangle : Figure
    {
        double Basee;
        double Height;

        public Triangle(double basee, double height)
        {
            this.Basee = basee;
            this.Height = height;
        }

        public override double Perimeter()
        {
            return Basee * 3;
        }

        public override double Area()
        {
            return (Basee * Height) / 2;
        }

        
        public string PrintPT()
        {
            return "" + Perimeter();
        }

        public string PrintAT()
        {
            return "" + Area();
        }
    }
}
