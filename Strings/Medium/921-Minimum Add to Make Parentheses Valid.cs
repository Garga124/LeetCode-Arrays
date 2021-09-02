public class Solution {
    public int MinAddToMakeValid(string s) {
          StringBuilder sb = new StringBuilder();
        int open = 0;
        int count = 0;
        foreach(char ch in s.ToCharArray()){
            if(ch == '('){
                open ++;
            } else if(--open <0){
                open++;
                count++;
            }
        }
    return count + open;
    }
}