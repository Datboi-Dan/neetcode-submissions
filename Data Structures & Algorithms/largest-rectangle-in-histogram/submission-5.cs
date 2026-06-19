public class Solution 
{
    
    public int LargestRectangleArea(int[] heights) 
    {

        var largestArea = 0;

        var heightStack = new Stack<(int Height, int Index)>();
        
        for (int i = 0; i < heights.Length; i++)
        {
            
            while (heightStack.Any() && heightStack.Peek().Height >= heights[i])
            {

                var height = heightStack.Pop().Height;
                var length = heightStack.Any() ?  i - heightStack.Peek().Index - 1 : i;
                largestArea = Math.Max(height * length, largestArea);

            }

            heightStack.Push((heights[i], i));
            
        }

        while (heightStack.Any())
        {

            var height = heightStack.Pop().Height;
            var length = heightStack.Any() ? heights.Length - heightStack.Peek().Index - 1 : heights.Length;
            largestArea = Math.Max(height * length, largestArea);

        }
            
        return largestArea;

    }

}


