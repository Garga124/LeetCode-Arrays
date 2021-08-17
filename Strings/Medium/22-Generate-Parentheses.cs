 
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> output_arr = new List<string>();
        backtrack(output_arr ,"",0,0,n);
        return output_arr; 
        
    }
    
    public void backtrack(IList<string> output_arr, string curr, int open, int close ,int max ){
        if(curr.Length == max*2 ){
            //The we are going to add our string into our output array
            output_arr.Add(curr);
        }
        
        if(open<max){
            backtrack(output_arr,curr + "(",open+1,close,max);
        }
        if(close<open){
            backtrack(output_arr,curr + ")",open,close+1,max);
        }
    }
    
    
}