using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLib
{
    /// <summary>
    /// Для каждой фигуры создаем класс, наследуемся от интерфейса IShape
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        /// Свойства, хранящие в себе стороны треугольника
        /// </summary>
        public double A { get; }
        public double B { get; }
        public double C { get; }


        /// <summary>
        /// Конструктор, который устанавливает стороны треугольника при объявлении объекта класса. 
        /// </summary>
        /// <param name="a">Сторона А</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        /// <exception cref="ArgumentException">Если одна из сторон меньше или равна нулю, выбрасывается исключение</exception>
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)        
                throw new ArgumentException("The sides of the triangle must be a positive number");
            
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Реализованный согласно унаследованному интерфейсу метод для вычисления площади треуголника
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            var s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        /// <summary>
        /// Метод, проверяющий является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRightAngled()
        {
            var sides = new[] { A, B, C };
            Array.Sort(sides);

            return Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2)) < 0.000001;
        }
    }
}
