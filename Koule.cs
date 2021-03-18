using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Koule : Objekt3D
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Koule(double r)
        {
            if ((r < 0)) throw new Exception("Kouli nelze sestrojit.");
            Radius = r;
        }

        public override void Kresli()
        {
            Console.WriteLine("Koule (r = {0})", Radius);
        }

        public override double SpoctiPovrch()
        {
            return (4 * Math.PI * Radius * Radius);
        }

        public override double SpoctiObjem()
        {
            return ((4 / 3) * Math.PI * Radius * Radius * Radius);
        }
    }
}
