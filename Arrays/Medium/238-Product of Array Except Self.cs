//Time Complexity : O(2N) =>O(N)
//Space Complexity :O(N)= Output array is not being considered in space complexity analyisis
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if(nums == null || nums.Length ==0){
            return nums;
        }
        int n = nums.Length;
     int [] res = new int[n];
        res[0] = 1;
        for(int i = 1;i<n;i++){
            res[i] = nums[i-1]*res[i-1];
        }
        int right = 1;
        for (int j = n-1;j>=0;j--){
            res[j]*=right;
            right*=nums[j];
        }
        return res;
        
    }
}