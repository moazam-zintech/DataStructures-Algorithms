
namespace DataStructures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] num = { 0, 13, 12, 3, 4, 6, 34, 43, 8, 70, 30 };
            int[] arr= TwoSumClass.TwoSum(num,100);
            Console.WriteLine("["+arr[0] + "," + arr[1]+"]");
        }
    }
}