//Time Complexity : O(n), space O(1)
public class Solution {
    public int CountBinarySubstrings(string s) {
        int count =0;
        int i = 1;
        int prev =0;
        int curr = 1;
        while(i<s.Length){
            //If there is change in character 
            if (s[i-1]!=s[i]){
                count +=Math.Min(prev,curr);
                prev = curr;
                curr = 1;
            }else{
                curr++;
            }
            i++;
        }
       return count+= Math.Min(prev,curr);
    }
}