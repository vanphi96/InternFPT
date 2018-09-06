using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai3
    {
        public double Tinh(int x, int y)
        {
            return 4 * (Math.Pow(x, 2 * y)) - 2 * x * y + 6 * x * Math.Pow( y, 2) - 13;
        }
        public void Run()
        {
            try
            {
                Console.Write("X = : ");
                int x = Int16.Parse(Console.ReadLine());
                Console.Write("Y = : ");
                int y = Int16.Parse(Console.ReadLine());
                Console.Write("Ket qua bieu thuc 4x^2y-2xy+6xy^2 -13 la: " + Tinh(x,y));
               
            }
            catch(Exception e)
            {
                Console.Write(e.ToString());
               
            }
            Console.ReadKey();

        }
    }
}
