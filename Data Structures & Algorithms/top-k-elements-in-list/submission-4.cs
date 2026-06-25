public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
       
        var freqs = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            
            if (!freqs.ContainsKey(num))
                freqs.Add(num, 0);

            freqs[num]++;

        }

        var buckets = new List<int>[nums.Length];
        foreach (KeyValuePair<int, int> kvp in freqs)
        {
            if (buckets[kvp.Value - 1] == null)
                buckets[kvp.Value - 1] = new List<int>();
            buckets[kvp.Value - 1].Add(kvp.Key); 
        }

        var topK = new int[k];
        int posFromTop = 0;
        
        for (int i = 0; i < k; i++)
        {
            
            while (buckets[buckets.Length - 1 - posFromTop] == null || buckets[buckets.Length - 1 - posFromTop].Count == 0)
                posFromTop++;

            topK[i] = buckets[buckets.Length - 1 - posFromTop][0];
            buckets[buckets.Length - 1 - posFromTop].RemoveAt(0);

        }

        return topK;

    }
}
