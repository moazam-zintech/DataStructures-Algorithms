using System;
using System.Collections.Specialized;
using System.ComponentModel.Design;
namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] num = { 3,3,7,2,2,4 };
            Console.WriteLine(ThreeConsectiveNumbers.ThreeConsectiveOdds(num)
        );
        }
    }
}