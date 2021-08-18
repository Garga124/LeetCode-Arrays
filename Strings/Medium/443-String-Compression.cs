//Time Complexity : Run Time is O(n) where n is number of characters and space Complexity (1)
public class Solution {
    public int Compress(char[] chars) {
        int index =0;
        int i = 0;
        while(i<chars.Length){
            int j = i;
            while(j<chars.Length && chars[j] == chars[i]){
                j++;
            }
            chars[index++] = chars[i];
            if(j-i>1){
                string count = j-i+ "";
                foreach(char c in count.ToCharArray()){
                    chars[index++] = c;
                }
            }
            i = j;
        }
        
        return index;
    }
}