using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Valec : Objekt3D
    {
        #region Attributes
        private double radius;
        private double height;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        #endregion

        #region Constructor
        public Valec(double r, double h)
        {
            if ((r < 0) || (h < 0)) throw new Exception("Valec nelze sestrojit.");
            Radius = r;
            Height = h;
        }
        #endregion

        public override double SpoctiObjem()
        {
            return (Math.PI * Radius * Radius * Height);
        }

        public override double SpoctiPovrch()
        {
            return (2 * Math.PI * Radius * (Radius + Height));
        }

        public override void Kresli()
        {
            Console.WriteLine("Valec (r = {0}, h = {1})", Radius, Height);
        }
    }
}
