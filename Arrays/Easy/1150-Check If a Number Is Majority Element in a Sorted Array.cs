//TC : O(n)
//SC: O(1)
public class Solution {
    public bool IsMajorityElement(int[] nums, int target) {
      int cnt=0;
        foreach(var num in nums)
        {
            if(num==target)
                cnt++;
            else
                cnt--;
        }
        return cnt>0;
    }
}