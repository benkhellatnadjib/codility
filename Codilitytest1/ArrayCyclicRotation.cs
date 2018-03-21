using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class ArrayCyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (K < 0 || K>100) throw new ArgumentOutOfRangeException("Error 01: K value has to be positive integer greater or equal to 0!!");
            if (A.Length > 100 ) throw new ArgumentOutOfRangeException("Error 02: Array should at least contain one element!!");
            int[] rotatedArray = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < -1000 || A[i] > 1000) throw new ArgumentOutOfRangeException(string.Format("A[{0}] = {1}value is out of range ([−1,000..1,000])", i, A[i]));
                rotatedArray[(A.Length + i + K) % (A.Length)] = A[i];
            }
            return rotatedArray;
        }
    }
}
