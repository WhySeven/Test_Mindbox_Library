using System;
using Test_Library;

namespace Mindbox_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure.Circle c = new Figure.Circle(2);
            Console.WriteLine("S = " + c.GetArea());
            Figure.Triangle t = new Figure.Triangle(1, 1, 1);
            Console.WriteLine("S = " + t.GetArea());
            Console.WriteLine("Треугольник прямоугольный:" + t.Is_right());
            Figure.Triangle rt = new Figure.Triangle(3, 4, 5);
            Console.WriteLine("S = " + rt.GetArea());
            Console.WriteLine("Треугольник прямоугольный:" + rt.Is_right());

        }
    }
}
