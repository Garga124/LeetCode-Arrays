public class Solution {
//Time complexity = O(m+n)
    //Space= O(Min(m,n))
    public int[] Intersect(int[] nums1, int[] nums2) {
        //Hashset Algorithm
        /*
        if(nums1.Length>nums2.Length);{
          int[] tempdata = nums1;
            nums1 = nums2;
            nums2 = tempdata;
        }
        //return Intersect(nums2,nums1);
   Console.Out.WriteLine("1");
    
    Dictionary <int,int> map = new Dictionary<int,int>();
    //Store all the values in dictionary with their occurances
    for(int i=0;i<nums1.Length;i++){
        if(!map.ContainsKey(nums1[i])){
            map.Add(nums1[i],1);
        }else{
            map[nums1[i]] =  map[nums1[i]] +1;
        }
    }
    
    List<int> list = new List<int>();
    for(int i =0;i<nums2.Length;i++){
        if(map.ContainsKey(nums2[i])){
        int count = map[nums2[i]];
            if(count>0){
                Console.Out.WriteLine("I am in the intersection thing" +count);
            list.Add(nums2[i]);
                Console.Out.WriteLine("Before -1 map[nums2[i]]" + map[nums2[i]]);
            map[nums2[i]] = map[nums2[i]]  - 1;    
                Console.Out.WriteLine("After -1 map[nums2[i]]" + map[nums2[i]]);
            }
        }
    }
    
    int[] result = new int[list.Count()];
    int index =0;
    foreach(int num in list){
        result[index++] = num;
    }
    return result;*/
//Two Pointers
        
        Array.Sort(nums1);
        Array.Sort(nums2);
        int i = 0;
        int j = 0;
        List<int> list = new List<int>();
        while(i<nums1.Length && j<nums2.Length){
            if(nums1[i] == nums2[j] ){
                list.Add(nums1[i]);
                i++;
                j++;
            } else if(nums1[i]<nums2[j]){
                i++;
            } else{
                j++;
            }
        }
        int[] result = new int[list.Count()];
        int k =0;
        foreach(int num in list){
            result[k++] = num;
        }
        return result;
}
}