//Time Complexity : O(n)
//Space Complexity : O(1)
public class Solution {
    public bool IsOneEditDistance(string s, string t) {
        int n = s.Length;
        int m = t.Length;
        if(n>m)
            return IsOneEditDistance(t,s);
        for(int i =0;i<n;i++){
            if(s[i]!=t[i])
            {
            if(n == m)
            {
                return s.Substring(i+1).Equals(t.Substring(i+1));
            }
                if(n<m)
            {
                    return s.Substring(i).Equals(t.Substring(i+1));
            }else
                 return s.Substring(i+1).Equals(t.Substring(i));   
        }
        }
        return (n+1 == m);
    }
  
                                    
}