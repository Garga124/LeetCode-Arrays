public class Solution {
    public bool IsValid(string s) {
        Stack <char> stack =  new Stack <char>();
        foreach(char currentCharacter in s.ToCharArray()){
           // Console.Out.WriteLine("Stack.Value" + stack.Peek());
            if(currentCharacter == '(' ||currentCharacter == '['||currentCharacter == '{'){
                stack.Push(currentCharacter);
            } else if (currentCharacter == ')' && stack.Any() && stack.Peek() == '('){
                stack.Pop();
            } else if (currentCharacter == '}' && stack.Any() && stack.Peek() == '{'){
                stack.Pop();
            }else if (currentCharacter == ']' && stack.Any() && stack.Peek() == '['){
                stack.Pop();
            } else{
                return false;
            }
        }
        return !stack.Any();
        
    }
}