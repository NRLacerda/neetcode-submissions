public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];


        for(int i = 0; i < 9; i++)
        {
            cols[i] = new HashSet<char>();
            rows[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int r = 0; r < 9; r++)
        {
            for(int c = 0; c < 9; c++)
            {
                char value = board[r][c];

                if(value == '.') continue;

                int box = (r / 3) * 3 + (c / 3);

                if(!cols[c].Add(value) 
                || !rows[r].Add(value)
                || !boxes[box].Add(value))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
