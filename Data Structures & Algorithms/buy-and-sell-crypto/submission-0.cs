public class Solution {
    public int MaxProfit(int[] prices) {

        int cost = prices[0];
        int net = 0;

        for (int i = 0; i < prices.Length; i++)
        {

            net = Math.Max(prices[i] - cost, net);
            cost = Math.Min(prices[i], cost);

        }

        return net;
        
    }
}
