public class Solution 
{
    
    public bool SearchMatrix(int[][] matrix, int target) 
    {

       int low = 0, high = matrix.Length * matrix[0].Length - 1;

       while (low <= high)
       {

            int mid = (high - low) / 2 + low;

            int row = mid / matrix[0].Length;
            int column = mid % matrix[0].Length;

            if (matrix[row][column] == target)
                return true;

            if (matrix[row][column] < target)
                low = mid + 1;
            else
                high = mid - 1;

       }

       return false;
        
    }

}
