using System;
using System.Linq;

namespace CS_Algorithm._6kyu
{
    class Equal_Sides_Of_An_Array
    {
        public static int FindEvenIndex(int[] arr)
        {
            int leftSum = 0;
            int currentValue = 0;
            int rightSum = arr.Sum();

            for(int index=0; index < arr.Length; index++)
            {
                leftSum += currentValue;
                currentValue = arr[index];
                rightSum -= currentValue;
                if (leftSum == rightSum)
                    return index;
            }
            return -1;
        }

    /*
        int FindEvenIndex1 = Equal_Sides_Of_An_Array
                .FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 });
        int FindEvenIndex2 = Equal_Sides_Of_An_Array
            .FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 });
    */

    }
}
