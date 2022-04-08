using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obliczenia
{
    public static class Funkcje
    {
        public static (double, double) ZnajdzMinimumFunkcji2D(int minX, int maxX, int minY, int maxY, int liczbaIteracji, Func<double, double, double> d)
        {
            Random rnd = new Random();
            double? najx = null, najy = null;

            for (int i = 0; i <= liczbaIteracji; i++) {
                double x = rnd.NextDouble() * (maxX - minX) + minX;
                double y = rnd.NextDouble() * (maxY - minY) + minY;
                if (x < najx || najx == null) { najx = x; }
                if (y < najy || najy == null) { najy = y; }
            }

            
            return ((double)najx, (double)najy);
        }
    }
}
