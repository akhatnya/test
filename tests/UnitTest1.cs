using System;
using Geometrics.Figures;
using Xunit;

namespace Geometrics.Tests.Unit
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Проверка на ошибки круга")]
        public void CheckCircleExceptions()
        {
            Exception radiusError = Assert.Throws<ArgumentNullException>(() => new Circle(null));
            Exception positiveError = Assert.Throws<Exception>(() => new Circle(-5));
            Assert.Equal("Это не круг", positiveError.Message);
        }

        [Theory(DisplayName = "Проверка на существование такого треугольника")]
        [InlineData(5, 5, 25)]
        [InlineData(8, 8, 20)]
        [InlineData(9, 1, 5)]
        [InlineData(3, 1, 1)]
        [InlineData(-8, 1, 1)]
        public void CheckTriangleValues(double a, double b, double c)
        {
            Exception ex = Assert.Throws<Exception>(() => new Triangle(a, b, c));
            Assert.Equal("Это не треугольник же есть", ex.Message);
        }

        [Fact(DisplayName = "Проверка на прямой угол")]
        public void Check90()
        {
            Figure tri = new Triangle(3, 4, 5);
            Figure tri2 = new Triangle(5, 3, 4);
            Figure tri3 = new Triangle(6, 3, 4);

            Assert.True((tri as Triangle).Is90());
            Assert.True((tri2 as Triangle).Is90());
            Assert.False((tri3 as Triangle).Is90());
        }

        [Fact(DisplayName = "Проверка на корректность рассчета прощади и периметра")]
        public void CheckAreaAndPerimeter()
        {
            Figure tr = new Triangle(3,4,5);
            Assert.Equal(6, tr.CalcArea());
            Assert.Equal(12, tr.CalcPerimeter());

            Figure circ = new Circle(10);
            Assert.Equal(2 * Math.PI * 10, circ.CalcPerimeter());
            Assert.Equal(Math.PI * 10 * 10, circ.CalcArea());
        }
    }
}
