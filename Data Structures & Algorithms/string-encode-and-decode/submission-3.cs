public class Solution {

    public string Encode(IList<string> strs) 
    {

        string code = "";
        

        if (strs.Count == 0)
            return code;

        code = $"{ConvertToTriplet(strs[0].Length)}";
        code += strs[0];
        strs.RemoveAt(0);

        
        return code + Encode(strs);
        
    }

    public List<string> Decode(string s) 
    {

        if (s.Length == 0)
            return new List<string>();
        
        int length = ConvertFromTriplet(s.Substring(0, 3));
        string str = s.Substring(3, length);
        s = s.Substring(3 + length);

        var strs = Decode(s);
        strs.Insert(0, str);
        return strs;


    }

    public string ConvertToTriplet(int num)
    {

        string triplet = "";

        if (num >= 100)
            triplet = $"{num}";
        else if (num >= 10)
            triplet = $"0{num}";
        else
            triplet = $"00{num}";

        return triplet;

    }

    public int ConvertFromTriplet(string str)
    {

        int hundreds = str[0] - '0';
        int tens = str[1] - '0';
        int ones = str[2] - '0';

        int num = (hundreds * 100) + (tens * 10) + ones;

        return num;

    }

}
