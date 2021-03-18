using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Kvadr : Objekt3D
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

        public Kvadr(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0)) throw new Exception("Kvadr nelze sestrojit.");
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override void Kresli()
        {
            Console.WriteLine("Kvadr (a = {0}, b = {1}, c = {2})", SideA, SideB, SideC);
        }

        public override double SpoctiPovrch()
        {
            return (2 * (SideA * SideB + SideB * SideC + SideA * SideC));
        }

        public override double SpoctiObjem()
        {
            return (SideA * SideB * SideC);
        }
    }
}
