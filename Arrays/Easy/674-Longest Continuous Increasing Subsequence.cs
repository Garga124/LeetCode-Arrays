//Time Complexity : O(N)
//Space Complexity : O(1)
public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
        
        if(nums == null || nums.Length ==0){
            return 0;
        }
        int max = 1;int curr = 1;
        for(int i = 1;i<nums.Length;i++){
            curr = nums[i]>nums[i-1]?curr + 1:1;
            max = Math.Max(max,curr);
        }
        return max;
    }
}