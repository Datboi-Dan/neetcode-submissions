public class Solution 
{
    
    public int LargestRectangleArea(int[] heights) 
    {

        var largestArea = 0;

        var heightStack = new Stack<int>();
        
        for (int i = 0; i < heights.Length; i++)
        {
            
            while (heightStack.Any() && heights[heightStack.Peek()] >= heights[i])
            {

                var height = heights[heightStack.Pop()];
                var length = heightStack.Any() ?  i - heightStack.Peek() - 1 : i;
                largestArea = Math.Max(height * length, largestArea);

            }

            heightStack.Push(i);
            
        }

        while (heightStack.Any())
        {

            var height = heights[heightStack.Pop()];
            var length = heightStack.Any() ? heights.Length - heightStack.Peek() - 1 : heights.Length;
            largestArea = Math.Max(height * length, largestArea);

        }
            
        return largestArea;

    }

}


