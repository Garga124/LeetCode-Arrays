//TC: O(logN)
//Space Complexity : O(1);
public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        int n = arr.Length;
        int left = 0;
        int right = n-1;
        int missing = Compute(arr[right],n);
        while(left<=right){
            int mid = left + (right-left)/2;
            missing = Compute(arr[mid],mid+1);
            if(missing>=k){
                right = mid -1;
            }else{
                left = mid +1;
            }
            
        }
        
        if(right == -1){
            return k;
        }
        return arr[right] + k - Compute(arr[right],right+1);
        
    }
    
    public int Compute(int actual, int expected){
        return actual - expected;
    }
}