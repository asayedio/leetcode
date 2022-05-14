public class Solution {
       public int FindUnsortedSubarray(int[] nums) 
    {
        int start = 0;
        int end = 0;
        // Edge case
        if (nums == null || nums.Length <= 1) {return 0;}
        
        // Step 1: Find the element from the start of the array which is in a non-increasing order
        for (start = 0; start< nums.Length-1; start++)
        {
            if (nums[start] > nums[start+1]) { break; }
        }
        
        // Array is already sorted
        if (start == nums.Length-1) {return 0; }
                                 
        // Step 2: Find the element from the end of the array which is in a non-decreasing order
        for (end = nums.Length-1; end> 0; end--)
        {
            if (nums[end] < nums[end-1]) { break; }
        }
                                 
        // Step 3: Now, we need to find the min and max from start to end
        int max = nums[start];
        int min = nums[end];
        for (int i = start; i< end; i++)
        {
            if (nums[i] > max) {max = Math.Max(nums[i], max);}            
            if (nums[i] < min) {min = Math.Min(nums[i], min);}
        }
        
        // Step 4: Now find the element from 0....start-1 which is just greater than minimum
        // i.e. expand the left boundary
        for (int k = 0; k < start; k++)
        {
            if (nums[k] > min) {start = k; break;}
        }
        
        // Step 4: Now find the element from end+1....n-1 which is just smaller than maximum
        // i.e. expand the right boundary
        for (int j = nums.Length - 1; j >= end+1; j--)
        {
            if (nums[j] < max) {end = j; break;}
        }
                               
		// You need to add 1 to the diff of end and start
        return (end - start) +1 ;
    }
}