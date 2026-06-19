public class Solution 
{

    public int CarFleet(int target, int[] position, int[] speed) 
    {

        var fleets = new (int Position, int Speed)[position.Length];

        for (var i = 0; i < position.Length; i++)
            fleets[i] = (position[i], speed[i]);

        Array.Sort(fleets, (a, b) => (a.Position - b.Position));

        double limit = (target - fleets[fleets.Length - 1].Position) / (double)fleets[fleets.Length - 1].Speed;
        var fleetCount = 1;
        for (int i = fleets.Length - 2; i >= 0; i--)
        {
            
            double finishTime = (target - fleets[i].Position) / (double)fleets[i].Speed;
            if (finishTime > limit)
            {

                limit = finishTime;
                fleetCount++;

            }

        }

        return fleetCount;
        
    }
}
