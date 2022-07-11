class Solution {
    public int MajorityElement(int[] nums) =>
	nums.GroupBy(num => num)
		.First(group => group.Count() > nums.Length / 2)
		.Key;
}