public class Solution {
    public int Trap(int[] height) 
    {

        var water = 0;
        var l = 0;
        
        for (int i = 1; i < height.Length; i++)
        {

            if (height[l] <= height[i])
            {

                for (int j = i - 1; j > l; j--)
                    water += height[l] - height[j];

                l = i;

            }

            if (i == height.Length - 1)
            {


                var maxHeight = height[i];
                
                var j = i - 1;

                while (height[j] >= maxHeight && j > l)
                    maxHeight = height[j--];

                while (j > l)
                {
                    
                    if (maxHeight < height[j])
                        maxHeight = height[j];

                    water += maxHeight - height[j--];
                    

                }

            }
            
        }

        return water;
        
    }
}