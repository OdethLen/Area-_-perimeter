using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area__and__perimeter
{
    internal class Pentagon: Figure
    {
        //Properties
        double Side;
        double Apothem;

        //Constructor
        public Pentagon(double side, double apothem)
        {
            this.Side = side;
            this.Apothem = apothem;
        }

        public override double Perimeter()
        {
            return Side * 5;
        }

        public override double Area()
        {
            return (Apothem*Perimeter())/2;
        }


        //Methods for printing
        public string PrintA()
        {
            return "" + Area();
        }

        
        public string PrintP ()
        {
            return "" + Perimeter();
        }


    }
}
