using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Kruh : Objekt2D
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Kruh(double r)
        {
            if ((r < 0)) throw new Exception("Kruh nelze sestrojit.");
            Radius = r;
        }

        public override double SpoctiPlochu()
        {
            return (Math.PI * Radius * Radius);
        }

        public override void Kresli()
        {
            Console.WriteLine("Kruh (r = {0})", Radius);
        }
    }
}
