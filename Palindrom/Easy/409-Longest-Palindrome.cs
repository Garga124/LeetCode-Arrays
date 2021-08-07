public class Solution {
    public int LongestPalindrome(string s) {
        int[] char_counts = new int[128];
        foreach(char c in s.ToCharArray()){
            char_counts[c]++;
        }
        
        int result =0;
        foreach(int item in char_counts){
            result += item /2*2;
            if(result %2 == 0 && item %2 ==1){
                result +=1;
            }
        }
        return result;
    }
}