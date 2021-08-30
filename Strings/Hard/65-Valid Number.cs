//Time Complexity : O(N)
//Space Complexity : O (1)
public class Solution {
    public bool IsNumber(string s) {
        if(s == null)
            return false;
        s = s.Trim().ToLower();
        Console.Out.WriteLine("S Value"+ s);
        bool digitSeen = false;
        bool decimalSeen = false;
        bool eSeen = false;
       // Console.Out.WriteLine("S.LEngth is "+ s.Length);
        for(int i = 0;i<s.Length;i++){
            char c = s[i];
          //  Console.Out.WriteLine("Character is "+ c);
            if(Char.IsDigit(s[i])){
                digitSeen = true;
               // Console.Out.WriteLine("Digit Seen"+ digitSeen);
            }else if(c == '.'){
                 Console.Out.WriteLine("Decimal Seen"+ decimalSeen);
                if(decimalSeen || eSeen)
                    return false;
                else
                decimalSeen = true;
            }else if (c == 'e'){
                if(i==s.Length-1 || eSeen || !digitSeen)
                    return false;
                else
                    eSeen = true;
            }else if (c == '+' || c== '-'){
               
                if(i != 0 || i == s.Length -1)
                {
                     
                   if(i != 0){
                       if(s[i-1] != 'e' ||i == s.Length -1){
                          
                           return false;
                       }
                   }else{
                       Console.Out.WriteLine("I am in else");
                      return false;   
                   }
                }
            } else{
               
                return false;
            }
        }
        Console.Out.WriteLine("I am out of loop");
        
        return digitSeen;
    }
    
}