using System;
using Geometrics.Formulas;

namespace Geometrics.Figures
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        /// <summary>
        /// Конструктор <see cref="T:geometrics.Classes.Triangle"/>.
        /// </summary>
        /// <param name="SideA">сторона a.</param>
        /// <param name="SideB">сторона b.</param>
        /// <param name="SideC">сторона с.</param>
        public Triangle(double? SideA, double? SideB, double? SideC)
        {
            this.SideA = SideA ?? throw new ArgumentNullException(nameof(SideA));
            this.SideB = SideB ?? throw new ArgumentNullException(nameof(SideB));
            this.SideC = SideC ?? throw new ArgumentNullException(nameof(SideC));
            if (!Exists()) throw new Exception("Это не треугольник же есть");
        }

        /// <summary>
        /// Площадь по Герону.
        /// </summary>
        /// <returns>Площадь.</returns>
        override public double CalcArea()
        {
            Area = TriangleFormulas.GeronArea(SideA, SideB, SideC);
            return Area;
        }

        /// <summary>
        /// Подсчет периметра.
        /// </summary>
        /// <returns>Значение периметра.</returns>
        override public double CalcPerimeter()
        {
            Perimeter = TriangleFormulas.Perimeter(SideA, SideB, SideC);
            return Perimeter;
        }

        /// <summary>
        /// Проверка условий существования данной фигуры.
        /// </summary>
        /// <returns>сущест или не сущест.</returns>
        override public bool Exists()
        {
            bool isPositive = SideA > 0 && SideB > 0 && SideC > 0;
            return isPositive && SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        }

        /// <summary>
        /// Прямоугольный или нет.
        /// </summary>
        /// <returns>da ili net.</returns>
        public bool Is90()
        {
            return TriangleFormulas.Is90(SideA, SideB, SideC);
        }
    }
}
