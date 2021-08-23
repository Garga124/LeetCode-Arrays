//Time Complexity O(M+N)
//Space Complexity O(N)
public class Solution {
    public string MinWindow(string s, string t) {
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)){
            return "";
            
        }
        Dictionary <Char, int> tMap = new Dictionary<Char, int>();
        for(int k =0;k<t.Length;k++){
            if(!tMap.ContainsKey(t[k])){
            tMap.Add(t[k],1);
        }else{
            tMap[t[k]] = tMap[t[k]]+ 1;
        }
        }
        int count = t.Length;
        int left = 0;
        int right = s.Length -1;
        int minSize = s.Length;
        int i = 0;
        int j =0;
        bool found = false;
       // Console.Out.WriteLine("Map Count"+ t.Length);
        while(j<s.Length){
            char CharAtJ = s[j++];
            if(tMap.ContainsKey(CharAtJ)){
                tMap[CharAtJ] = tMap[CharAtJ] - 1;
                Console.Out.WriteLine("tMap[CharAtJ] :" +tMap[CharAtJ] );
                if(tMap[CharAtJ] >= 0){
                       Console.Out.WriteLine("Value of Count"+ count);
                    count = count - 1;
                }
            }
        
    
        if(count >0)
            continue;
        while(count ==0){
             char charAti = s[i];
            i++;
            if(tMap.ContainsKey(charAti)){
                tMap[charAti] = tMap[charAti] +1;
                if(tMap[charAti] > 0){
                    count = count +1;
                }
                
            }
        }
        
        if((j-i)<minSize){
            
             Console.Out.WriteLine("i: " + i+ " j:"+j + "");
            left = i;
            right = j;
            minSize = j-i+1;
            found = true;
        }
    }
        
        foreach(var item in tMap.Keys){
            Console.Out.WriteLine("Values inside map: " + item);
        }
        Console.Out.WriteLine("S Length"+ s.Length);
        return !found ?"":s.Substring(left-1,minSize);
    }
    
   
   // return !found ?"":s.Substring(left-1,right);
}