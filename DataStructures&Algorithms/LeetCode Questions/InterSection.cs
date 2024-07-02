namespace DataStructures
{
    public class InterSection
    {
        public static int[] InterSection(int[] nums1, int[] nums2)
        {
            if (nums2.Length < nums1.Length)
            {
                var temp = nums2;
                nums2 = nums1;
                nums1 = temp;
            }


            List<int> nums2List, list = new List<int>();
            nums2List = nums2.ToList();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2List.Count; j++)
                {
                    if (nums1[i] == nums2List[j])
                    {
                        list.Add(nums1[i]);
                        nums2List.RemoveAt(j);
                        break;
                    }
                }
            }
            return list.ToArray();
        }
    }
}