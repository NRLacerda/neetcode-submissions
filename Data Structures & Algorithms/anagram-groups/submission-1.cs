public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagramGroup = new Dictionary<string, List<string>>();        
        for(int i = 0; i < strs.Length; i++)
        {
            string key = new string(strs[i].OrderByDescending(c => c).ToArray());

            if(anagramGroup.ContainsKey(key))
            {
                anagramGroup[key].Add(strs[i]);
            }else{
                anagramGroup[key] = new List<string>();
                anagramGroup[key].Add(strs[i]);
            }
        }   
        
        List<List<string>> res = new List<List<string>>();

        foreach(List<string> list in anagramGroup.Values)
        {
            res.Add(list);
        }

        return res;
    }
}
