using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai10
    {
        public int Cach1(int n, int[] a)
        {
            Bai9 b9 = new Bai9();
            int[] b = { 0 };
            a =  b9.SelectionSort(n, a);
            return a[a.Length - 2];
            
        }
        public int Cach2(int n, int[] a)
        {
            int max1 = a[0];
            int max2= a[1];
            if (max2 > max1)
            {
                int tmp = max2;
                max2 = max1;
                max1 = tmp;
            }
            for(int i=0; i<n; i++)
            {
                if (a[i] > max1)
                {
                    max2 = max1;
                    max1 = a[i];
                    
                }
            }
            return max2;
        }
        public void Run()
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
            int so = Cach1(n, a);
            a = a.Distinct().ToArray();
            n = a.Length;
            if (a.Length == 1)
            {
                Console.Write("Khong co so lon thu 2");
                Console.ReadKey();
                return;
            }
            Console.Write("Cach 1: So lon thu 2: " + Cach1(n, a));
            

            Console.Write("\nCach 2: So lon thu 2: " + Cach2(n, a));
            Console.ReadKey();
        }
    }
}
