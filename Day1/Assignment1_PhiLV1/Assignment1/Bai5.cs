using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai5
    {
        public static void Sort()
        {
            Console.Write("Nhap chieu dai mang ");
            int n = Int16.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.Write("Chieu dai mang khong thoa man");
                Console.ReadKey();
                return;
            }
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Int16.Parse(Console.ReadLine());
            }
            int position = 0;
            for (int i = 0; i <n; i++)
            {
                int j = i + 1;
                position = i;
                int temp = a[i];
                for (; j < n; j++)
                {
                    if (a[j] < temp)
                    {
                        temp = a[j];
                        position = j;
                    }
                }
                a[position] = a[i];
                a[i] = temp;
            }
            Console.Write("Mang da sap xep: ");
            for (int i=0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
