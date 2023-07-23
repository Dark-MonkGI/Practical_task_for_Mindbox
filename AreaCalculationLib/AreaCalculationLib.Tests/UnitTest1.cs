using System;
using AreaCalculationLib;

namespace AreaCalculationLib.Tests
{
    /// <summary>
    /// Arrange-Act-Assert (AAA) 
    /// Arrange (Подготовка): Подготавливается все, что нужно для выполнения теста
    /// Act(Действие): Выполняяются действия, которое необходимо протестировать
    /// Assert(Проверка): Проверяется, что результат действия соответствует ожиданиям
    /// </summary>
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CircleAreaTest()
        {
            // Arrange
            Circle circle = new Circle(5);

            // Act
            double area = circle.GetArea();

            // Assert
            Assert.That(area, Is.EqualTo(Math.PI * 25));
        }

        [Test]
        public void TriangleAreaTest()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            double area = triangle.GetArea();

            // Assert
            Assert.That(area, Is.EqualTo(6));
        }

        [Test]
        public void IsRightAngledTriangleTest_True()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.That(isRightAngled, Is.True);
        }

        [Test]
        public void IsRightAngledTriangleTest_False()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 3, 3);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.That(isRightAngled, Is.False);
        }

        [Test]
        public void CalculateAreaTest()
        {
            // Arrange
            IShape circle = new Circle(5);
            IShape triangle = new Triangle(3, 4, 5);

            // Act
            double circleArea = CalculatedArea.CalculateArea(circle);
            double triangleArea = CalculatedArea.CalculateArea(triangle);

            // Assert
            Assert.That(circleArea, Is.EqualTo(Math.PI * 25));
            Assert.That(triangleArea, Is.EqualTo(6));
        }
    }
}