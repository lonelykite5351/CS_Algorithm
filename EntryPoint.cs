using CS_Algorithm._6kyu;
using CS_Algorithm._7kyu;
using System;
using System.Collections.Generic;
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
            
            
            List<int> squares = new List<int>();
            squares = Rectangle_into_Squares.sqInRect(5, 3);

            Console.WriteLine(FindNextSquare);
            squares.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
