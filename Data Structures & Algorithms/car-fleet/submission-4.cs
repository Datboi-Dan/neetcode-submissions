public class Solution 
{

    public int CarFleet(int target, int[] position, int[] speed) 
    {

        var fleets = new List<int[]>();
        var fleetCount = 1;

        for (var i = 0; i < position.Length; i++)
            fleets.Add(new int[] {position[i], speed[i]});

        fleets.Sort((a, b) => (a[0] - b[0]));

        double limit = (target - fleets[fleets.Count - 1][0]) / (double)fleets[fleets.Count - 1][1];
        fleets.RemoveAt(fleets.Count - 1);

        while (fleets.Count > 0)
        {
            
            double finishTime = (target - fleets[fleets.Count - 1][0]) / (double)fleets[fleets.Count - 1][1];
            if (finishTime > limit)
            {

                limit = finishTime;
                fleetCount++;

            }
            fleets.RemoveAt(fleets.Count - 1);

        }

        return fleetCount;
        
    }
}
