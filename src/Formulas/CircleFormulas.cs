using System;

namespace Geometrics.Formulas
{
    public static class CircleFormulas
    {
        public static double RadiusArea(double r)
        {
            return Math.PI * r * r;
        }

        public static double Perimeter(double r)
        {
            return 2 * Math.PI * r;
        }
    }
}
