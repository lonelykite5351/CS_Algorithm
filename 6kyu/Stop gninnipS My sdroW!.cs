using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS_Algorithm._6kyu
{
    class Stop_gninnipS_My_sdroW_
    {
        // https://www.codewars.com/kata/stop-gninnips-my-sdrow/csharp
        public static string SpinWords(string sentence)
        {
            string[] s_split = sentence.Split(new char[] { ' ' });
            string[] s_reverse = 
                s_split.Select(
                    word => word.Length >= 5 ? 
                string.Concat(word.Reverse()) : word).ToArray();
            string result = string.Join(" ", s_reverse);
            return result;
        }
    }
}
