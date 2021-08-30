//Time Compelxity : O(2n)=>O(n)
//Space Complexity : O(N)
public class Solution {
    public int[] FindBuildings(int[] heights) {
        if(heights.Length == 0 || heights == null)
            return heights;
        List <int> outputArray = new List<int>();
        
        int tallestBuilding = 0;
        for(int j = heights.Length-1;j>=0;j--)
        {
            if(heights[j]>tallestBuilding){
            tallestBuilding = heights[j];
                outputArray.Add(j);
            }
            
        }
        
        int index = 0;
        int size = outputArray.Count;
        int[] result = new int[size];
        for(int i = size-1; i>=0;i-- ){
            result[index++] = outputArray[i];
        }
        return result;
        
    }
}