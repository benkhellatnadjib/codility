using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BinaryGrap
{
    class Solution {
        public int solution(int N)
        {
            int binaryBase = 2;
            string binValue = Convert.ToString(N, binaryBase);
            Regex regularExpression = new Regex("^([0-0])(.*)");
            MatchCollection matches = regularExpression.Matches(binValue);
            int maxLengthValue = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                //Console.WriteLine("matched string {0}", matches[i].Value);
                maxLengthValue = matches[i].Value.Length;
            }
            //Console.WriteLine("The max sequence is {0}", maxLengthValue);
            //Console.ReadLine();
            return maxLengthValue;
        }
    }
}
