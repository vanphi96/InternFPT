using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai7
    {
        public int UCLN(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            if (b == 0 )
            {
                return a;
            }
            if (a > b)
            {
                a = a % b;
               return UCLN(b, a);
            }
            else
            {
                b = b % a;
                return UCLN(a, b);
            }
           
        }
        public int BCNN(int a, int b)
        {
            return a * b / UCLN(a, b);

        }
        public void Run()
        {
            Console.Write("a = : ");
            int a = Int16.Parse(Console.ReadLine());
            Console.Write("b = : ");
            int b = Int16.Parse(Console.ReadLine());
            Console.Write("UCLN: " + UCLN(a, b));
            Console.Write("\nBCNN: " + BCNN(a, b));
            Console.ReadKey();
        }
    }
}
