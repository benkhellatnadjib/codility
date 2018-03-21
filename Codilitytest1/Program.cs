using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryGrap;

namespace Codilitytest1
{
    class Program
    {

        static void Main(string[] args)
        {


            string S = "CAGCCTA";
            int[] P = { 2, 5, 0 };
            int[] Q = { 4, 5, 6 };

            DNA dna = new DNA();
            int[] result = dna.solution(S, P, Q);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(" min impact[{0}] = {1}, ", i, result[i]);
            }
            
            //MaxCounters maxCounters = new MaxCounters();
            //int[] result = maxCounters.solution(5, A);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.WriteLine("counter{0} == {1}", i, result[i]);
            //}
            Console.ReadLine();
            //Peaks peaks = new Peaks();
            //int result =  peaks.solution(A);
            //Console.WriteLine("Number of sub arrays with peaks is {0}", result);
            //int[] A = { 1, 5, 2, 1, 4, 0 };
            //int[] A= { 1, 10, 100, 1 };
            //int[] A = GenerateRandomArray(500);
            //NumberDiscIntersections discIntersections = new NumberDiscIntersections();
            //int result = discIntersections.solution(A);
            //Console.WriteLine("intersections number result is : {0}", result);

            //PermCheck permChack = new PermCheck();
            //int  result = permChack.solution(A);
            //Console.WriteLine("permCheck result is : {0}", result);

            //MissingInteger missingInteger = new MissingInteger();
            ////{ 2,28,6,5,9,1,6,3};
            ////{ 3,1,2,4,3}
            //int[] A = { 2, 28, 6, 5, 9, 1, 6, 3 };
            //int result = missingInteger.solution(A);

            //Console.WriteLine(string.Format("The result is {0}", result));
            //Console.ReadLine();
            //MissingNumber missingN = new MissingNumber();
            //int[] A = GenerateMissingValueArray(100000, 10001);
            //int result = missingN.solution(A);
            //Console.WriteLine(string.Format("The missing number is : {0}", result));

            //Console.ReadLine();
            //= GenerateRandomArray(601);
            //int[] A = { 1,2,3,5,4,2,1,5,1,4,5,8,6};
            //ArrayCyclicRotation cyclycRotate = new ArrayCyclicRotation();

            //int[] result = cyclycRotate.solution(A, -1);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(string.Format("result[{0}]={1}", i, result[i]));
            //}
            //Console.ReadLine();
            //int X = 10;
            //int Y = 85;
            //int D =30;
            //FrogJump frog = new FrogJump();
            //int result  = frog.solution(X, Y, D);
            //Console.WriteLine("X={0}, Y={1}, D={2}, the number of jumps: {3}", X, Y, D, result);
            //Console.ReadLine();
        }
        public static int[] GenerateMissingValueArray(int arrayLength, int missingNumber)
        {
            int[] A = new int[arrayLength];
            int value = 1;
            for (long i = 0; i < arrayLength; i++)
            {
                if (value == missingNumber) value++;
                A[i] = value;
                value++;
            }
            return A;
        }
        private static int[] GenerateRandomArray(int n)
        {
            int[] A = new int[n];
            for (int i = 1; i < n; i++)
            {
                A[i] = i * 2 - 1;
                A[i - 1] = i * 2 - 1;
            }
            A[n-1] = n + 1;
            return A;
        }
    }
}
