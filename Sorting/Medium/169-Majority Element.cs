//TC:O(N)
SC: O(1)
public class Solution {
    public int MajorityElement(int[] nums) {
                bool isMajorElementPresent = false;
        int res = nums[0];
        int count = 1;
        for(int i =0;i<nums.Length;i++){
           if(res == nums[i]) 
               ++count ;
            else
                --count;
            if(count == 0){
                res = nums[i];
                count =1;
            }
                
        }
        //Console.Out.WriteLine("res"+ res);
        /*if((nums.Length%2 == 0 && res > target )||(nums.Length%2 != 0 && res >= target)){
            isMajorElementPresent = true;
        }
        return isMajorElementPresent;*/
        return res;
    }
}