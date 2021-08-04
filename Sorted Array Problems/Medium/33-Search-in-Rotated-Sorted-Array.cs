public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0; int right = nums.Length -1;
        int targetIndex = -1;
        
        while(left<=right){
           int midValue = left + (right - left)/2;
           if(nums[midValue] == target) {
                targetIndex = midValue;
               return targetIndex;
           } else if (nums[midValue]>=nums[left]){
                //This is a case of strictly increasing graph
               //Now see if the target element is present between this range
               if(target <= nums[midValue] && target>=nums[left])
                   right = midValue - 1;
              else
                  left = midValue + 1;
           } else{
               if(target>=nums[midValue] &&  target<=nums[right])
                   left =  midValue + 1;
               else
                   right = midValue - 1;
           }
        }
           return targetIndex;
        
    }
}