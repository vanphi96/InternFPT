using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class Bai10
    {
        public void Run()
        {
            int giaPhong = 250000;
            int giaAn = 50000;
            int phiDichVu = 100000;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Họ tên khách hàng: ");
            String tenKH = Console.ReadLine();

            Console.Write("Số ngày ở: ");
            int soNgay = Int16.Parse(Console.ReadLine());

            Console.Write("Số bữa ăn: ");
            int soBua = Int16.Parse(Console.ReadLine());

            Console.Write("\n****************************** ");
            Console.Write("\nKhách sạn Five Stars");
            Console.Write("\nHóa đơn khách sạn");
            Console.Write("\nQuí Ông(Bà): ");
            Bai8 b8 = new Bai8();
            List<String> hoTen = b8.XuLy(tenKH);
            for (int i=0; i< hoTen.Count; i++)
            {
                Console.Write(hoTen[i] + " ");
            }
            Console.Write("\nSố ngày ở: "+soNgay+" \nSố bữa ăn: "+soBua);
            Console.Write("\nTiền ở: " + soNgay * giaPhong + "\nTiền ăn: " + soBua * giaAn);
            Console.Write("\nPhí dịch vụ: " + phiDichVu);
            Console.Write("\nTổng tiền: " + (soNgay * giaPhong + soBua * giaAn + phiDichVu));
            Console.Write("\nHân hạnh phục vụ quí khách");
            Console.Write("\n****************************** ");

            Console.ReadKey();
        }
    }
}
