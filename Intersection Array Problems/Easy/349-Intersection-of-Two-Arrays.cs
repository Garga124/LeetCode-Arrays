public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> setContainingNums1 = new HashSet<int>();
        HashSet<int> intersectionNums = new HashSet<int>();
        for(int i =0;i<nums1.Length;i++){
            setContainingNums1.Add(nums1[i]);
        }
        
        for(int i =0;i<nums2.Length;i++){
            if(setContainingNums1.Contains(nums2[i]))
            intersectionNums.Add(nums2[i]);
        }
        int[] result = new int[intersectionNums.Count];
        int index = 0;
        foreach (int i in intersectionNums)
    {
        result[index++] = i;
    }
        
        return result;
    }
}