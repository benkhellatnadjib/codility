using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codilitytest1
{
    public class MissingInteger
    {
        public int solution(int[] A)
        {
            if (A.Length == 0) return 1;
            if (A.Length == 2) return Math.Abs(A[0] - A[1]);
            int RightSum = A[A.Length-1];
            int LeftSum = A[0];
            int k = A.Length - 2;
            int j = 1;
            for (int i = 1; i < A.Length; i++)
            {
                if ((LeftSum>RightSum) )
                {
                    if ((Math.Abs(LeftSum - (Math.Abs(A[k] + RightSum))) < Math.Abs(LeftSum - RightSum)))
                    {
                        RightSum = RightSum + A[k];
                        k--;
                        if (k < j) RightSum = RightSum + A[k];
                    }
                    else
                    {
                        if((Math.Abs(LeftSum - (Math.Abs(A[k] + RightSum)))>Math.Abs((LeftSum+A[j])- RightSum)))
                        {
                            LeftSum = LeftSum + A[j];
                            j++;
                            if (k < j) LeftSum = LeftSum + A[j];
                        }
                        else
                        {
                            RightSum = RightSum + A[k];
                            k--;
                            if (k < j) RightSum = RightSum + A[k];
                        }
                    }
                }
                else
                {
                    LeftSum = LeftSum + A[j];
                    j++;
                    if (Math.Abs(k - j) == 0) LeftSum = LeftSum + A[j];
                }
                if (k < j)
                    break;
            }

            return Math.Abs(LeftSum - RightSum);
        }


        // if (A.Length == 0) return 1;
        //    int p = 1;
        //int RightSum = A[A.Length - 1];
        //int LeftSum = A[0];
        //int ActualDiff = 0;
        //int k = A.Length - 2;
        //int j = 1;
        //    for (int i = 1; i<A.Length; i++)
        //    {
        //        if (Math.Abs(LeftSum + A[j] - RightSum) <= Math.Abs(LeftSum - (RightSum + A[k])))
        //        {
        //            LeftSum = LeftSum + A[j];
        //            j++;
        //        }
        //        else
        //        {
        //            RightSum = RightSum + A[k];
        //            k--;
        //        }
        //        if (Math.Abs(k - j) == 0)
        //            break;
        //    }
            
        //    return Math.Abs(LeftSum-(RightSum));
    }
}

