using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai2
    {

        public int Fibonaci(int i)
        {
            int a = 0;
            if (i==0) {
                return 0;
            }
            else if(i == 1){
                return 1;
            }
            else
            {
                return Fibonaci(i - 1)  + Fibonaci(i - 2) ;
            }
           
        }
        public string Cach1()
        {
            Console.Write("Nhap so nguyen bat ki: ");
           int n = Int16.Parse(Console.ReadLine());
            if (n <0)
            {
                Console.Write( " so truyen vao phai lon hon 0 ");
                return "";
            }
            int dem = 1;
            string a = "";
            while(dem<=n)
            {
               
               a+=Fibonaci(dem) + "  ";
                dem++;
                
            }
            return a;
           
        }
        public string Cach2()
        {
            Console.Write("Nhap so nguyen bat ki: ");
            int n = Int16.Parse(Console.ReadLine());
            int dem = 0;
            List<int> fibo = new List<int>();
            fibo.Add(0);
            fibo.Add(1);
            fibo.Add(1);
            string a = "";
            if (n < 0)
            {
                Console.Write(" Error ");
                return "";
            }
            if (n ==0)
            {
                Console.Write(0);
                return "0";
            }
           else if (n == 1)
            {
                return (0+" "+1);
            }
            else
            {
                for (int i = 3; i <=n; i++)
                {
                    fibo.Add(fibo[i - 1] + fibo[i - 2]);
                }
            }
            for (int i = 1; i <=n; i++)
            {
                a+= (fibo[i]+"  ");
            }
            return a;
        }
    }
}
