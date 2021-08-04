#438. Find All Anagrams in a String

/* Algorithm
*  Initialize two arrats of Size 26 which will store the character count for both the strings
* Store the character count of string p into array pArray
* Store the character count for sub-string of s, of length of  p-1 into sArray
* Iterate over the rest of string s one character at time
*   increment count of character at current index
*   check if the pArray is equal to sArray, if yes then add start index of current window to result list    
*   Decrement occurrence of character at start index of window in string s
* Return result
*/  

public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
     //Approach :Slidding Window    
        IList<int> indices = new List<int>();
        if(s==null ||p==null||s.Length <p.Length){
            return indices;
        }
            //Initialize 2 arrays of Size 26 and store the character count for both the strings
        int[] sArray = new int[26];
        int[] pArray = new int[26];
        for(int i=0;i<p.Length;i++){
            sArray[s[i]-'a']++;
            pArray[p[i]-'a']++;
        }
        if(anagram(sArray,pArray)){
            indices.Add(0);
        }
        
        for(int i =p.Length; i<s.Length;i++){
           // Console.Out.WriteLine("s[i -pArray.Length]" +s[i -pArray.Length]);
            char previousCharacter = s[i - p.Length];
            char currentCharacter = s[i];
            sArray[previousCharacter-'a']--;
            sArray[currentCharacter-'a']++;
            if(anagram(sArray,pArray)){
            indices.Add(i - p.Length+1);
        }
        }
            
          return indices;
    }
    
    public bool anagram(int[] sArray, int[] pArray){
        for(int i =0;i<26;i++){
            if(sArray[i]!=pArray[i])
                return false;
        }
        return true;
    }
    
}


