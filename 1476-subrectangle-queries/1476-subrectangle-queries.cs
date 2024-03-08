public class SubrectangleQueries {
    int[][] rectangle;
    public SubrectangleQueries(int[][] rectangle) {
       // Initialize the rectangle with the provided matrix
        this.rectangle = new int[rectangle.Length][];
        for (int i = 0; i < rectangle.Length; i++)
        {
            this.rectangle[i] = new int[rectangle[0].Length];
            Array.Copy(rectangle[i], this.rectangle[i], rectangle[0].Length);
        }
        
    }
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
        for(int row=row1;row<=row2;row++){
            for(int col=col1;col<=col2;col++){
                rectangle[row][col]=newValue;
            }
        }
    }
    
    public int GetValue(int row, int col) {
        return rectangle[row][col];
    }
}

/**
 * Your SubrectangleQueries object will be instantiated and called as such:
 * SubrectangleQueries obj = new SubrectangleQueries(rectangle);
 * obj.UpdateSubrectangle(row1,col1,row2,col2,newValue);
 * int param_2 = obj.GetValue(row,col);
 */