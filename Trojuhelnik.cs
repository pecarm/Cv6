using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Trojuhelnik : Objekt2D
    {
        private double sideA;
        private double sideB;
        private double sideC;

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

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }

        public Trojuhelnik(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0) || (a + b < c) || (a + c < b) || (b + b < a)) throw new Exception("Trojuhelnik nelze sestrojit.");
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override void Kresli()
        {
            Console.WriteLine("Trojuhelnik (a = {0}, b = {1}, c = {2}, S = {3})", SideA, SideB, SideC, SpoctiPlochu());
        }

        public override double SpoctiPlochu()
        {
            double p = (SideA + SideB + SideC) / 2;
            return (Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)));
        }
    }
}
