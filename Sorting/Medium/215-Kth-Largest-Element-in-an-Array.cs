//Average Time Complexity is O(N)
//Space Complexity is O(N)
//Worst Case is O(N^2)

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        if(nums.Length==0){
            return 0;
        }
        
        return helper(nums,0,nums.Length-1,k);
        
    }
    
    public int helper(int[] nums, int left, int right, int k){
        int pivot = left;
        for(int i = left;i<right;i++){
            if(nums[i]<=nums[right]){
                swap(nums,pivot++,i);
            }
        }
         swap(nums,pivot,right);
        int count = right - pivot +1;
        if(count == k){
            return nums[pivot];
        }else if(count >k){
            return helper(nums,pivot+1,right,k);
        }
        return helper(nums, left,pivot-1,k-count);
    }
    
    public void swap(int[] nums , int l, int r){
       // Console.Out.WriteLine("I am called with left" + l);
        int temp = nums[l];
        nums[l] = nums[r];
        nums[r] = temp;
    }
}