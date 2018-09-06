using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Circle:Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            if (Check())
            {
                PrintResult();
            }
        }
        public override double GetArea()
        {
            return  Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void PrintResult()
        {
            Console.Write("\n\n==========Cricle===========");
            Console.Write("\nRadius: {0}", Math.Round(Radius,1));
            Console.Write("\nPerimeter: {0}", Math.Round(GetPerimeter(),1));
            Console.Write("\nArea: {0}", Math.Round(GetArea(),1));
        }

        public override bool Check()
        {
            if (Radius <= 0)
            {
                Console.Write("Kich thuoc hop le");
                return false;
            }
            return true;
        }
    }
}
