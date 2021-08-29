//Time Complexity : O(logN) + O(logN) => O(2LogN)=>O(logN) 
// space complexity : O(1)
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int first = findFirst(nums, target);
        if(first == -1)
            return new int[]{-1,-1};
        int last =findLast(nums, target,first);
            return new int[]{first,last};
    
    }
        public int findFirst(int[] nums, int target)
        {
            int firstElement = -1;
            int left = 0;
            int right = nums.Length -1;
            while(left<=right){
            int midValue = left + (right - left)/2;
            if(nums[midValue]>=target)
            {
             if(nums[midValue] == target) 
                 firstElement = midValue; 
                right = midValue - 1;
            }else {
                left = midValue +1;
            }    
            }
            return firstElement;
        }
        
        public int findLast(int[] nums, int target,int first)
        {
            int lastElement = first;
            int left = first;
            int right = nums.Length -1;
            while(left<=right)
            {
                int midValue = left + (right - left)/2;
                if(nums[midValue]<=target)
                {
                    if(nums[midValue]==target)
                        lastElement = midValue;
                    left = midValue + 1;
                }else{
                    right = midValue - 1;
                }
            }
            return lastElement;
        }
}