namespace DataStructures
{
    public static class ThreeConsectiveNumbers
    {
        public static bool ThreeConsectiveOdds(int[] arr)
        {
            int count = 0, temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    temp = i;
                    count++;
                }
                else if (temp < 2)
                {
                    count = 0;
                    temp = 0;
                }
            }
            if (count >= 3)
            {
                return true;
            }
            return false;
        }
    }
}