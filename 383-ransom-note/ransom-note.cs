public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in magazine) {
            if (charCount.ContainsKey(c)) {
                charCount[c]++;
            } else {
                charCount[c] = 1;
            }
        }

        foreach (char c in ransomNote) {
            if (charCount.ContainsKey(c) && charCount[c] > 0) {
                charCount[c]--;
            } else {
                return false;
            }
        }

        return true;
    }
}
