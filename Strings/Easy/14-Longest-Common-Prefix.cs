public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder result = new StringBuilder();
        /*Brute Force Algorithn
        
        if(strs.Length == 1){
            return strs[0];
        }
        
       Array.Sort(strs);
        
        for(int i = 0; i<strs[0].Length; i++){
            bool match = false;
            for(int j = 1;j<strs.Length;j++){
                if(strs[j][i] == strs[0][i]){
                    match = true;
                    //result.Append(strs[j][i]);
                    Console.Out.WriteLine("result:"+result.ToString());
                }else{
                     match = false;
                }
                
            }
            if(!match)
            break;
            result.Append(strs[0][i]);
           
        }
        
        return result.ToString();
     */   
        if(strs.Length ==0)
            return "";
        String prefix = strs[0];
        for(int i =1;i<strs.Length;i++){
            while(strs[i].IndexOf(prefix)!=0){
                prefix = prefix.Substring(0,prefix.Length -1);
            }
        }
        return prefix;
    }
}