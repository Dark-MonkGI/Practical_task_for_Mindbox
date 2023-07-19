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
    public class Circle : IShape
    {
        /// <summary>
        /// Свойство, хранящее в себе радиус круга
        /// </summary>
        public double Radius { get; private set; }

        /// <summary>
        /// Конструктор, который устанавливает радиус круга при объявлении объекта класса.
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException">Если радиус меньше или равен нулю, выбрасывается исключение</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The radius must be a positive integer", nameof(radius));


            Radius = radius;
        }

        /// <summary>
        /// Реализованный согласно унаследованному интерфейсу метод для вычисления площади круга
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
