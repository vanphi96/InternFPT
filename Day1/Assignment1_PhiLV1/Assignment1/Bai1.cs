using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai1
    {
        public static void Convert()
        {
            int x ;
            List<int> a= new List<int>();
            Console.Write("Nhap so nguyen bat ki: ");
            x = Int16.Parse(Console.ReadLine());
            int coso = 2;
            int dem = 0;
            while (x > 0)
            {
                a.Add(x % 2);
                x = x / 2;
                dem++;
            }
            for(int i=a.Count-1; i>=0; i--)
            {
                Console.Write(a[i]+"  ");
            }
            Console.ReadKey();

        }
    }
}
