public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        char[] tChars = t.ToCharArray();
        char[] sChars = s.ToCharArray();

        Array.Sort(tChars);
        Array.Sort(sChars);

        return sChars.SequenceEqual(tChars);
    }
}
