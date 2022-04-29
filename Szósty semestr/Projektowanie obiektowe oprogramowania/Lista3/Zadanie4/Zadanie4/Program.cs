using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle() { Heigh = 12, Width = 13 };
            Shape square = new Square() { Length = 10 };

            AreaCalculator calculator = new AreaCalculator();

            Console.WriteLine(calculator.CalculateArea(rectangle));
            Console.WriteLine(calculator.CalculateArea(square));

        }
    }
}
