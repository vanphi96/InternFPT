using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class Bai8
    {
        public List<String> XuLy(string hoten)
        {
            string s = hoten;
            List<String> listTu = new List<String>();
            while (s.IndexOf("  ") >= 0)
            {
                s = s.Remove(s.IndexOf("  "), 1);
            }
            s = s.Trim();
            string[] tu = s.Split(' ');
            for (int i = 0; i < tu.Length; i++)
            {
                tu[i] = tu[i].ToLower();
                List<char> kytu = new List<char>();
                kytu.AddRange(tu[i].ToCharArray());
                for (int j = 0; j < kytu.Count; j++)
                {
                    if (kytu[j] == ' ')
                    {
                        kytu.RemoveAt(j);
                    }
                }
                String gheptu = "";
                for(int j=0; j<kytu.Count; j++)
                {
                    if (j == 0)
                    {
                        gheptu = kytu[j].ToString().ToUpper();
                    }
                    else
                    {
                        gheptu += kytu[j].ToString();

                    }
                }
                listTu.Add(gheptu);

            }
            return listTu;

        }
        public void Run()
        {
            Console.Write("Ho ten nguoi thu nhat: ");
            String name1 = Console.ReadLine();
            Console.Write("Ho ten nguoi thu hai: ");
            String name2 = Console.ReadLine();

            List<String> ten1 = XuLy(name1);
            List<String> ten2 = XuLy(name2);

            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Thân gửi: ");
            for(int i=0; i<ten1.Count; i++)
            {
                Console.Write(ten1[i] + " ");
            }
            Console.Write("\nNhân dịp sinh nhật của "+ten1[ten1.Count-1]+"" +
                " cho phép "+ten2[ten2.Count-1]+" gửi đến " + ten1[ten1.Count - 1] +"" +
                " những lời chúc tốt đẹp nhất về sức khỏe, " +
                "\nhạnh phúc và thành công trong mọi lĩnh vực." +
                "\nGửi lời thăm sức khỏe hai bác "+ ten1[ten1.Count - 1]+"."+
                "\nBạn của " + ten1[ten1.Count - 1]+
                "\n");
            for(int i=0; i<ten2.Count; i++)
            {
                Console.Write(ten2[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
