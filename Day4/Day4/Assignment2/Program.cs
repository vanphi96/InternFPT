using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n =====Calculator Shape Progarmer=====");
                Console.Write("\n1. Circle");
                Console.Write("\n2. Rectangle");
                Console.Write("\n3. Triangle");
                Console.Write("\n4. Exit\n");
                int select = Int16.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        {
                            double radius = 0;
                            Console.Write("\nPlease input radius of Circle: \n");
                            radius = Double.Parse(Console.ReadLine());
                            Shape shape = new Circle(radius);
                        }
                        break;
                    case 2:
                        {
                            double width = 0;
                            double length = 0;
                            Console.Write("\nPlease input side width of Rectangle: \n");
                            width = Double.Parse(Console.ReadLine());
                            Console.Write("\n Please input side length  of Rectangle: \n");
                            length = Double.Parse(Console.ReadLine());
                            Shape shape = new Rectangle(width, length);
                        }
                        break;
                    case 3:
                        {
                            double sideA = 0;
                            double sideB = 0;
                            double sideC = 0;
                            Console.Write("\nPlease input side A of Triangle:  \n");
                            sideA = Double.Parse(Console.ReadLine());
                            Console.Write("\nPlease input side B of Triangle: \n");
                            sideB = Double.Parse(Console.ReadLine());
                            Console.Write("\nPlease input side C of Triangle: \n");
                            sideC = Double.Parse(Console.ReadLine());
                            Shape shape = new Triangle(sideA, sideB, sideC);
                        }
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
