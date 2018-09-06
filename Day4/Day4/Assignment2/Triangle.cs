using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            if (Check())
            {
                PrintResult();
            }
        }
        public override bool Check()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0||(SideA+SideB)<=SideC|| (SideA + SideC) <= SideB|| (SideC + SideB) <= SideA)
            {
                Console.Write("\nChieu dai 3 canh khong phai la 1 tam giac");
                return false;
            }
            return true;
        }
        public override double GetArea()
        {
            double p = (GetPerimeter() / 2);
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override void PrintResult()
        {
            Console.Write("\n\n==========Triangle===========");
            Console.Write("\nSideA: {0}", Math.Round(SideA, 1));
            Console.Write("\nSideA: {0}", Math.Round(SideB, 1));
            Console.Write("\nSideA: {0}", Math.Round(SideC, 1));
            Console.Write("\nPerimeter: {0}", Math.Round(GetPerimeter(), 1));
            Console.Write("\nArea: {0}", Math.Round(GetArea(), 1));
        }
    }
}
