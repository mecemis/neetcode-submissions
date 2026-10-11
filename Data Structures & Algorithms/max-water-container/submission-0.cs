public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0;
        for (int i = 0, j = heights.Length - 1; i < j;) {
            int shorter = Math.Min(heights[i], heights[j]);
            int area = shorter * (j - i);
            res = Math.Max(res, area);
            if(heights[i] < heights[j]){
                i++;
                while(i < j && heights[i] == heights[i-1])
                i++;
            }
            else if (heights[i] > heights[j]){
                j--;
                while(i < j && heights[j] == heights[j+1])
                j--;
            }
            else{
                i++;
                j--;

                while(i < j && heights[i] == heights[i-1])
                i++;
                while(i < j && heights[j] == heights[j+1])
                j--;
            }
        }
        return res;
    }
}
