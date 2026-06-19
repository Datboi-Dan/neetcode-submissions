public class Solution {

    public string Encode(IList<string> strs) 
    {

        
        var code = $"{strs.Count}#";

        foreach (string str in strs)
            code += str.Length + "#";

        foreach (string str in strs)
            code += str;

        return code;
        
    }

    public List<string> Decode(string s) 
    {

        var separatorIndex = s.IndexOf('#');
        var strLengths = new int[Convert.ToInt32(s.Substring(0, separatorIndex))];
        s = s.Substring(separatorIndex + 1);

        var strList = new List<String>();

        for (int i = 0; i < strLengths.Length; i++)
        {

            separatorIndex = s.IndexOf('#');
            strLengths[i] = Convert.ToInt32(s.Substring(0, separatorIndex));
            s = s.Substring(separatorIndex + 1);

        }

        foreach (int length in strLengths)
        {

            strList.Add(s.Substring(0, length));
            s = s.Substring(length);

        }

        return strList;

    }

}