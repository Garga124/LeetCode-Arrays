//Time O(N), Space Complexity O(N)
public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> stack = new Stack<char>();
        if(String.IsNullOrEmpty(s))
        return "" ;
        for(int i = s.Length -1;i>=0;i--){
            if(!stack.Any() || stack.Peek() !=s[i])
                stack.Push(s[i]);
                else
                    stack.Pop();
        }
        StringBuilder sb = new StringBuilder();
        while(stack.Any()){
            sb.Append(stack.Pop());
        }
        return sb.ToString();
    }
}