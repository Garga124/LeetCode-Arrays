public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals.Length<=1){
            return intervals;
        }
        //Intervals need to be sorted
        Comparer<int> comparer = Comparer<int>.Default;
        Array.Sort<int[]>(intervals, (x,y) => comparer.Compare(x[0],y[0])); 
        //Define output array list 
        List<int[]> output_array = new List<int[]>();
        
        int[] currentInterval = intervals[0]; // [1,3];
        output_array.Add(currentInterval);
        
        foreach(int[] interval in intervals){
            int current_begin = currentInterval[0];
            int current_end = currentInterval[1];
            int next_begin = interval[0];
            int next_end = interval[1];
        
            if(current_end >=next_begin){
                //Means there is overlap, then update current interval ending values which is already in the output array
                currentInterval[1] = Math.Max(current_end,next_end);
            }else{
                currentInterval =  interval;
                output_array.Add(currentInterval);
            }
        }
        
        
       // output_array = intervals;
      //  return output_array.ToArray(new int[output_array.Count][]);
        return output_array.Select(a =>a.ToArray()).ToArray();  
    }
}