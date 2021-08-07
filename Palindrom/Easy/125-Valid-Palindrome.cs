public class Solution {
    public bool IsPalindrome(string s) {
        String fixedString = "";
        foreach(char c in s.ToCharArray()){
            if(char.IsLetterOrDigit(c)){
              //  Console.Out.WriteLine("Character Length :" +c);
                fixedString += c;
            }
        }
            fixedString = fixedString.ToLower();
            Console.Out.WriteLine("String Value" + fixedString);
            int i = 0;
            int j = fixedString.Length-1;
            while(i<=j){
             //   Console.Out.WriteLine("I Value :"+ fixedString[i+1]);
              //  Console.Out.WriteLine("J Value :"+ fixedString[j]);
                if(fixedString[i] != fixedString[j]){
                    return false;
                }
                i++;
                j--;
            }
          return true;
        }
          
}