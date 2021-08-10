public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
     IList<string> result = new List<string>();
        int i =0;
        int n = words.Length;
        while(i<n){
            int j = i+1;
            int lineLength = words[i].Length;
            while(j<n &&(lineLength + words[j].Length + (j-i-1))< maxWidth ){
              lineLength += words[j].Length;
                j++;
                
            }
            int diff = maxWidth - lineLength;
            int numberOfWords = j-i;
            if(numberOfWords == 1 || j>=n){
                //If j pointer is at very last line or the line has only one word that means that we are going to have left justify
                Console.Out.WriteLine("LeftJustifytocall");
                result.Add(leftJustify(words,diff,i,j));
            }else{
                Console.Out.WriteLine("MiddleJustify to call" + i);
                result.Add(middleJustify(words,diff,i,j));
            }
            i = j; 
        }
     return result;
        
    }
    
     private string middleJustify(string[] words, int diff, int i ,int j){
        int spacesNeeded = j - i-1;
         int spaces = diff/spacesNeeded;
         int extraSpaces = diff %spacesNeeded;
         
         Console.Out.WriteLine("Spaces" + spaces);
             Console.Out.WriteLine("ExtraSpaces" + extraSpaces);
        // Console.Out.WriteLine("VAlue of extra space expression" + (extraSpaces-- > 0?1:0));
        StringBuilder result = new StringBuilder(words[i]);
        for(int k = i+1;k<j;++k){
            int spacesToApply = spaces + (extraSpaces-- > 0?1:0);
           // Console.Out.WriteLine("Total Spaces" + spaces);
             //Console.Out.WriteLine("Spaces repeat" + " ".Length*(spacesToApply));
            
            result.AppendJoin(" " , new string[spacesToApply+1]).ToString();
            result.Append(words[k]);
               // + words[k]);
        }
        return result.ToString();
    }
    
    
    
    private string leftJustify(string[] words, int diff, int i ,int j){
        int spacesOnRight = diff -(j - i-1);
        StringBuilder result = new StringBuilder(words[i]);
        for(int k = i+1;k<j;k++){
            result.Append(" "+words[k]);
        }
        result.AppendJoin(" ", new string[spacesOnRight +1]).ToString();
        return result.ToString();
    }
}