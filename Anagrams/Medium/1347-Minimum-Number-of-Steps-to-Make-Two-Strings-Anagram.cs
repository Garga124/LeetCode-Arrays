#1347. Minimum Number of Steps to Make Two Strings Anagram
public class Solution {
    public int MinSteps(string s, string t) {
     int noSteps = 0;
     Dictionary <char,int> sDictionary = new Dictionary <char,int>();
        Dictionary <char,int> tDictionary = new Dictionary <char,int>();
        if(s.Length == 1 && s[0]==t[0])
            return 0;
        for(int i =0 ;i<s.Length;i++)
        {
            if(!sDictionary.ContainsKey(s[i])){
            sDictionary.Add(s[i],1);
            }else{
                int occurance = sDictionary[s[i]];
                sDictionary[s[i]] = occurance + 1;
            }
            //Console.Out.WriteLine("This is the value of SDictionary"+ sDictionary[s[i]]);
        }
        
        for(int i=0;i<t.Length;i++)
        {
            if(sDictionary.ContainsKey(t[i]) && sDictionary[t[i]] !=0 ){
              //  Console.Out.WriteLine("This is the value of SDictionary"+ sDictionary[t[i]]);
                int occurance = sDictionary[t[i]];
                sDictionary[t[i]] = occurance - 1;
            }else{
                noSteps++;
            }
        }
        
        return noSteps;
        
    }
}