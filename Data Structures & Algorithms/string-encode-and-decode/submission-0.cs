public class Solution {

    public string Encode(IList<string> strs) 
    {

        
        var code = $"{ConvertToTriplet(strs.Count)}";

        foreach (string str in strs)
            code += ConvertToTriplet(str.Length);

        foreach (string str in strs)
            code += str;

        return code;
        
    }

    public List<string> Decode(string s) 
    {

        var strLengths = new int[ConvertFromTriplet(s.Substring(0, 3))];
        s = s.Substring(3);

        var strList = new List<String>();

        for (int i = 0; i < strLengths.Length; i++)
        {

            strLengths[i] = ConvertFromTriplet(s.Substring(0, 3));
            s = s.Substring(3);

        }

        foreach (int length in strLengths)
        {

            strList.Add(s.Substring(0, length));
            s = s.Substring(length);

        }

        return strList;

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
