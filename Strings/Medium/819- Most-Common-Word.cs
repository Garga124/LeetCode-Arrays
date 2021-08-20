using System.Text.RegularExpressions;
public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        HashSet<string> bannedWords = new HashSet<string>();
        foreach(string bWords in banned){
         bannedWords.Add(bWords);
        }
        
        Dictionary<string, int>counts = new Dictionary<string, int>();
        
      // Console.Out.WriteLine("After Regex implementation :"+ Regex.Replace(paragraph, @"[^0-9A-Za-z]", " ").ToLower());
        string tempStr = Regex.Replace(paragraph, @"[^0-9A-Za-z]", " ").ToLower();
         Console.Out.WriteLine("After Regex implementation :"+ Regex.Replace(tempStr, @"  ", " ").ToLower());
            
        foreach(string words in Regex.Replace(tempStr, @"  ", " ").ToLower().Split(" ")){
            
           if(!bannedWords.Contains(words)){
               Console.Out.WriteLine("Words "+ words);
               if(counts.ContainsKey(words)) {
                   
                   counts[words] = counts[words] +1;
               }else{
                   counts.Add(words, 0);
               }
               
                //counts.Add(words, counts.TryGetValue(words,out int value)? value+1: 0);
              // dictionary.TryGetValue(key, out value) ? value : defaultValue;
           }
        }
        string result = "";
       // Console.Out.WriteLine("sfdsfdsdf" + counts[result]);
        
        foreach(string key in counts.Keys){
            Console.Out.WriteLine("Key : "+key +" Value:  "+ counts[key]);
            if(result.Equals("") ||counts[key]>counts[result]){
               // Console.Out.WriteLine("Count Key:" + counts[key] + "Counts Result:"+ counts[result]);
                //Console.Out.WriteLine("Result is before replacement :" + result);
                result = key;
                //Console.Out.WriteLine("Result is now :" + result);
            }
        }
        
        return result;
        
    }
}