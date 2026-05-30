public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();

        foreach(string s in  strs)
        {
            string key = new string(s.OrderByDescending(c => c).ToArray());

            if(groupedAnagrams.ContainsKey(key))
            {
                groupedAnagrams[key].Add(s);
            }else{
                groupedAnagrams[key] = new List<string>{s};
            }
        }

        List<List<string>> res = new List<List<string>>();

        foreach(List<string> list in groupedAnagrams.Values)
        {
            res.Add(list);
        }

        return res;
    }
}
