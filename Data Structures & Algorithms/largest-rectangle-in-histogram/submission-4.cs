public class Solution 
{
    
    public int LargestRectangleArea(int[] heights) 
    {

        var largestArea = 0;

        var heightStack = new Stack<int[]>();
        
        for (int i = 0; i < heights.Length; i++)
        {
            
            while (heightStack.Any() && heightStack.Peek()[0] >= heights[i])
            {

                var height = heightStack.Peek()[0];
                var index = heightStack.Pop()[1];
                var length = heightStack.Any() ?  i - heightStack.Peek()[1] - 1 : i;
                largestArea = Math.Max(height * length, largestArea);

            }

            heightStack.Push(new int[] {heights[i], i});
            
        }

        while (heightStack.Count > 1)
            largestArea = Math.Max(heightStack.Pop()[0] * (heights.Length - heightStack.Peek()[1] - 1), largestArea);

        largestArea = Math.Max(heightStack.Pop()[0] * heights.Length, largestArea);
            
        return largestArea;

    }

}


