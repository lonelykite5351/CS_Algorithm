using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS_Algorithm._7kyu
{

    //https://www.codewars.com/kata/56269eb78ad2e4ced1000013
    class Find_the_next_perfect_square
    {
        public static long FindNextSquare(long num)
        {
            double n2 = Math.Sqrt(num);
            return n2 != Convert.ToInt32(n2) ? -1 : (long)Math.Pow(n2 + 1, 2);
        }

/*
        long d = 155;
        long FindNextSquare = Find_the_next_perfect_square.FindNextSquare(d);
*/
    }
}
