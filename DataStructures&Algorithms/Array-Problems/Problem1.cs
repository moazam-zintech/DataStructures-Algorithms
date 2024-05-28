using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Array_Problems
{
    internal class Problem1
    {
        public void Function()
        {
            /*Two Sum: Given an array of numbers and a target sum,
          * find a pair of numbers in the array that adds 
          * up to the target sum. 
*/
            int[] arr = { 3, 82, 3, 4, 2, 6 };
            int target = 8;
            int temp = 0, temp2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {

                        temp = i;
                        temp2 = j;
                        break;
                    }
                }
            }
            Console.WriteLine(temp + " ," + temp2);
        }
    }
}
