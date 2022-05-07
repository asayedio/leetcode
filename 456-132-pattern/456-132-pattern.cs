public class Solution {
    public bool Find132pattern(int[] nums) {
        int n = nums.Length;
        int two = int.MinValue;
        Stack<int> threes = new();
        for (int i = n - 1; i >= 0; i--) 
        {
            int one = nums[i];
            if (one < two)
                return true;
            while (threes.Any() && threes.Peek() < one)
                two = threes.Pop();
            threes.Push(one);
        }
        return false;
    }
} 