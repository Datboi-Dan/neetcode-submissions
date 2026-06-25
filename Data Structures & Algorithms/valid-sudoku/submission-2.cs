public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {

        var takenDigits = new HashSet<char>();

        for (int r = 0; r < board.Length; r++)
        {

            for (int i = 0; i < board.Length; i++)
            {

                if (board[r][i] != '.')
                {

                    if (takenDigits.Contains(board[r][i]))
                        return false;
                    else
                        takenDigits.Add(board[r][i]);

                }
                    

            }

            takenDigits.Clear();

        }

        for (int c = 0; c < board.Length; c++)
        {

            for (int i = 0; i < board.Length; i++)
            {

                if (board[i][c] != '.')
                {

                    if (takenDigits.Contains(board[i][c]))
                        return false;
                    else
                        takenDigits.Add(board[i][c]);

                }
                    

            }

            takenDigits.Clear();

        }

        for (int b = 0; b < board.Length; b++)
        {

            for (int i = 0; i < board.Length; i++)
            {

                if (board[b % 3 * 3 + i / 3][b / 3 * 3 + i % 3] != '.')
                {

                    if (takenDigits.Contains(board[b % 3 * 3 + i / 3][b / 3 * 3 + i % 3]))
                        return false;
                    else
                        takenDigits.Add(board[b % 3 * 3 + i / 3][b / 3 * 3 + i % 3]);

                }
                    

            }

            takenDigits.Clear();

        }

        return true;

    }
}
