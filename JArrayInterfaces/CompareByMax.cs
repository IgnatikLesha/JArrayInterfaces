using System;
using System.Linq;

namespace JArrayInterfaces
{
    public class CompareByMax
    {

        public class ByMax : IComparer
        {
            public int Compare(int[] a, int[] b)
            {
                if (a == null || b == null)
                    throw new ArgumentNullException();

                if (a.Max() > b.Max())
                    return 1;
                else if (a.Max() < b.Max())
                    return -1;
                else
                    return 0;
            }
        }
    }
}
