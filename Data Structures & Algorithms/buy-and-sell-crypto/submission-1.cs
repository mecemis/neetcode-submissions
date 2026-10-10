public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int max = 0;

        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] < min) {
                min = prices[i];
            }else{
                max = Math.Max(prices[i] - min, max);
            }
        }
        return max;
    }
}
