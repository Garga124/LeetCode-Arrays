
 
public class TimeMap {
    Dictionary<string, List<Data>> results;
    /** Initialize your data structure here. */
    public TimeMap() {
        results = new  Dictionary<string, List<Data>>();
       
       // results = new List<>
    }
    
    public void Set(string key, string value, int timestamp) {
         Data dataMapObj = new Data(value,timestamp);
        if(!results.ContainsKey(key)){
            results.Add(key,new List<Data>(){dataMapObj});
        }else{
           List<Data> listObj  = results[key];
             results[key].Add(dataMapObj);
            //results.Add(key,listObj.Add(listObj));
        }
    }
    
    public string Get(string key, int timestamp) {
        if(results.ContainsKey(key)){
            
            List<Data> listObj  = results[key];
            int left = 0;
            int right = listObj.Count -1;
            while(left<right){
                int mid = (left + right +1)/2;
                if(listObj[mid].timeStamp>timestamp){
                    right = mid -1;
                }else if(listObj[mid].timeStamp<=timestamp){
                    left = mid;
                }
            }
            
            Data closestData = listObj[left];
            
            
            return closestData.timeStamp>timestamp?"":closestData.strValue;
            
            
          /*  foreach(TimeMap item in listObj){
                if(item.timeStamp<=timeStamp){
                    return item.strValue;
                }else{
                    return "";
                }
            }*/
        }else{
            return "";
        }
    }
    public class Data{
        public  int timeStamp;
       public string strValue;
        public Data(string strValue, int timeStamp){
            this.timeStamp = timeStamp;
            this.strValue = strValue;
        }
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */