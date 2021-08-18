public class Solution {
    public string DecodeString(string s) {
        Stack<int> numStack = new Stack<int>();
        Stack<StringBuilder> strStack = new Stack<StringBuilder>();
        int num =0;
        StringBuilder str = new StringBuilder();
        foreach(char c in s.ToCharArray()){
            if(c>='0' && c<='9'){ //Character.IsDigit(c)
                num = num * 10 + c-'0';
            }else if(c=='['){
                strStack.Push(str);
                str = new StringBuilder();
               // Console.Out.WriteLine("num"+num);
                numStack.Push(num);
                num = 0;
                
            }else if(c==']'){
                StringBuilder temp = str;
                str = strStack.Pop();
                int count = numStack.Pop();
               // Console.Out.WriteLine("Count"+count);
                while(count-->0){
                    str.Append(temp);
                }
                
            }else{
                str.Append(c);
            }
        }
        return str.ToString();
    }
}