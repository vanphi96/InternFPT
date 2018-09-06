using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class Bai7
    {
        public double ChuVi(double R)
        {
            return 2 * Math.PI * R;
        }
        public double DienTich(double R)
        {
            return Math.PI * R * R;
        }
        public void Run()
        {
          
            Console.Write("Nhap ban kinh hinh tron:  ");
            double R = Double.Parse(Console.ReadLine());
            Console.Write("Chu vi hinh tron la: " + Math.Round(ChuVi(R),3));
            Console.Write("\nDien tich hinh tron la: " + Math.Round(DienTich(R), 3));
            Console.ReadKey();
        }
    }
}
