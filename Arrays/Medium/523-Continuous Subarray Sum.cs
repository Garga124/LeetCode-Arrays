//Time Complexity :O(N)
//Space Complexity:O(N)
public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        Dictionary <int, int> map = new Dictionary <int, int>();
        int sum =0;
        for(int i = 0;i<nums.Length;i++){
            sum += nums[i];
            sum %= k;
            if(sum == 0 && i>0){
                return true;
            }
            if(map.ContainsKey(sum) && i-map[sum]>1){
                return true;
            }else if(!map.ContainsKey(sum)){
                map.Add(sum,i);
            }
            
        }
        return false;
    }
}

