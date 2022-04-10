using System;
using Strategy_oodp_3.AreaСalculation;

namespace Strategy_oodp_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var squarecalculator = new Сalculation();

            Console.WriteLine("Периметр правильного трикутника зi стороню 5 = " + squarecalculator.GetValue(new TriangleCalculator(), 5));
            Console.WriteLine("Периметр правильного квадрата зi стороню 5 = " + squarecalculator.GetValue(new SquareCalculator(), 5));
            Console.WriteLine("Периметр правильного шестикутника зi стороню 5 = " + squarecalculator.GetValue(new HexagonCalculator(), 5));
            Console.WriteLine("Периметр кола з дiаметром 5 = " + squarecalculator.GetValue(new CircleCalculator(), 5));
        }
    }
}
