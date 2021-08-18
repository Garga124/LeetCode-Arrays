public class Solution {
    //Time Complexity = O(n)
    //Space Complexity = O(n)
    public string RemoveDuplicates(string s, int k) {
     
        Stack<int[]> main = new Stack<int[]>();
        foreach(char c in s.ToCharArray()){
            if(main.Any() && main.Peek()[0] == c){
                main.Peek()[1]++;
            } else{
                main.Push(new int[]{c,1});
            }
            if(main.Peek()[1] == k){
                main.Pop();
            }
        }
        
        StringBuilder sb = new StringBuilder();
        while(main.Any()){
            int[] top = main.Pop();
            while(top[1] --> 0){
                sb.Append((char) top[0]);
            }
        }
        return new string(sb.ToString().Reverse().ToArray());
        
        //Recusrsive Solution but below solution threw error of time limit exceed
        /*
        int count = 1;
        for(int i =1;i<s.Length;i++){
            if(s[i] == s[i-1]){
                count ++;
            }else{
                count = 1;
            }
            if(count == k){
                string reduced = s.Substring(0,i-k+1) + s.Substring(i+1);
                return RemoveDuplicates(reduced,k);
            }
        }
        return s;
        */
        //Incorrect solution : TODO : Bug fix in progress
        /*StringBuilder sb= new StringBuilder();
        List<int> eachCharacterCount = new List<int>();
        int length = s.Length;
        for (int i = 0; i < length; i++) {
            
            
            
            int curLength = sb.Length;
            char c = s[i];
            int curCount = 1;
            if(curLength >0)
            Console.Out.WriteLine("Current Character " + c + "  sb[sb[curLength - 1]]"+ sb[curLength - 1] + "Each Characyer Count:"+ (eachCharacterCount[curLength - 1] + 1));
            if (curLength > 0 && c == sb[curLength - 1])
                curCount = eachCharacterCount[curLength - 1] + 1;
            if (curCount == k) {
                int startIndex = curLength - k + 1;
                sb.Remove(startIndex, k -1);
                for (int j = curLength - 1; j >=startIndex; j--){
                    Console.Out.WriteLine("Before removal Character count is"+ eachCharacterCount[j]);
                    eachCharacterCount.Remove(j);
                    
                }
            } else {
                sb.Append(c);
                eachCharacterCount.Add(curCount);
            }
        }

        return sb.ToString();*/
        
    }
}

/*
class Solution {
    public String removeDuplicates(String s, int k) {
        StringBuffer sb = new StringBuffer();
        List<Integer> duplicatesCounts = new ArrayList<Integer>();
        int length = s.length();
        for (int i = 0; i < length; i++) {
            int curLength = sb.length();
            char c = s.charAt(i);
            int curCount = 1;
            if (curLength > 0 && c == sb.charAt(curLength - 1))
                curCount = duplicatesCounts.get(curLength - 1) + 1;
            if (curCount == k) {
                int startIndex = curLength - k + 1;
                sb.delete(startIndex, curLength);
                for (int j = curLength - 1; j >= startIndex; j--)
                    duplicatesCounts.remove(j);
            } else {
                sb.append(c);
                duplicatesCounts.add(curCount);
            }
        }
        return sb.toString();
    }
}*/