using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class DuongDan
    {
        public String S { get; set; }
        public DuongDan(String s)
        {
            S = s;
        }
        public String getPath()
        {
            String path = "";
            int last = S.LastIndexOf('\\');

            path = S.Substring(0, last);

            return path;

        }
        public String getFileName()
        {
            String fileName = "";
            int first = S.LastIndexOf('\\');
            int last = S.LastIndexOf('.');
            fileName = S.Substring(first+1,last-first-1);
            return fileName;

        }
        public String getExtension()
        {
            String extension = "";
            int first = S.LastIndexOf('.');
            extension = S.Substring(first+1);
            return extension;

        }
         public String getDisk()
        {
            String disk = "";
            int first = S.IndexOf('\\');
            disk = S.Substring(0, first);
            return disk;

        }
        public String[] getFolders()
        {
            String[] fodlers = new String[100];
            int first = S.IndexOf('\\');
            int last = S.LastIndexOf('\\');
            String chuoi = S.Substring(first, last-first);
            fodlers = chuoi.Split('\\');

            return fodlers;
        }
        public void Main()
        {

            try
            {
                Console.Write("----- Result Analysis -----");
                Console.Write("\nDisk: " + getDisk());
                Console.Write("\nExtension: " + getExtension());
                Console.Write("\nFile Name: " + getFileName());
                Console.Write("\nPath: ");
                Console.Write(getPath());
                Console.Write("\nFolders: ");
                String[] folders = getFolders();
                for (int i = 1; i < folders.Length; i++)
                {
                    Console.Write("[" + folders[i] + "]   ");
                }
            }
            catch(Exception e)
            {
                Console.Write("Chuoi khong hop le!+ "+e.ToString());
            }
            
            Console.ReadKey();
        }

       
    }
}
