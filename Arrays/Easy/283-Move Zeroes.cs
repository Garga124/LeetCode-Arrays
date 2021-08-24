public class Solution {
    public void MoveZeroes(int[] nums) {
        int index = 0;
   for(int i = 0;i<nums.Length;i++){
       if(nums[i]!=0){
           nums[index++] = nums[i];
       }
   }
        
        for(int j = index;j<nums.Length;j++){
            nums[j] = 0;
        }
        
    }
}