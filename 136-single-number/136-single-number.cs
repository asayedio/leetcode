public class Solution {
    public int SingleNumber(int[] nums) {
        int singleNumber = 0;
        for(int i = 0; i < nums.Length; i++)
            singleNumber ^= nums[i];
        return singleNumber;
    }
}