public class Solution {

    public string Encode(IList<string> strs) 
    {

        string code = "";
        

        if (strs.Count == 0)
            return code;

        code = $"{strs[0].Length}#";
        code += strs[0];
        strs.RemoveAt(0);

        
        return code + Encode(strs);
        
    }

    public List<string> Decode(string s) 
    {

        if (s.Length == 0)
            return new List<string>();
        
        int separatorIndex = s.IndexOf('#');
        int length = Convert.ToInt32(s.Substring(0, separatorIndex));
        string str = s.Substring(separatorIndex + 1, length);
        s = s.Substring(separatorIndex + 1 + length);

        var strs = Decode(s);
        strs.Insert(0, str);
        return strs;


    }

}
