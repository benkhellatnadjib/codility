using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class NumberDiscIntersections
    {
        public int solution(int[] A)
        {
            //Exceptional cases where we can already know that no intersections exist
            if (A.Length == 0 || A.Length == 1) return 0;
            //Create a dictionary based on the array: the dictionary will contain the linear coordinates of each disc
            //Check the intersection for each disc
            int intersections = 0;
            for (long i = 0; i < A.Length; i++)
            {
                for (long j = i + 1; j < A.Length; j++)
                {
                    if (
                        (((j - A[j]) <= (i - A[i])) && ((i - A[i]) <= (j + A[j])))
                        ||
                         (((j - A[j]) <= (i + A[i])) && ((i + A[i]) <= (j + A[j])))
                         ||
                         ((((j-A[j])>= (i-A[i]))) && ((i+A[i] >=(j+A[j]))))
                         ||
                          ((((i - A[i]) >= (j - A[j]))) && ((j + A[j] >= (i + A[i]))))
                        )
                        intersections++;
                    if (intersections >= 10000000) return -1;
                }
            }
            return intersections;
        }
    }
}
