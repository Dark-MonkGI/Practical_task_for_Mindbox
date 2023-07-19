using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLib
{
    /// <summary>
    /// Интерфейс для реализации вычисления площади фигуры, чтоб бы добавить новую фигуру в библиотеку достаточно создать класс фигуры
    /// и унаследовать данный интерфейс
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Метод, реализующий вычисление площади геометрической фигуры
        /// </summary>
        /// <returns></returns>
        double GetArea();
    }
}
