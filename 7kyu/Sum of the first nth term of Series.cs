using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Algorithm._7kyu
{
    class Sum_of_the_first_nth_term_of_Series
    {
        // https://www.codewars.com/kata/sum-of-the-first-nth-term-of-series/csharp
        public static string SeriesSum(int n)
        {
            double sum = 1;
            double temp = 1;
            if (n == 0)
                return n.ToString("f2");
            else if(n == 1)
                return n.ToString("f2");
            else
            {
                for(int i = 1; i < n; i++)
                {
                    temp += 3;
                    sum += (1 / temp);
                }
            }
            return sum.ToString("f2");
        }
    }
}
