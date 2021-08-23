//Time Complexity O(n)
//Space Complexity O(1)
public class Solution {
    public void NextPermutation(int[] nums) {
        int i = nums.Length-2;
        while(i>=0 && nums[i]>=nums[i+1]){
            i--;
        }
        if(i>=0){
             int j = nums.Length -1;
        while(j>=0 && nums[j]<=nums[i]){
            j--;
        }
            
       swap(nums,i,j);
        }
        reverse(nums,i+1);
    }
    
    public void swap(int[] nums,int num1, int num2){
        int temp = nums[num1];
        nums[num1] = nums[num2];
        nums[num2] = temp;
    }
    public void reverse(int[] nums, int start){
         
        int end = nums.Length -1;
        Console.Out.WriteLine("Start"+ start + "End"+ end);
        
        while(start<=end){
            swap(nums,start,end);
            start ++;
            end --;
        }
       
    }
}