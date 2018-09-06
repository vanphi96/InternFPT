using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Bai6
    {
        public double GiaiPT(double a, double b)
        {
            return Math.Round(-b / a, 3);
        }
        public void Run()
        {
            Console.Write("Giai phuong trinh ax+b=0");
            Console.Write("\na  =   ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b =   ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Nghiem cua phuong trinh la: "+GiaiPT(a,b));
            Console.ReadKey();
        }
    }
}
