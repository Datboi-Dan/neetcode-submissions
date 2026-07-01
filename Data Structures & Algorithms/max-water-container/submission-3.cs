public class Solution 
{
    public int MaxArea(int[] heights) 
    {

        int l = 0;
        int r = heights.Length - 1;
        int maxArea = 0;

        while (l < r)
        {

            int height = heights[l] > heights[r] ? heights[r] : heights[l];
            int area = (r - l) * height;
            maxArea = area > maxArea ? area : maxArea;

            if (heights[l] < heights[r])
                l++;
            else
                r--;

        }

        return maxArea;

    }
}
