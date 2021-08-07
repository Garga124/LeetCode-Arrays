public class Solution {
    //time Complexity : O(m+ n)
    //Space Complexisty : O(m+n)
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
        int i = 0;
        int j = 0;

        List<int[]> result = new List<int[]>();
        while(i<firstList.Length && j<secondList.Length){
            int max = Math.Max(firstList[i][0],secondList[j][0]);
            int min = Math.Min(firstList[i][1],secondList[j][1]);
            if(max<=min){
                result.Add(new int[]{max,min});
            }
            if(firstList[i][1]<secondList[j][1]){
                i++;
            }else{
                j++;
            }
                
        }
        
        return result.ToArray();
    }
}