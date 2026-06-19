public class Solution 
{
    public int MaxArea(int[] heights) 
    {

        var l = 0;
        var r = heights.Length - 1;
        var maxWater = 0;

        while (l < r)
        {

            var currWater = Math.Min(heights[l], heights[r]) * (r - l);

            if (Math.Min(heights[l], heights[r]) * (r - l) > maxWater)
                maxWater = currWater;

            if (heights[l] >= heights[r])
                r--;
            else
                l++;


        }

        return maxWater;
        
    }
}
