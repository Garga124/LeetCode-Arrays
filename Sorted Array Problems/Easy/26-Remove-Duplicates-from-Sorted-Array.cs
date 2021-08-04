public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length<=0)
            return 0;
        int index = 1; //1
        
        for(int i =0;i<nums.Length-1;i++)
        {
            if(nums[i] != nums[i+1]){
                nums[index++] = nums[i+1];
            }
        }
        return index;
        
    }
}