using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Program
    {
        static void Main(string[] args)
        {
            GrObjekt[] grs = new GrObjekt[8];
            grs[0] = new Elipsa(2, 3);
            grs[1] = new Jehlan(4, 3, 12);
            grs[2] = new Koule(6);
            grs[3] = new Kruh(7);
            grs[4] = new Kvadr(1, 2, 9);
            grs[5] = new Obdelnik(8, 5);
            grs[6] = new Trojuhelnik(7, 6, 5);
            grs[7] = new Valec(10, 1);

            double sumArea = 0;
            double sumSurface = 0;
            double sumVolume = 0;

            foreach (var member in grs)
            {
                member.Kresli();

                if (member is Objekt2D p)
                {
                    sumArea += p.SpoctiPlochu();
                }
                else if (member is Objekt3D t)
                {
                    sumSurface += t.SpoctiPovrch();
                    sumVolume += t.SpoctiObjem();
                }
            }

            Console.WriteLine("Celkova plocha: {0}", sumArea);
            Console.WriteLine("Celkovy povrch: {0}", sumSurface);
            Console.WriteLine("Celkovy objem: {0}", sumVolume);
        }
    }
}
