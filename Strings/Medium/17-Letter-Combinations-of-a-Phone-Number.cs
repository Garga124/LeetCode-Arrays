public class Solution {
    public IList<string> LetterCombinations(string digits) {
        IList<string> ans = new List<string>();
        if(String.IsNullOrEmpty(digits))
            return ans;
        string[] mapping = new string[]{"0","1","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
        ans.Add("");
        for(int i =0;i<digits.Length;i++){
            List<string> backup = new List<string>();
           foreach(char ch in mapping[digits[i] -'0']){
               foreach(string answer in ans ){
                   backup.Add(answer + ch);
               }
            
           }
               ans = backup;
        }
        return ans;
        
    }
}