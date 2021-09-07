public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        if(abbr.Length>word.Length){
            return false;
        }
        int wp = 0;
        int ap = 0;
        while(ap<abbr.Length){
            if(Char.IsDigit(abbr[ap])){
                if(abbr[ap] == '0'){
                    return false;
                }
                int[] toZoom = zoomZoom(abbr,ap);
                wp+=toZoom[0];
                ap+=toZoom[1];
            }else{
                if(wp>=word.Length || ap>=abbr.Length||word[wp]!=abbr[ap]){
                    return false;
                }
                ap++;
                wp++;
            }
        }
        
        if(wp!=word.Length){
            return false;
        }
        return true;
    }
    
    public int[] zoomZoom(string s, int p){
        int low = p;
        while(p<s.Length && Char.IsDigit(s[p])){
            p++;
        }
        int[] toZoom = new int[2];
        int lengthOfString = p-low;
       // Console.Out.WriteLine(s.Substring(low,p));
        toZoom[0] = Int32.Parse(s.Substring(low,lengthOfString));
        //toZoom[0] = 0;
        toZoom[1] = p-low;
        return toZoom;
    }
    
    
}