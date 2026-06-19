public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        if (nums1 == null || nums1.Length == 0)
            return (double) (nums2.Length % 2 != 0 ? nums2[nums2.Length / 2] : ((nums2[nums2.Length / 2 - 1] + nums2[nums2.Length / 2]) / 2.0));
        else if (nums2 == null || nums2.Length == 0)
            return (double) (nums1.Length % 2 != 0 ? nums1[nums1.Length / 2] : ((nums1[nums1.Length / 2 - 1] + nums1[nums1.Length / 2]) / 2.0));

        int mergedLength = nums1.Length + nums2.Length;
        int half = mergedLength / 2 - (mergedLength % 2 == 0 ? 1 : 0);

        int[] smallerArray = nums1.Length < nums2.Length ? nums1 : nums2;
        int[] largerArray = smallerArray == nums1 ? nums2 : nums1;

        int l = 0;
        int r = smallerArray.Length;

        while (l <= r)
        {

            int smallIndex = (r - l) / 2 + l;
            int largeIndex = half - smallIndex;

            if (smallIndex != 0 && largeIndex != largerArray.Length)
            {

                if (smallerArray[smallIndex - 1] > largerArray[largeIndex])
                {

                    r = smallIndex - 1;
                    continue;

                }

            }

            if (largeIndex != 0 && smallIndex != smallerArray.Length)
            {

                if (largerArray[largeIndex - 1] > smallerArray[smallIndex])
                {

                    l = smallIndex + 1;
                    continue;
                
                }
                
            }

            if (mergedLength % 2 != 0)
            {

                if (smallIndex == smallerArray.Length)
                    return largerArray[largeIndex];
                else if (largeIndex == largerArray.Length)
                    return smallerArray[smallIndex];
                
                return (double) Math.Min(smallerArray[smallIndex], largerArray[largeIndex]);

            }

            int median1 = Math.Min(smallerArray[smallIndex], largerArray[largeIndex]);

            if (median1 == smallerArray[smallIndex])
                smallIndex++;
            else
                largeIndex++;

            int median2;

            if (smallIndex == smallerArray.Length)
                median2 = largerArray[largeIndex];
            else if (largeIndex == largerArray.Length)
                median2 = smallerArray[smallIndex];
            else
                median2 = Math.Min(smallerArray[smallIndex], largerArray[largeIndex]);

            return (median1 + median2) / 2.0;
                
        }

        return -1;

    }
}
