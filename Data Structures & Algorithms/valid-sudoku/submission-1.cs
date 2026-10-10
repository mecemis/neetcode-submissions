public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                char value = board[row][col];

                if (value == '.')
                    continue;

                int boxIndex = (row / 3) * 3 + (col / 3);

                if (rows[row].Contains(value) ||
                    cols[col].Contains(value) ||
                    boxes[boxIndex].Contains(value))
                {
                    return false;
                }

                rows[row].Add(value);
                cols[col].Add(value);
                boxes[boxIndex].Add(value);
            }
        }

        return true;
    }
}
