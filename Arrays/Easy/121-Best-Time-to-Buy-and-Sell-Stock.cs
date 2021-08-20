public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        if(prices.Length ==0){
            return 0;
        }
        
        int min = Int32.MaxValue;
        for(int i = 0;i<prices.Length;i++){
            if(prices[i]<min){
                min = prices[i];
            }else{
                max = Math.Max(max,prices[i]-min);
            }
        }
        return max;
    }
}