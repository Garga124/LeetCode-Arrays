public class Solution {
    public bool IsRobotBounded(string instructions) {
        int a = 0;
        int b = 0;
        int dir = 0; //0>N,1>E,2>W,3>S
        int[,] directions = new int[,]{{0,1},{1,0},{0,-1},{-1,0}};
        foreach(char c in instructions){
            if(c == 'G'){
                a += directions[dir,0];
                b += directions[dir,1];
                
            }else if(c == 'L'){
                dir = dir ==0 ?3: (dir -1);
            }else if (c == 'R'){
                dir = (dir +1)%4;
            }
        }
        
        if(a==0 && b==0){
            return true;
        }
        if(dir ==0){
            return false;
        }
        return true;
    }
}