public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
          int max = 0;
        int i = 0;
        int j = 0;
        int [] countMap = new int[256];
        HashSet <char> setOfChars = new HashSet <char>();
        while(i<s.Length){
            char currentCharacter = s[i];
            countMap[currentCharacter]++;
             setOfChars.Add(currentCharacter);
               
            if(setOfChars.Count>2){
                 max = Math.Max(max,i-j);
                  while(setOfChars.Count>2){
                char elementToRemove = s[j];
               if (--countMap[elementToRemove] == 0) {
                            setOfChars.Remove(elementToRemove);
                        }
                        j++;
                
                Console.Out.WriteLine("current set of chars"+ setOfChars.Count +":s[j];"+s[j]);
                
                //setOfChars.Remove(elementToRemove);
                //j++;
            }
            }
          
                i++;
           
        }
        if(j<s.Length){
              max = Math.Max(max,i-j);
        }
        return max;
    }
}