public class TimeMap {

    Dictionary<string, List<(string, int)>> map;

    public TimeMap() 
    {

        map = new Dictionary<string, List<(string, int)>>();

    }
    
    public void Set(string key, string value, int timestamp) 
    {
        
        if (!map.ContainsKey(key))
            map.Add(key, new List<(string, int)>());
        
        map[key].Add((value, timestamp));

    }
    
    public string Get(string key, int timestamp) 
    {

        if (!map.ContainsKey(key))
            return "";
            
        List<(string, int)> list = map[key];

        int l = 0, r = list.Count - 1;
        int prevTimestamp = 0;

        while (l < r)
        {

            var mid = (r - l) / 2 + l;

            if ((r - l) % 2 == 1)
                mid++;

            if (list[mid].Item2 <= timestamp)
            {
                prevTimestamp = mid;
                l = mid;
            }
            else
                r = mid - 1;

        }

        if (l == r && list[l].Item2 <= timestamp)
            return list[l].Item1;

        return "";
        
    }
}
