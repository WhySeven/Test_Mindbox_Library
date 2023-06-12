using System;
using System.Reflection;
using Test_Library;

namespace Mindbox_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Юнит-тесты

            //Проверка круга
            Figure.Circle c = new Figure.Circle(2);
            Console.WriteLine("Площадь круга = " + c.GetArea() +"\n");

            //Проверка треугольника
            Figure.Triangle t = new Figure.Triangle(1, 1, 1);
            Console.WriteLine("Площадь треугольника (A = 1, B = 1, C = 1) = " + t.GetArea());
            Console.WriteLine("Треугольник прямоугольный:" + t.Is_right() + "\n");

            Figure.Triangle rt = new Figure.Triangle(3, 4, 5);
            Console.WriteLine("Площадь треугольника (A = 3, B = 4, C = 5) = " + rt.GetArea());
            Console.WriteLine("Треугольник прямоугольный:" + rt.Is_right() + "\n");

            //Вычисление площади фигуры без знания типа фигуры в compile-time
            Figure unknown_figure = new Figure();
            unknown_figure.GetArea();
        }

    }
}
