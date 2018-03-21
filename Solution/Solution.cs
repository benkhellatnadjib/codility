using System;
using System.Collections.Generic;

namespace Solution
{
    public class Solution
    {

        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            List<int> integerList = new List<int>();
            integerList.Sort();
            for (int i = 0; i < integerList.Count; i++)
            {
                if (i + 1 <= integerList.Count)
                {
                    if (integerList[i + 1] > 0 && (integerList[i + 1] - integerList[i] > 0))
                    {
                        return integerList[i] + 1;
                    }
                }
                else
                {
                    return integerList[integerList.Count]+1;
                }
            }
            return integerList[integerList.Count] + 1;
        }
    }
}
