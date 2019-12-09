using CS_Algorithm._6kyu;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Algorithm
{
    class EntryPoint
    {
        static void Main(string[] args)
        {

            int FindEvenIndex1 = Equal_Sides_Of_An_Array
                .FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 });
            int FindEvenIndex2 = Equal_Sides_Of_An_Array
                .FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 });


            Console.WriteLine("hello");
            Console.WriteLine(FindEvenIndex1);
            Console.WriteLine(FindEvenIndex2);
            Console.Read();
        }
    }
}
