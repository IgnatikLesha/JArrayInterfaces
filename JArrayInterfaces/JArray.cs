using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JArrayInterfaces
{
    public class JArray
    {
        public static void Swap(int[] a, int[] b)
        {
            int[] c = a;
            a = b;
            b = c;
        }

        public static void SwapRows(int a, int b, int[][] arr)
        {
            for (int i = a; i < b; i++)
            {
                Swap(arr[i], arr[i + 1]);
            }
        }

        public static void ArraySort(int[][] jaggedArray, IComparer ComRows)
        {
            if (jaggedArray == null)
                throw new ArgumentNullException("NULL");
            if (jaggedArray.Length == 0)
                throw new ArgumentException("jaggedArray is empty");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                if (jaggedArray[i] == null)
                    SwapRows(i, jaggedArray.Length, jaggedArray);
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray.Length; j++)
                {
                    if (ComRows.Compare(jaggedArray[j], jaggedArray[j + 1]) == 1)
                    {
                        Swap(jaggedArray[j], jaggedArray[j + 1]);
                    }
                }
            }
        }
    }
}
