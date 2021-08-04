#760. Find Anagram Mappings
public class Solution {
    public int[] AnagramMappings(int[] nums1, int[] nums2) {
        
         int [] result = new int [nums1.Length];
        Dictionary<int,int>  map = new Dictionary<int,int>();
        for( int i = 0; i < nums2.Length; i++){
            if(!map.ContainsKey(nums2[i])){
                 Console.Out.WriteLine("Nums2[i]:"+ nums2[i]);
                //map.Add(nums2[i],new List<int>());
                map.Add(nums2[i],i);
            }/*
            else{
                map.Add(nums2[i]);
            }*/
        }

        for( int i = 0; i < nums1.Length; i++){
            //Console.Out.WriteLine("asdddddddd"+ map[nums1[i]].Remove(map[nums1[i]].Count() - 1));
            map.TryGetValue(nums1[i],out result[i]);
            //    Remove(map[nums1[i]].Count() - 1);
                
                //.Remove(map[nums1[i]].Count() - 1);
        }
return result;
    }
}