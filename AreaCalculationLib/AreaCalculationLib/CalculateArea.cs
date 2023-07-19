using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLib
{
    /// <summary>
    /// Класс для работы с геометрическими фигурами и вычисления площади
    /// </summary>
    public static class CalculatedArea
    {
        /// <summary>
        /// Универсальный метод для вычисления площади фигуры
        /// </summary>
        /// <param name="shape">Передаем фигуры в качесве параметра</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Если фигура не указана, выбрасывается исключение</exception>
        public static double CalculateArea(IShape shape)
        {
            //Проверка наличия фигуры
            if (shape == null)       
                throw new ArgumentNullException(nameof(shape));
            

            return shape.GetArea();
        }



        /// <summary>
        /// Метод для проверки, являеться ли треугольник прямоугольным 
        /// </summary>
        /// <param name="triangle">Передаем треугольник</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Если треугольник не указан, выбрасывается исключение</exception>
        public static bool IsRightAngledTriangle(Triangle triangle)
        {
            if (triangle == null)           
                throw new ArgumentNullException(nameof(triangle));
            
            return triangle.IsRightAngled();
        }
    }
}


