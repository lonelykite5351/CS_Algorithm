using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Algorithm._7kyu
{

    // https://www.codewars.com/kata/54c27a33fb7da0db0100040e
    class You_re_a_square_
    {
        public static bool IsSquare(int n)
        {
            return Math.Pow(n, 0.5) % 1 == 0 ? true : false;
        }
    }
}
