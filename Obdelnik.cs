using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Obdelnik : Objekt2D
    {
        private double sideA;
        private double sideB;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        
        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public Obdelnik(double a, double b)
        {
            if ((a < 0) || (b < 0)) throw new Exception("Obdelnik nelze sestrojit.");
            SideA = a;
            SideB = b;
        }

        public override void Kresli()
        {
            Console.WriteLine("Obdelnik (a = {0}, b = {1})", SideA, SideB);
        }

        public override double SpoctiPlochu()
        {
            return SideA * SideB;
        }
    }
}
