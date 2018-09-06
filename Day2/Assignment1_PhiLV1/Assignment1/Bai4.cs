using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai4
    {
        public double TienDien(int soMoi, int soTruoc)
        {
            return (soMoi - soTruoc) * 452.45;
        }
        public void Run()
        {
            Console.Write("Ten:  ");
            string ten = Console.ReadLine();
            Console.Write("So dien cu:  ");
            int dienCu = Int16.Parse(Console.ReadLine());
            Console.Write("So dien moi: ");
            int dienMoi = Int16.Parse(Console.ReadLine());
            Console.Write("Hoa don tien dien");
            Console.Write("\nKhach hang: "+ten);
            Console.Write("\nChi so cu: " +dienCu);
            Console.Write("\nChi so moi: " + dienMoi);
            Console.Write("\nTieu thu: " + (dienMoi-dienCu));
            Console.Write("\nTien dien: " + TienDien(dienMoi,dienCu)+"d");
            Console.Write("\nYeu cau tiet kiem dien");
            Console.ReadKey();
        }
    }
}
