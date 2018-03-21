using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class Peaks
    {
        public int solution(int[] A)
        {
            //Declarations 
            bool atLeastOnePeakExists = false;
            //if the array is too small
            if (A.Length <= 2) return 0;
            //if the array can not be divided into equal subarrays with length >1
            bool IsPrime = Enumerable.Range(1, A.Length).Where(x => A.Length % x == 0).SequenceEqual(new[] { 1, A.Length });

            if (IsPrime)
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (i < A.Length && i > 0 && A[i] > A[i - 1] && A[i] > A[i + 1])
                    {
                        return 1;
                    }
                }
                return 0;
            }
            bool foundPreak = false;
            int lastDivision = 0;
            for (int k = 2; k <= A.Length / 2; k++)
            {
                if (A.Length % k == 0)
                {
                    //Check those subarrays lengths ==> if it represents a valid division
                    for (int i = 0; i < A.Length / k; i++)
                    {
                        foundPreak = false;
                        for (int n = i*k; n < k*(i+1) ; n++)
                        {
                            if (n > 0 && n < A.Length - 1 && A[n] > A[n + 1] && A[n] > A[n - 1])
                            {
                                atLeastOnePeakExists = true;
                                foundPreak = true;
                                break;
                            }
                            
                        }
                        if (!foundPreak) break;
                    }
                    lastDivision = A.Length/k;
                    if (foundPreak) return A.Length / k;
                }
            }
            if (!foundPreak)
            {
                if (atLeastOnePeakExists) return 1;
                else return 0;
            }
            else
            {
                return lastDivision;
            }
            //If we did not found a division yet if we got an least one peak the result would be 1
            if (atLeastOnePeakExists) return 1;
        }
    }
}
