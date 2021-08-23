//Time Complexity : O(N)
//Space Complexity : O(N)
public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int sum = 0; int result = 0;
        Dictionary<int, int> preSum = new Dictionary<int,int>();
        preSum.Add(0,1);
        for(int i =0;i<nums.Length;i++){
            sum += nums[i];
            if(preSum.ContainsKey(sum-k)){
                result += preSum[sum-k];
            }
            if(preSum.ContainsKey(sum)){
                preSum[sum] = preSum[sum] +1;
            }else{
                preSum.Add(sum,1);
            }
        }
        return result;
        
    }
}