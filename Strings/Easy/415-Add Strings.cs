//Time Complexity : O (N) where N is the bigger length between num1 and num 2
//Space Complexity : O(n) as we are defining a string builder of length N

public class Solution {
    public string AddStrings(string num1, string num2) {
      int i = num1.Length - 1;
        int j = num2.Length -1;
        int carry = 0;
        StringBuilder result = new StringBuilder();
        while(i>-1 || j>-1){
            int dig1 = i>-1?num1[i] - '0':0;
            int dig2 = j>-1?num2[j] - '0':0;
            int sum = dig1 + dig2 + carry;
            result.Append(sum %10);
            carry = sum/10;
          i--;
            j--;
        }
        if(carry ==1){
            result.Append(1);
        }
       return new string(result.ToString().Reverse().ToArray());
      // return result.Reverse().ToString();
    }
}