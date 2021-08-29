/**
*Time complexity : O(N + M)O(N+M).

At each step, we're moving 1 step left or 1 step down. Therefore, we'll always finish looking at either one of the MM rows or NN columns. Therefore, we'll stay in the grid for at most N + MN+M steps, and therefore get a time complexity of O(N + M)O(N+M).
Space complexity : O(1)O(1).

We are using constant extra space.
 * // This is BinaryMatrix's API interface.
 * // You should not implement it, or speculate about its implementation
 * class BinaryMatrix {
 *     public int Get(int row, int col) {}
 *     public IList<int> Dimensions() {}
 * }
 */

class Solution {
    public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix) {
        IList<int> rowsList = binaryMatrix.Dimensions();
        int rows = binaryMatrix.Dimensions()[0];
        int columns = binaryMatrix.Dimensions()[1];
        int currentRow = 0;
        int currentCol = columns -1;
        
        //Repeat the search until it goes off the grid
        while(currentRow<rows && currentCol >=0){
            if(binaryMatrix.Get(currentRow,currentCol) == 0){
                currentRow++;
            }else{
                currentCol --;
            }
        }
        //If we never left the last column, this is because it was all 0's
        return (currentCol == columns -1)?-1:currentCol +1;
        
    }
}