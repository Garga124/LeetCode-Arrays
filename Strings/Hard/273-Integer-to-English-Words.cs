public class Solution {
    List<String> v1 = new List<String> (new string []{"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"});
         List<String> v2 = new List<String>(new string[]{"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"});

    public string NumberToWords(int num) {
        String res = convertHundred(num % 1000);
            List<String> unit = new List<String>(new string[] {"Thousand", "Million", "Billion", "Trillion"});
            for (int i = 0; i < 3; ++i) {
                num /= 1000;
                res = num % 1000 != 0 ? convertHundred(num % 1000) + " " + unit[i] + " " + res : res;
            }

            res = res.Trim();

            return string.IsNullOrEmpty(res) ? "Zero" : res;
    }
    
    
    public string convertHundred(int num){
        string res;
        int a = num/100;
        int b = num %100;
        int c = num %10;
        res = b<20?v1[b]:v2[b/10] + (c!=0? " "+v1[c]: " ");
        Console.Out.WriteLine("Valus of  a is"+ a);
        Console.Out.WriteLine("Valus of  b is"+ b);
        Console.Out.WriteLine("Valus of  c is"+ c);
        if(a>0){
            res = v1[a] + " Hundred"+(b!=0?" "+ res:"");
        }
        Console.Out.WriteLine("Result is"+ res);
        return res;
    }
}