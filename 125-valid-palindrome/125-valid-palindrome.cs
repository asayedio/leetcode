public class Solution {
    public bool IsPalindrome(string s) {
        string newS = new string(s.Where(c =>char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray()).Replace(" ", "").ToLower();
        
        int left = 0, right = newS.Length - 1, isIdentical = 0;
        
        if(newS == "")
            return true;
        
         while (left < right) {
             if(newS[left++] == newS[right--])
                 isIdentical++;
         }
         return (newS.Length / 2 == isIdentical);       
    }
}