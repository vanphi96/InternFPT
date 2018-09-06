using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai8
    {
        public string TongPhanSo(int a, int b, int c, int d)
        {
            string s = "";
            Bai7 b7 = new Bai7();
            int ucAB = b7.UCLN(a, b);
            int ucCD = b7.UCLN(c, d);
            a = a / ucAB;
            b = b / ucAB;
            c = c / ucCD;
            d = d / ucCD;

            int tuSo = a * (b7.BCNN(b,d)/b)+ c * (b7.BCNN(b, d) / d);
            int mauSo =b7.BCNN(b,d);

            int UC = (b7.UCLN(tuSo, mauSo));
            tuSo = tuSo /UC;
            mauSo = mauSo / UC;

            return tuSo+"/"+mauSo;
        }

        public void Run()
        {
            Console.Write("tu so 1 = : ");
            int a = Int16.Parse(Console.ReadLine());
            Console.Write("mau so 1 = : ");
            int b = Int16.Parse(Console.ReadLine());

            Console.Write("tu so 2 = : ");
            int c = Int16.Parse(Console.ReadLine());
            Console.Write("mau so 2 = : ");
            int d = Int16.Parse(Console.ReadLine());
            Console.Write("Tong hai phan so la: "+ TongPhanSo(a, b, c, d));
            Console.ReadKey();
        }
    }
}
