public class Solution {
    public int MinFlipsMonoIncr(string s) {
        int zero = 0;
        int one = 0;
        int i =0;
        int n = s.Length;
        
        //Ignore all the first few zeros.
        while(i<s.Length && s[i] == '0'){
            i++;
        }
        
        for(;i<n;i++){
            char ch = s[i];
            if(ch == '0'){
                zero ++; 
            }else{
                one ++;
            }
            if(zero >one){
                zero = one;
            }
            
        }
        return zero;
        
    }
}