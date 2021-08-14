public class UndergroundSystem {

    Dictionary <int,Event> arrivals;
    Dictionary <String,Average> averages;
    string DELIMETER = ",";
    public UndergroundSystem() {
        arrivals = new Dictionary <int,Event>();
        averages = new Dictionary<String, Average>();
        
    }
    
    public void CheckIn(int id, string stationName, int t) {
        arrivals.Add(id, new Event(id,stationName,t));
        
    }
    
    public void CheckOut(int id, string stationName, int t) {
        if(arrivals.ContainsKey(id)){
            Event eventObj = arrivals[id];
            arrivals.Remove(id);
            
            int diff = t - eventObj.t;
            string endStation = stationName;
            string startingStation = eventObj.stationName;
            string key = startingStation + DELIMETER + endStation;
            
            Average averageObj = averages.ContainsKey(key)?averages[key]:new Average();
            averageObj.updateAverage(diff);
            if(!averages.ContainsKey(key)){
                averages.Add(key,averageObj);
            }else{
                averages[key] = averageObj;
            }
            
            
        }
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        string key = startStation + DELIMETER + endStation;
        return averages[key].getAverage();
    }
    
    public class Event{
        public int id;
        public string stationName;
        public int t;
        public Event(int id, string stationName, int t){
            this.id = id;
            this.stationName = stationName;
            this.t = t;
        }
    }
    
    public class Average{
        public double total = 0;
        public int count = 0;
       
        
        public void updateAverage(int diff){
            ++count;
            total +=diff;
        }
        
        public double getAverage(){
            return total/count;
        }
    }
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */