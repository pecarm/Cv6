using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    // This class expects a pyramid with a base made of a regular polygon. Therefore there is a parameter stating how many sides does the pyramid instance have
    class Jehlan : Objekt3D
    {
        private int sides;
        private double sideLength;
        private double height;

        public int Sides
        {
            get { return sides; }
            set { sides = value; }
        }

        public double SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Jehlan(int s, double l, double h)
        {
            if ((s < 0) || (l < 0) || (h < 0)) throw new Exception("Jehlan nelze sestrojit.");
            Sides = s;
            SideLength = l;
            Height = h;
        }

        public override double SpoctiPovrch()
        {
            double temp = Math.PI / Sides;
            return ((1 / 4) * Sides * SideLength * SideLength * (Math.Cos(temp) / Math.Sin(temp)) * (1 + Math.Sqrt(1 + 4 * ((Height / SideLength) * Math.Tan (temp)) * ((Height / SideLength) * Math.Tan(temp)))));
        }

        public override double SpoctiObjem()
        {
            return ((1 / 12) * Sides * SideLength * SideLength * Height * (Math.Cos(Math.PI / Sides) / Math.Sin(Math.PI / Sides)));
        }

        public override void Kresli()
        {
            Console.WriteLine("Pravidelny jehlan (stran: {0}, a = {1}, h = {2})", Sides, SideLength, Height);
        }
    }
}
