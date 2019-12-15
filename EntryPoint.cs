using CS_Algorithm._6kyu;
using CS_Algorithm._7kyu;
using CS_Algorithm._8kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_Algorithm
{
    class EntryPoint
    {
        static void Main(string[] args)
        {

            int a = 100;
            int b = 5;
            decimal c = (decimal)a / b;

            long d = 155;
            long FindNextSquare = Find_the_next_perfect_square.FindNextSquare(d);

            // 動態陣列宣告方式
            // int[] result = new int[0] { };
 //           List<int> squares = new List<int>();
 //           squares = Rectangle_into_Squares.sqInRect(5, 3);

            int multiply = Multiply.multiply(2, 3);
            Console.WriteLine(multiply);

            bool IsSquare = You_re_a_square_.IsSquare(100);
            Console.WriteLine(IsSquare);

            long rowSumOddNumbers = Sum_of_odd_numbers.rowSumOddNumbers(42);
            Console.WriteLine(rowSumOddNumbers);

            int[] aa = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] bb = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };
            int[] cc = new int[0];
            int[] dd = new int[0];
            bool comp = Are_they_the_same.comp(null, null);
            Console.WriteLine(comp);

            string seriesSum = Sum_of_the_first_nth_term_of_Series.SeriesSum(55);
            Console.WriteLine(seriesSum);

     //---------------------------------------------

            string str = "Hey fellow warriors";
            
            char[] CA = str.ToCharArray();
            string[] str1 = str.Select(word => word + "GG").ToArray();

            string[] ssize = str.Split(new char[] {' '});
            string[] result = ssize.Select(word => word.Length >= 5 ? string.Concat(word.Reverse()) : word).ToArray();
            string result_join = string.Join(" ", result);

            string SpinWords = Stop_gninnipS_My_sdroW_.SpinWords(str);

            Console.WriteLine(str1);
            Console.WriteLine(CA);
            Console.WriteLine(ssize);
            Console.WriteLine(SpinWords);
            Console.ReadLine();
        }
    }
}
