public class Solution 
{
    
    public int MinEatingSpeed(int[] piles, int h) 
    {

        var max = 0;
        var k = max;

        Array.ForEach(piles, x => max = Math.Max(max, x));
        
        int l = 1, r = max;

        while (l < r)
        {

            var m = (r - l + 1) / 2 + l - 1;

            var time = 0;

            Array.ForEach(piles, x => time += (int)Math.Ceiling(x / (double)m));

            if (time <= h)
                r = m;
            else
                l = m + 1;

            k = r;

        }

        return k;

    }
        
}
