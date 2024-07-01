using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Array_Problems
{
    internal class MaxSubsetSum
    {
        //There are two ways to find subset of string
        //back tracking and bitwise

        static void CalcSubset(List<int> A,
                          List<List<int>> res,
                          List<int> subset, int index)
        {
            // Add the current subset to the result list
            res.Add(new List<int>(subset));

            // Generate subsets by recursively including and
            // excluding elements
            for (int i = index; i < A.Count; i++)
            {
                // Include the current element in the subset
                subset.Add(A[i]);

                // Recursively generate subsets with the current
                // element included
                CalcSubset(A, res, subset, i + 1);

                // Exclude the current element from the subset
                // (backtracking)
                subset.RemoveAt(subset.Count - 1);
            }
        }
        static List<List<int>> Subsets(List<int> A)
        {
            List<int> subset = new List<int>();
            List<List<int>> res = new List<List<int>>();
            int index = 0;
            CalcSubset(A, res, subset, index);
            return res;
        }

        // Driver code
        static void MainFunction()
        {
            List<int> array = new List<int> { 1, 2, 3 };
            List<List<int>> res = Subsets(array);

            // Print the generated subsets
            foreach (List<int> subset in res)
            {
                Console.WriteLine(string.Join(" ", subset));
            }
        }

    }
}
