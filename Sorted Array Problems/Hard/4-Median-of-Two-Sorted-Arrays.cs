public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        /*
        double median = 0.00;
        int m = nums1.Length;
        int n = nums2.Length;
        //Constraints either m or n can be 0 but both cant be 0 so lets consider the situation that m or n is 0
        int[] resultArr = new int[m+n];
        bool even = false;
        if((m+n)%2==0)
        {
            even = true;
        }
        int lastPositionIndex = (m + n);
        lastPositionIndex =lastPositionIndex -1;
         int lastIndexA = m-1;
        int lastIndexB = n-1;
   
        
        //fill this array first
        while(lastPositionIndex >= 0)
        {
            
            //Console.Out.WriteLine("ResultantArray Value till now:"+resultArr[lastPositionIndex]);
            //Add the sorted array in the resultant array when one of the array is empty
          //  if(m.length)
            
            if(lastIndexA<0)
            {                
                Console.Out.WriteLine("111111111111111111111111111111111111");
            resultArr[lastPositionIndex] = nums2[lastIndexB];    
                lastIndexB --;
            } else if (lastIndexB<0)
            {
                Console.Out.WriteLine("2222222222222222222222");
                resultArr[lastPositionIndex] = nums1[lastIndexA];    
                lastIndexA--;
            } else if(nums1[lastIndexA]<nums2[lastIndexB])
            {
                Console.Out.WriteLine("33333333333333333333");
                Console.Out.WriteLine("nums1[lastIndexA:"+ nums1[lastIndexA]+ "nums2[lastIndexB]:"+ nums2[lastIndexB]) ;
                resultArr[lastPositionIndex] = nums2[lastIndexB];
                lastIndexB --;
            } else {
                Console.Out.WriteLine("44444444444444");
                Console.Out.WriteLine("nums1[lastIndexAelse:"+ nums1[lastIndexA]+ "nums2[lastIndexB]:"+ nums2[lastIndexB]) ;
                resultArr[lastPositionIndex] = nums1[lastIndexA];
                lastIndexA --;
            }
            Console.Out.WriteLine(" resultArr[lastPositionIndex]:" +  resultArr[lastPositionIndex]);
              lastPositionIndex--;  
            } 
            
                int left = 0;
                int right = resultArr.Length - 1;
                int midValue = left + (right - left)/2;
       
        
        if(!even)
        {
           Console.Out.WriteLine("not even" + "Mid Value:"+ resultArr[midValue] + "TotalLength:"+ resultArr.Length);
            
            
                median = resultArr[midValue];               
        }else {
            Console.Out.WriteLine("2");
            Console.Out.WriteLine("MidValue:"+ resultArr[midValue]);
             Console.Out.WriteLine("MidValue:"+ resultArr[midValue +1]);
                median = (resultArr[midValue] + resultArr[midValue+1])/2.0;               
                
            }
        return median;
        
            
        }*/
       
     
        if(nums1.Length>nums2.Length)
            return FindMedianSortedArrays(nums2,nums1);
        int m = nums1.Length;
        int n = nums2.Length;
        int start = 0;
        int end = m;
        
        while (start<=end){
                    int positionX = (start + end)/2;
        int positionY = ((m + n + 1)/2) - positionX;
        
        //Calculate max and mins
        int maxLeftX = positionX == 0?int.MinValue : nums1[positionX-1];
        int maxLeftY = positionY == 0?int.MinValue : nums2[positionY-1];
        
        int minRightX = positionX == m? int.MaxValue : nums1[positionX];
        int minRightY = positionY == n? int.MaxValue : nums2[positionY];
        
        //Condition 1 valid one :
        if(maxLeftX<=minRightY && maxLeftY<=minRightX)
        {
            //Check for Odd or even
            if((m+n)%2 == 0){
                return (Math.Max(maxLeftX,maxLeftY)+Math.Min(minRightX,minRightY))/2.0;
            } else
            {
                return Math.Max(maxLeftX,maxLeftY);
            }
        } else if (maxLeftX>minRightY){
            end = positionX - 1;
        } else {
            start =  positionX + 1;
        }
        }
 return 0.00;
    }
    }
