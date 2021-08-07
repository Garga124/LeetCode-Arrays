public class Solution {
    public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3) {
        IList<int> result = new List<int>();
        int i = 0;
        int j = 0;
        int k = 0;
        while(i<arr1.Length && j<arr2.Length && k<arr3.Length){
            if(arr1[i] == arr2[j] && arr1[i] == arr3[k]){
                result.Add(arr1[i]);
                i++;
                j++;
                k++;
            } else if(arr1[i]<arr2[j]){
                i++;
            } else if (arr2[j]<arr3[k]){
                j++;
            } else {
                k++;
            }
            
        }
        
        return result;
        
    }
}