using System;

namespace Geometrics.Formulas
{
    public static class TriangleFormulas
    {
        public static double GeronArea(double a, double b, double c)
        {
            double p = Perimeter(a, b, c) / 2;
            return Math.Abs(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        public static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static bool Is90(double a, double b, double c)
        {
            double k1, k2, gip;

            if (a > b && a > c)
            {
                k1 = b;
                k2 = c;
                gip = a;
            }
            else if (b > a && b > c)
            {
                k1 = a;
                k2 = c;
                gip = b;
            }
            else if (c > a && c > b)
            {
                k1 = a;
                k2 = b;
                gip = c;
            }
            else
            {
                return false;
            }

            return k1 * k1 + k2 * k2 - gip * gip == 0;
        }
    }
}
