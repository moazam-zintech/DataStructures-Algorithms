namespace DataStructures
{
    public static class TwoSumClass
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = i + 1;
                for (int j = 0; j < (nums.Length - (i + 1)); j++)
                {
                    if (nums[i] + nums[temp] == target)
                    {
                        result[0] = i;
                        result[1] = temp;
                        return result;
                    }
                    temp++;
                }
            }
            return result;
        }
    }
}