using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Bai1
    {
        public int TinhTuoi(int namSinh)
        {
            int tuoi = -1;
            
            if(namSinh<=DateTime.Now.Year)
            {
                return   DateTime.Now.Year- namSinh;
            }
            return tuoi;
        }
        public int Tuoi2010(int namSinh)
        {
            int tuoi = -1;
            if (namSinh <= 2010)
            {
                return  2010 - namSinh;
            }
            return tuoi;
        }
        public void Run()
        {
            int namSinh = 0;
            String ten = "";
            Console.Write("Ten: ");
            ten = Console.ReadLine();
            Console.Write("Nam sinh: ");
            namSinh = Int16.Parse(Console.ReadLine());
            int tuoi1 = Tuoi2010(namSinh);
            int tuoiHienTai = TinhTuoi(namSinh);

            String tuoi10 = tuoi1 < 0 ? "chua sinh" : tuoi1.ToString();
            String tuoiNow = tuoiHienTai < 0 ? "chua sinh" : tuoiHienTai.ToString();

            Console.Write(ten + ": Hien tai: " + tuoiNow + " , Nam 2010: " + tuoi10);
            Console.ReadKey();

        }
    }
}
