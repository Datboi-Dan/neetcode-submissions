public class Solution 
{
    
    public int MinEatingSpeed(int[] piles, int h) 
    {

        int max = 0, min = 1;

        for (int i = 0; i < piles.Length; i++)
            max = Math.Max(piles[i], max);

        while (min < max)
        {

            var mid = (max - min) / 2 + min;

            var timeTaken = 0;
            for (int i = 0; i < piles.Length; i++)
                timeTaken += piles[i] / mid + (piles[i] % mid > 0 ? 1 : 0);

            if (timeTaken > h)
                min = mid + 1;
            else
                max = mid;

        }

        return min;

    }
        
}
