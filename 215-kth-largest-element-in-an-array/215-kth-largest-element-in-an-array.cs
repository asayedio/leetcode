public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var list = new List<int>();
        
        foreach(var n in nums) {
            list.Add(n);
            if(list.Count > k)
                list.Remove(list.Min());
        }
        
        return list.Count == k ? list.Min() : list.Max(); 
    }
}