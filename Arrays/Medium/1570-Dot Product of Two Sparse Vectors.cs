/*


Time complexity: O(n) for creating the <index, value> pair for non-zero values;O(L+L2) for calculating the dot product.

Space complexity:O(L) for creating the <index, value> pairs for non-zero values.O(1) for calculating the dot product.

*/

public class SparseVector {
    List<int[]> pairs;
    public SparseVector(int[] nums) {
        pairs = new List<int[]>();
        for(int i =0;i<nums.Length;i++){
            if(nums[i]!=0){
                pairs.Add(new int[]{i,nums[i]});
            }
        }
    }
    
    // Return the dotProduct of two sparse vectors
    public int DotProduct(SparseVector vec) {
        int result = 0;
        int p = 0;
        int q = 0;
        while(p<pairs.Count && q<vec.pairs.Count){
            if(pairs[p][0] == vec.pairs[q][0]){
                result +=pairs[p][1] * vec.pairs[q][1];
                p++;
                q++;
            }else if(pairs[p][0] > vec.pairs[q][0]){
                q++;
            }else{
                p++;
            }
        }
        return result;
    }
}

// Your SparseVector object will be instantiated and called as such:
// SparseVector v1 = new SparseVector(nums1);
// SparseVector v2 = new SparseVector(nums2);
// int ans = v1.DotProduct(v2);