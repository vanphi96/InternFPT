using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai3
    {
        public static void KiemTra()
        {
            Console.Write("Nhap so nguyen bat ki: ");
            int n = Int16.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.Write(n + " khong phai la so nguyen to!");
                Console.ReadKey();
                return;
            }
            for(int i=2; i<=n/2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(n+ " khong phai la so nguyen to!");
                    Console.ReadKey();
                    return;
                }
            }
            Console.Write(n + " la so nguyen to!");
            Console.ReadKey();
          
        }
    }
}
