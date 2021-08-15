public class Solution {
    public int Calculate(string s) {
        int sum = 0;
        Stack<int> sk = new Stack<int>();
        int sign = 1;//1 for '+' and -1 for '-'
        int num = 0;
        int n = s.Length;
        for(int i =0;i<s.Length;i++){
            char c = s[i];
            Console.Out.WriteLine("Char c" + c +"I Value"+ i);
            if(c>='0'){
               
                 num = 10 * num + (c - '0');
                // sum += sign * num;
            } else if(c=='+' || c=='-'){
               // Console.Out.WriteLine("Character"+ c);
                sum += num * sign;
                num = 0;
                sign = c=='+'?1:-1;
            } else if (c=='('){
                sk.Push(sum);
                sk.Push(sign);
                sum = 0;
                sign = 1;
                //Do with Stack
            }else if(c==')'){
                //Do pop
                sum +=num * sign;
                sum *= sk.Pop();
                sum += sk.Pop();
                num = 0;
                sign = 1;
            }
            
           // sum +=num * sign;
            Console.Out.WriteLine("Sum Value" + sum);
        }
        sum += sign * num;
        
        return sum;
    }
}