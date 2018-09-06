using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai4
    {
        public static void MaxMin()
        {
            Console.Write("Nhap chieu dai mang ");
            int n = Int16.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.Write("Chieu dai mang khong thoa man");
                Console.ReadKey();
                return;
            }
            int[] a= new int[n];
            
            for(int i=0; i<n; i++)
            {
                a[i]= Int16.Parse(Console.ReadLine());
            }
            
            int max = a[0];
            int min = a[0];
            for(int i=0;i<a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.Write("Lon nhat: " + max);
            Console.Write("\nNho nhat: " + min);
            Console.ReadKey();
        }
    }
}
