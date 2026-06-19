public class Solution 
{

    public int CarFleet(int target, int[] position, int[] speed) 
    {

        var fleets = new (int position, int speed)[position.Length];

        for (var i = 0; i < position.Length; i++)
            fleets[i] = (position[i], speed[i]);

        Array.Sort(fleets, (a, b) => (a.position - b.position));

        double limit = (target - fleets[fleets.Length - 1].position) / (double)fleets[fleets.Length - 1].speed;
        var fleetCount = 1;
        for (int i = fleets.Length - 2; i >= 0; i--)
        {
            
            double finishTime = (target - fleets[i].position) / (double)fleets[i].speed;
            if (finishTime > limit)
            {

                limit = finishTime;
                fleetCount++;

            }

        }

        return fleetCount;
        
    }
}
