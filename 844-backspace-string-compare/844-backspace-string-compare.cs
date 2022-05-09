public class Solution {
    public bool BackspaceCompare(string s, string t) {
        Stack<char> stackS = new Stack<char>();
        Stack<char> stackT = new Stack<char>();
        string cleanS = "", cleanT = "";
        
        for(int i=0; i < s.Length; i++){
            
            if(s[i] == '#' && stackS.Count == 0)
                continue;
            
            if(s[i] == '#' && stackS.Count != 0)
                stackS.Pop();
            else
                stackS.Push(s[i]);
        }
        
        for(int i=0; i < t.Length; i++){
            if(t[i] == '#' && stackT.Count == 0)
                continue;
            
            if(t[i] == '#' && stackT.Count != 0)
                stackT.Pop();
            else
                stackT.Push(t[i]);               
        }
        
        while(stackS.Count > 0)
                cleanS += stackS.Pop();
        
        while(stackT.Count > 0)
                cleanT += stackT.Pop();
        
        return cleanS == cleanT;
    }
}