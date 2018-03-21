using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            int lastMaxCounterValue=0;
            int maxCounterValue = 0;
            int[] counters = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == N+1)
                {
                    //set all counters to the max value
                    lastMaxCounterValue = maxCounterValue;
                }
                else
                {
                    if(A[i] >=1 && A[i] <= N)
                    {
                        if(counters[A[i]-1] <= lastMaxCounterValue)
                        {
                            counters[A[i] - 1] = lastMaxCounterValue;                            
                        }
                        counters[A[i] - 1]++;
                        if (counters[A[i] - 1] > maxCounterValue)
                            maxCounterValue = counters[A[i] - 1];
                    }
                }
                
            }
            for (int k = 0; k < N; k++)
            {
                if (counters[k] < lastMaxCounterValue)
                    counters[k] = lastMaxCounterValue;
            }
            return counters;
        }
    }
}
