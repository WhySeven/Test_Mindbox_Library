using System;

namespace Test_Library
{
    public class Figure
    {
        double a, b, c;
        public Figure(double a)
        {
            this.a = a;
            Console.WriteLine("Ваша фигура - круг");
        }
        public Figure(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine("Ваша фигура - треугольник");
        }
        public class Circle : Figure
        {
            public Circle(double a) : base(a) {}
            public double GetArea()
            {
                return Math.Pow(a, 2) * Math.PI;
            }
        }
        public class Triangle : Figure
        {

            public Triangle(double a, double b, double c) : base(a, b, c) { }
            public double GetArea()
            {
                double p = (a + b + c)/2;
                return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            }
            public bool Is_right()
            {
                if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) || (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)) || (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))){
                    return true;
                }

                else return false;
            }
        }
    }
}

