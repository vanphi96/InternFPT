using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "";
            Console.Write("Nhap vao duong dan!\n");
            s = Console.ReadLine();
            Assignment1.DuongDan xl = new Assignment1.DuongDan(s);
            xl.Main();
        }
    }

}
