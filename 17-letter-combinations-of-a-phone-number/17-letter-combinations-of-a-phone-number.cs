public class Solution {
    public IList<string> LetterCombinations(string digits) {
        IList<string> result = new List<string>();
        Dictionary<char, List<char>> dial = new Dictionary<char, List<char>>();
        
        dial.Add('2', new List<char>() {'a', 'b', 'c'});
        dial.Add('3', new List<char>() {'d', 'e', 'f'});
        dial.Add('4', new List<char>() {'g', 'h', 'i'});
        dial.Add('5', new List<char>() {'j', 'k', 'l'});
        dial.Add('6', new List<char>() {'m', 'n', 'o'});
        dial.Add('7', new List<char>() {'p', 'q', 'r', 's'});
        dial.Add('8', new List<char>() {'t', 'u', 'v'});
        dial.Add('9', new List<char>() {'w', 'x', 'y', 'z'});
        
        foreach (char c in digits) {
            List<char> charsNew = dial[c];
            IList<string> temp = new List<string>();
            
            if (result.Count == 0)
                foreach (char cNew in charsNew)
                    result.Add(cNew + "");
            else {
                foreach (string s in result)
                    foreach (char cNew in charsNew)
                        temp.Add(s + cNew);              
                result = temp;
            }
        }   
        return result;
    }
}