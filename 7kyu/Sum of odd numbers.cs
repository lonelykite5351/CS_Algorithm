using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Algorithm._7kyu
{
    // https://www.codewars.com/kata/55fd2d567d94ac3bc9000064
    class Sum_of_odd_numbers
    {
        public static long rowSumOddNumbers(long n)
        {
            long sum = 0;
            long first_num = 1;
            long end_num;
            long temp = 0;
            for(int i = 0; i < n; i++)
            {
                first_num += temp;
                temp += 2;
            }
            end_num = first_num + (n - 1) * 2;
            sum = ((first_num + end_num) * n) / 2;
            return sum;
        }
    }
}
