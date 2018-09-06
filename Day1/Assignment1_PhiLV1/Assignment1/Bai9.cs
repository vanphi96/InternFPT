using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Bai9
    {
        public int[] SelectionSort(int n, int[] a)
        {


            int i, imin, j, temp;
            for (i = 0; i <= n - 2; i++)
            {
                imin = a[i]; //Tìm imin
                for (j = i + 1; j <= n - 1; j++)
                    if (a[j] < imin)
                    {
                        imin = a[j];

                        //Hoán đổi a[i] và a[j]
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
            }
            return a;
        }

        public int[] Merge(int left, int mid, int right, int[] array)
        {
            int[] temp1 = new int[mid - left + 1];
            int[] temp2 = new int[right - mid];
            int index_array = left;

            for (int i = 0; i < mid - left + 1; i++)
                temp1[i] = array[index_array++];

            for (int i = 0; i < right - mid; i++)
                temp2[i] = array[index_array++];

            int index_temp1 = 0, index_temp2 = 0;
            index_array = left;

            while (index_temp1 <= mid - left && index_temp2 < right - mid)
            {

                if (temp1[index_temp1] < temp2[index_temp2])
                {

                    array[index_array] = temp1[index_temp1];
                    index_temp1++;
                }
                else
                {

                    array[index_array] = temp2[index_temp2];
                    index_temp2++;
                }
                index_array++;
            }

            while (index_temp1 <= mid - left)
            {

                array[index_array] = temp1[index_temp1];
                index_array++;
                index_temp1++;
            }

            while (index_temp2 < right - mid)
            {

                array[index_array] = temp2[index_temp2];
                index_array++;
                index_temp2++;
            }

            return array;
        }
        public int[] MergeSort( int[] array, int left, int right)
        {
            int mid = (right + left) / 2;
            if (left < right)
            {

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);
                Merge( left, mid, right, array);
            }
            return array;
        }

        public int[] QuickSort(int l, int r, int[] a)
        {
            if (l <= r)
            {
                int key = a[(l + r) / 2];
                int i = l;
                int j = r;

                while (i <= j)
                {
                    while (a[i] < key)
                        i++;
                    while (a[j] > key)
                        j--;

                    if (i <= j)
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                        i++;
                        j--;
                    }
                }

                if (l < j)
                    QuickSort(l, j, a);
                if (r > i)
                    QuickSort(i, r, a);
            }
            return a;
        }

        public void Run()
        {
            Console.Write("Nhap chieu dai mang ");
            int n = Int16.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.Write("Chieu dai mang khong thoa man");
                Console.ReadKey();
                return;
            }
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Int16.Parse(Console.ReadLine());
                b[i] = a[i];
                c[i] = a[i];
            }
            Console.Write("Selection Sort: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(SelectionSort(n, a)[i] + " ");
            }

            Console.Write("\nQuickSort Sort: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(QuickSort(0, n - 1, b)[i] + " ");
            }

            Console.Write("\nMerge Sort: ");
            int[] mc = new int[n];
            mc = MergeSort( c, 0, n - 1);
            for (int i = 0; i < n; i++)
            {
                Console.Write(mc[i] + " ");
            }
       
            Console.ReadKey();

        }
    }


}
