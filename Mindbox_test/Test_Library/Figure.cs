using System;

namespace Test_Library
{
    public class Figure
    {
        //При создании нового типа фигур нужно добавить наименование его класса в этот массив
        public static String[] figure_list = { "Circle", "Triangle" };
        string figure_type;
        public void GetArea() {
            Console.WriteLine("Введите один из вариантов:\n");
            for (int i = 0; i < Figure.figure_list.Length; i++)
            {
                Console.WriteLine(Figure.figure_list[i]+"\n");
            }
            figure_type = FigureChoose();
            //Также требуется кейс новой фигуры сюда для вычисления площади фигуры без знания типа фигуры в compile-time 
            switch (figure_type)
            {
                case "Circle":
                    Console.WriteLine("Введите радиус: ");
                    Circle c = new Circle();
                    Console.WriteLine("Площадь круга = " + c.GetArea());
                    break;
                case "Triangle":
                    Console.WriteLine("Введите стороны треугольника: ");
                    Triangle t = new Triangle();
                    Console.WriteLine("Площадь треугольника = " + t.GetArea());
                    break;
            }
        }
        //Класс кргуа
        public class Circle
        {
            double r;
            public Circle()
            {
                Console.Write("R = ");
                r = Convert.ToDouble(Console.ReadLine());
            }
            public Circle(double r) {
                this.r = r;
            }
            public double GetArea()
            {
                return Math.Pow(r, 2) * Math.PI;
            }
        }
        //Класс треугольника
        public class Triangle
        {
            double a, b, c;
            public Triangle()
            {
                Console.Write("A = ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("B = ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("C = ");
                c = Convert.ToDouble(Console.ReadLine());
            }
            public Triangle(double a, double b, double c) {
                this.a = a;
                this.b = b;
                this.c = c;
            }
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

        // Метод для выбора пользователем фигуры
        private static string FigureChoose()
        {
            string figure_type = null;
            string entered_msg = Console.ReadLine();
            for (int i = 0; i < Figure.figure_list.Length; i++)
            {
                if (entered_msg == Figure.figure_list[i]) { figure_type = entered_msg; i = Figure.figure_list.Length; }
            }
            if (figure_type == null) { Console.WriteLine("Попробуйте ещё раз"); FigureChoose(); return null; }
            else { Console.WriteLine("Вы выбрали:" + figure_type); return figure_type; }
        }
    }
}

