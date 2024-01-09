public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int j = 0;
        foreach(int num in nums)
            if(num != val)
                nums[j++] = num;
        
        return j;
    }
}