public class Solution {

    public string Encode(IList<string> strs) 
    {

        string code = "";
        
        foreach (string str in strs)
        {

            code += $"{str.Length}#";
            code += str;

        }
        
        return code;
        
    }

    public List<string> Decode(string s) 
    {

        var strs = new List<string>();
        
        while (s.Length > 0)
        {

            int separatorIndex = s.IndexOf('#');
            int length = Convert.ToInt32(s.Substring(0, separatorIndex));
            string str = s.Substring(separatorIndex + 1, length);
            strs.Add(str);
            s = s.Substring(separatorIndex + 1 + length);

        }
        
        return strs;


    }

}