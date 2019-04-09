using System;
using Geometrics.Formulas;

namespace Geometrics.Figures
{
    /// <summary>
    /// Круг (не Михаил)
    /// </summary>
    public class Circle : Figure
    {
        public double Radius { get; set; }

        /// <summary>
        /// Конструктор <see cref="T:geometrics.Classes.Circle"/>.
        /// </summary>
        /// <param name="Radius">радиус круга.</param>
        public Circle(double? Radius)
        {
            this.Radius = Radius ??  throw new ArgumentNullException(nameof(Radius));
            if (!Exists()) throw new Exception("Это не круг");
        }

        /// <summary>
        /// Подсчет периметра.
        /// </summary>
        /// <returns>значение периметра.</returns>
        override public double CalcPerimeter()
        {
            Perimeter = CircleFormulas.Perimeter(Radius);
            return Perimeter;
        }

        /// <summary>
        /// Подсчет площадм.
        /// </summary>
        /// <returns>площадь.</returns>
        override public double CalcArea()
        {
            Area = CircleFormulas.RadiusArea(Radius);
            return Area;
        }

        /// <summary>
        /// условия существв круга.
        /// </summary>
        /// <returns>да нет.</returns>
        override public bool Exists()
        {
            return Radius > 0;
        }
    }
}
