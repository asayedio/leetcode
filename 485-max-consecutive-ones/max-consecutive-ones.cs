public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxWindowSize = 0;
        int currentWindowSize = 0;

        foreach (var num in nums) {
            if (num == 1) {
                currentWindowSize++;
            } else {
                maxWindowSize = Math.Max(maxWindowSize, currentWindowSize);
                currentWindowSize = 0;
            }
        }

        maxWindowSize = Math.Max(maxWindowSize, currentWindowSize);

        return maxWindowSize;
    }
}