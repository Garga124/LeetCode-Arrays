public class Solution {
    public bool ValidPalindrome(string s) {
        int i =0;
        int j = s.Length -1;
        while(i<=j){
            if(s[i]!=s[j]){
                //Call Helper method
                return helperMethod(s,i+1,j)|| helperMethod(s,i,j-1);
            }
            i++;
            j--;
            
        }
        return true;
    }
    
    public bool helperMethod(string s,int i ,int j){
        while(i<=j){
            if(s[i]!=s[j]){
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}