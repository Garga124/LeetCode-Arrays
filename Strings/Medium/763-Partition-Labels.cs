//Time Complexity :We are walking through the string twice one is to record last occurance of each characer and then we are actually walking through the string again entirely so, that's 2n where n is just a number of characters in string. As per Big o notation its O(n) as 2 is constant . In terms of space complexity, its a constant space no matters how big is our space of characters we are defining a space of 26 integers. it would be O(1)

public class Solution {
    public IList<int> PartitionLabels(string s) {
        IList<int> result = new List<int>();
        if(s.Length ==0)
            return result;
        int[] lastIndexes = new int[26];
        //Dictionary<char, int> lastIndexes = new Dictionary<char, int>();
        for(int k = 0;k<s.Length;k++){
               lastIndexes[s[k]-'a'] = k;
        }
        
        int i = 0;
        while(i<s.Length){
        int end =  lastIndexes[s[i]-'a'];
            int j = i;
            while(j!=end){
                end = Math.Max(end, lastIndexes[s[j++]-'a']);
            }
            result.Add(j-i+1);
            i = j+1;
        }
        
       
     return result; 
    }
}