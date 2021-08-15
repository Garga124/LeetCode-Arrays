public class Solution {
    public int Calculate(string s) {
        if(s == null || s.Length ==0)
            return 0;
        char op = '+';
        int curr = 0;
        int sum = 0;
        int last = 0;
        //Stack <int> stack = new Stack<int>();
        for(int i =0;i<s.Length;i++){
           if(Char.IsDigit(s[i])){
               curr = curr * 10 +s[i] -'0';
           }
            
            if(!Char.IsDigit(s[i]) && s[i] != ' ' || i == s.Length -1){
                if(op == '+'){
                    sum+=last;
                    last = curr;
                    //stack.Push(curr);
                }else if(op == '-'){
                    sum+= last;
                    last = -curr;
                   // stack.Push(curr*(-1));
                }else if(op == '*'){
                    last = last * curr;
                    //stack.Push(stack.Pop()*curr);
                }else if (op == '/'){
                    last = last /curr;
                    //stack.Push(stack.Pop()/curr);
                }
                op = s[i];
                curr = 0;
            }
        }
        sum += last;
        /*int sum = 0;
        while(stack.Any()){
            sum +=stack.Pop();
        }*/
        return sum;
        
    }
}