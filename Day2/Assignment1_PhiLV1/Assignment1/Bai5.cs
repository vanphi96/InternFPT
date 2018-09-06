using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai5
    {
        public void Run()
        {
            
            Console.Write("Ten:  ");
            string ten = Console.ReadLine();
            Console.Write("So dien cu:  ");
            int dienCu = Int16.Parse(Console.ReadLine());
            Console.Write("So dien moi: ");
            int dienMoi = Int16.Parse(Console.ReadLine());
            Bai4 b4 = new Bai4();
            double tienDien = b4.TienDien(dienMoi, dienCu) + b4.TienDien(dienMoi, dienCu) * 0.1 + 12426;

            Console.Write("\n");
            Console.Write("****Hoa don tien dien*****");
            Console.Write("\nKhach hang: " + ten);
            Console.Write("\nChi so cu: " + dienCu);
            Console.Write("\nChi so moi: " + dienMoi);
            Console.Write("\nTieu thu: " + (dienMoi - dienCu));
            Console.Write("\nTieu thue dien ke: 12426d");
            Console.Write("\nTien dien: " + b4.TienDien(dienMoi, dienCu));
            Console.Write("\nPhu thu 10%: "+ b4.TienDien(dienMoi, dienCu) * 0.1);
            Console.Write("\nTien tong tien phai tra: " + b4.TienDien(dienMoi, dienCu) + "d");
            Console.Write("\nYeu cau tiet kiem dien");
            Console.ReadKey();
        }
    }
}
