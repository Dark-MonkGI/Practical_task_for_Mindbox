using AreaCalculationLib;

namespace GeometryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Проверяем работоспособность библиотеки:
                        
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(3, 4, 5);


            Console.WriteLine(CalculatedArea.CalculateArea(circle));
            Console.WriteLine(CalculatedArea.CalculateArea(triangle));
            Console.WriteLine(CalculatedArea.IsRightAngledTriangle(triangle));
        }
    }
}