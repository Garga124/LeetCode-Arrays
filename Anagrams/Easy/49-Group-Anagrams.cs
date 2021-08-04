#49. Group Anagrams
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<String>> groupedAnagrames = new List<IList<String>>();
        Dictionary <String, IList<String>> hashMap = new Dictionary <String, IList<String>>();
        foreach( string current in strs){
            char[] characters = current.ToCharArray();
            Array.Sort(characters);
            String sorted = new String(characters);
            if(!hashMap.ContainsKey(sorted)){
                hashMap.Add(sorted,new List<String>());
            }
            hashMap[sorted].Add(current);
        }
       return hashMap.Select(one => one.Value).ToList();
        //return groupedAnagrames;
    }
}