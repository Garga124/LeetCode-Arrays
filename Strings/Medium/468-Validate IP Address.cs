public class Solution {
    public string ValidIPAddress(string IP) {
        if(String.IsNullOrEmpty(IP)){
            return "Neither";
        }
        
        if(IP.IndexOf(".")>=0){
            return validateIPV4(IP)?"IPv4":"Neither";
        }
        if(IP.IndexOf(":")>=0){
            return validateIPV6(IP)?"IPv6":"Neither";
        }
        return "Neither";
    }

    
    public bool validateIPV4(string IP){
        if(IP[0] == '.' ||IP[IP.Length-1] == '.' ){
            return false;
        }
        
        
        string[] components = IP.Split(".");
        
        if(components.Length !=4){
            return false;
        }
        Console.Out.WriteLine("1");
        foreach(string item in components){
            if(item == "" || item.Length >3 ||(item[0]== '0' && item.Length>1)){
              
                return false;
            }
            foreach(char ch in item.ToCharArray()){
                //Console.Out.WriteLine("Character"+ ch);
                if(ch<'0'||ch>'9'){
                    
                    return false;
                }
              
            }
                int num = Int32.Parse(item);
            if(num<0 || num>255){
               // Console.Out.WriteLine("dddd"+item);
                return false;
            }
          
        }
     return true;   
    }
    
    public bool validateIPV6(string IP){
          if(IP[0] == ':' ||IP[IP.Length-1] == ':' ){
            return false;
        }
        
        string[] components = IP.Split(":");
        if(components.Length !=8){
            return false;
        }
        
        foreach(string item in components){
            if(item == "" || item.Length >4){
                return false;
            }
            foreach(char ch in item.ToLower().ToCharArray()){
                if((ch<'0'||ch>'9')&& ch != 'a' && ch !='b' && ch!='c' && ch !='d' && ch !='e' && ch != 'f'){
                    return false;
                }
            }
           
        }
        return true;
        
    }
}