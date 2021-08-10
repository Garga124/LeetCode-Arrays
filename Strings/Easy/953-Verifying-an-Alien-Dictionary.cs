public class Solution {
    public int[] char_map ;
    public bool IsAlienSorted(string[] words, string order) {
        char_map = new int[26];
        for(int i =0;i<order.Length;i++){
            char_map[order[i] - 'a'] = i;
        }
        
        //Loop on the words
        for(int i =1;i<words.Length;i++){
            if(compare(words[i-1],words[i])>0){
                return false;
            }
        }
        return true;
        
    }
    
    public int compare(string word1, string word2){
        int i =0;
        int j =0;
        int compare = 0;
        while(i<word1.Length && j<word2.Length && compare == 0){
            
            compare = char_map[word1[i] - 'a'] - char_map[word2[j] - 'a'];
            i++;
            j++;
        }
        
        if(compare ==0)
        {
            return word1.Length - word2.Length;
        } else{
           // Console.Out.WriteLine();
            return compare;
        }
    }
}