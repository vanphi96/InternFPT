using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai2
    {
        public int Tinh(int x)
        {
            return 3 * x * x + 4 * x - 7;
        }
        public void Run()
        {
            Console.Write("X = : ");
            int x = Int16.Parse(Console.ReadLine());
            Console.Write("Ket qua bieu thuc 3x^2+4x-7 la: " + Tinh(x));
            Console.ReadKey();
        }
    }
}
