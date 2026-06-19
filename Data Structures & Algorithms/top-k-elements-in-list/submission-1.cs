public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {

        var freqs = new Dictionary<int, int>();
        foreach (var num in nums)
            freqs[num] = freqs.GetValueOrDefault(num, 0) + 1;
        
        var buckets = new Stack<int>[nums.Length];        
        foreach (int key in freqs.Keys)
        {

            var bucket = freqs[key] - 1;
            
            if (buckets[bucket] is null)
                buckets[bucket] = new Stack<int>();

            buckets[bucket].Push(key);

        }

        var kMostFrequent = new int[k];
        var index = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {

            if (buckets[i] is not null)
            {
                
                kMostFrequent[index++] = buckets[i].Pop();

                if (buckets[i].Count != 0)
                    i++;
                    
            }

            if (index >= k)
                break;
            
        }
        return kMostFrequent;
        

    }
}
