using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class Bai9
    {
        public double TienLai(float laiSuat, double tienGui, int thangGui)
        {
            return thangGui * tienGui * laiSuat / 100;
        }
        public double TongTien(double tienlai, double tiengui)
        {
            return tienlai + tiengui;
        }
        public void Run()
        {
            Console.Write("Lai suat: ");
            float laiSuat = float.Parse(Console.ReadLine());
            Console.Write("So tien gui vao: ");
            double tienGui = double.Parse(Console.ReadLine());
            Console.Write("So thang gui: ");
            int thangGui = Int16.Parse(Console.ReadLine());

            Console.Write("Tien lai: "+ Math.Round(TienLai(laiSuat,tienGui,thangGui)));
            Console.Write("\nTong so tien nhan: " + Math.Round(TongTien(TienLai(laiSuat, tienGui, thangGui),tienGui)));
            Console.ReadKey();


        }
    }
}
