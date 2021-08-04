#242. Valid Anagram
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
            return false;
        
        
        int[] letters = new int[26];
        char[] arr1 = s.ToCharArray();
        char[] arr2 = t.ToCharArray();
        for(int i=0;i<arr1.Length;i++){
            // Console.WriteLine("1Array"+ letters[i]);
            letters[arr1[i]-'a']++;
           
        }
        for(int i=0;i<arr2.Length;i++){
             //Console.WriteLine("2Array"+ letters[i]);
            letters[arr2[i]-'a']--;
             
        }
        
        foreach(int letter in letters){
            //Console.WriteLine(letter);
            if(letter != 0)
                return false;
        }
        return true;
        
    }
}