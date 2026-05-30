public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0) return "";
        StringBuilder sb = new StringBuilder();

        foreach(string s in strs)
        {
            sb.Append(s.Length);
            sb.Append(',');
        }

        sb.Append('#');

        foreach(string s in strs)
        {
            sb.Append(s);
        }   

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        if(s.Length == 0) return new List<string>();

        List<string> res = new List<string>();
        List<int> sizes = new List<int>();
        int i = 0;

        while(s[i] != '#')
        {
            StringBuilder sb = new StringBuilder();

            while(s[i] != ',')
            {
                sb.Append(s[i]);
                i++;
            }

            sizes.Add(int.Parse(sb.ToString()));
            i++;
        }

        i++;

        foreach(int size in sizes)
        {
            res.Add(s.Substring(i, size));
            i += size;
        }

        return res;
   }
}
