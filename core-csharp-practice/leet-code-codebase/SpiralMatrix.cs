using System;
using System.Collections.Generic;

class SpiralMatrix
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> ans = new List<int>();

        int top = 0;
        int left = 0;
        int bottom = matrix.Length - 1;
        int right = matrix[0].Length - 1;

        while (left <= right && top <= bottom)
        {
            // Traverse from left to right
            for (int i = left; i <= right; i++)
            {
                ans.Add(matrix[top][i]);
            }
            top++;

            // Traverse from top to bottom
            for (int i = top; i <= bottom; i++)
            {
                ans.Add(matrix[i][right]);
            }
            right--;

            // Traverse from right to left
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    ans.Add(matrix[bottom][i]);
                }
                bottom--;
            }

            // Traverse from bottom to top
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    ans.Add(matrix[i][left]);
                }
                left++;
            }
        }

        return ans;
    }
}
