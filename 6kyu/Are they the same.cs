using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Algorithm._6kyu
{
    // https://www.codewars.com/kata/are-they-the-same/csharp
    class Are_they_the_same
    {
        public static bool comp(int[] a, int[] b)
        {
            if(a == null || b == null)
                return false;
            if (a.Length != b.Length || a == null || b == null)
                return false;
            else
            {
                Array.Sort(a);
                Array.Sort(b);
                for(int i = 0; i < a.Length; i++)
                {
                    if (Math.Pow(a[i], 2) != b[i])
                        return false;
                }
            }
            return true;
        }
    }
}
