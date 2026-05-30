public class Solution {
    public string Encode(IList<string> strs) {
        if (strs.Count == 0) return "";

        StringBuilder sb = new StringBuilder();

        foreach (string str in strs) {
            sb.Append(str.Length);
            sb.Append(',');
        }

        sb.Append('#');

        foreach (string str in strs) {
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        if (s.Length == 0) {
            return new List<string>();
        }

        List<int> sizes = new List<int>();
        List<string> res = new List<string>();

        int i = 0;

        while (s[i] != '#') {
            StringBuilder cur = new StringBuilder();

            while (s[i] != ',') {
                cur.Append(s[i]);
                i++;
            }

            sizes.Add(int.Parse(cur.ToString()));
            i++;
        }

        i++;

        foreach (int size in sizes) {
            res.Add(s.Substring(i, size));
            i += size;
        }

        return res;
    }
}