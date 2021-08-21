public class Solution {
    public int MyAtoi(string s) {
        int index = 0;
        int sign = 1;
        int total = 0;
        //Empty String Check
        if(s.Length ==0){
            return 0;
        }
        //Remove Spaces
        while(index<s.Length && s[index]==' '){
            index ++;
        }
        //Handle Signs 
        if(index<s.Length && (s[index] == '+' ||s[index] == '-') ){
            sign = s[index] == '+'?1:-1;
            index ++;
        }
        //Convert numbers and avoid overflow
        while(index<s.Length){
            int digit = s[index] -'0';
            if(digit<0 || digit>9){
                break;
            }
            //Check if the total will be overflow after 10 times and add digit
            if(Int32.MaxValue/10<total|| Int32.MaxValue/10 == total && Int32.MaxValue %10 <digit){
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }
            
            total = 10 * total + digit;
            index++;
                
        }
        return total * sign;
    }
}