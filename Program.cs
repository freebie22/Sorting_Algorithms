using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 10, 4, 25, 15, 53, 43 };
            SortingAlgorithms.QuickSort(myArray);
            
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
        }


        //1! = 1 * 0! = 1
        //2! = 2 * 1 = 2 * 1!
        //3! = 3 * 2 * 1 = 3 * 2! 
        //4! = 4 * 3 * 2 * 1 = 4 * 3! 
        //n! = n * (n-1)!

        //1*RecursiveFactorial(1-1) = 1 ->
        //2*RecursiveFactorial(2-1) = 2 * 1 = 2 ->
        //3*RecursiveFactorial(3-1) = 3 * 2 = 6 ->

        private static int RecursiveFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * RecursiveFactorial(n - 1);
        }

        private static int IterativeFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
