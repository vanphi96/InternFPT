using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set;}
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
            if(Check())
            {
                PrintResult();
            }
            
        }
        public override bool Check()
        {
            if (Width <= 0 || Length <= 0)
            {
                Console.Write("Kich thuoc hop le");
                return false;
            }
            return true;
        }
        public override double GetArea()
        {
            return Width * Length;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Length);
        }

        public override void PrintResult()
        {
            Console.Write("\n\n==========Rectangle===========");
            Console.Write("\nWidth: {0}", Math.Round( Width,1));
            Console.Write("\nLength: {0}", Math.Round(Length,1));
            Console.Write("\nPerimeter: {0}", Math.Round(GetPerimeter(),1));
            Console.Write("\nArea: {0}", Math.Round(GetArea(),1));
        }
    }
}
