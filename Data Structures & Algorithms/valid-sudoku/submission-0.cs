public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {

        var rows = new HashSet<char>[9];
        var columns = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];
        for (int i = 0; i < 9; i++)
        {

            for (int j = 0; j < 9; j++)
            {

                if (rows[i] is null)
                    rows[i] = new HashSet<char>();

                if (columns[j] is null)
                    columns[j] = new HashSet<char>();
                    
                if (boxes[i / 3 * 3 + j / 3] is null)
                    boxes[i / 3 * 3 + j / 3] = new HashSet<char>();

                if (board[i][j] != '.')
                {

                    if (rows[i].Contains(board[i][j]) || columns[j].Contains(board[i][j]) || boxes[i / 3 * 3 + j / 3].Contains(board[i][j]))
                        return false;
                    
                    rows[i].Add(board[i][j]);
                    columns[j].Add(board[i][j]);
                    boxes[i / 3 * 3 + j / 3].Add(board[i][j]);

                }

            }
        
        }
        return true;
        
    }
}
