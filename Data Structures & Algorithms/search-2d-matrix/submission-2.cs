public class Solution 
{
    
    public bool SearchMatrix(int[][] matrix, int target) 
    {

        int l = 0, r = matrix.Length * matrix[0].Length - 1;

        while (l <= r)
        {

            var m = (r - l) / 2 + l;

            if (matrix[m / matrix[0].Length][m % matrix[0].Length] == target)
                return true;

            if (matrix[m / matrix[0].Length][m % matrix[0].Length] < target)
                l = m + 1;
            else
                r = m - 1;

        }

        return false;
        
    }

}
