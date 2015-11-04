using System;
using System.Linq;

namespace JArrayInterfaces
{
    public class CompareBySum
    {

        public class BySum : IComparer
        {
            public int Compare(int[] a, int[] b)
            {
                if (a == null || b == null)
                    throw new ArgumentNullException();
                if (a.Sum() == int.MaxValue || b.Sum() == int.MaxValue)
                    throw new OverflowException();

                if (a.Sum() > b.Sum())
                    return 1;
                else if (a.Sum() < b.Sum())
                    return -1;
                else
                    return 0;
            }
        }
    }
}