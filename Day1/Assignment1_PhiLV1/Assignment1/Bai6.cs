using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai6
    {
       public static void ChuanChuoi()
        {
            Console.Write("Nhap vao chuoi bat ki:");
            string s = Console.ReadLine();
            
            while(s.IndexOf("  ") >= 0)
            {
                  s= s.Remove(s.IndexOf("  "),1);
            }
            s = s.Trim();
            string[] tu = s.Split(' ');
            for(int i=0; i<tu.Length; i++)
            {
                tu[i] = tu[i].ToLower();
                List<char> kytu = new List<char>();
                kytu.AddRange(tu[i].ToCharArray());
               for(int j=0; j< kytu.Count; j++)
                {
                    if(kytu[j]==' ')
                    {
                        kytu.RemoveAt(j);
                    }
                }
               for(int j =0; j<kytu.Count; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(kytu[j].ToString().ToUpper());
                    }
                    else
                    {
                        Console.Write(kytu[j].ToString());
                    }
                }
                if (i < tu.Length - 1)
                {
                    Console.Write(" ");
                }
                
            }

            Console.ReadKey();
           
        }
    }
}
