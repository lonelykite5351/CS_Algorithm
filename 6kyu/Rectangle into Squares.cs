using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Algorithm._6kyu
{
    class Rectangle_into_Squares
    {

        public static List<int> sqInRect(int lng, int wdth)
        {
            if(lng == wdth)
                return null;
            List<int> resultList = new List<int>();
            while (lng > 0 && wdth > 0) 
            {
                resultList.Add(lng < wdth ? lng : wdth);
                _ = lng < wdth ? wdth -= lng : lng -= wdth;
            }
            return resultList;
        }
    }
}
