public class Solution 
{

    public int[] DailyTemperatures(int[] temperatures) 
    {

        var daysTilWarm = new int[temperatures.Length];

        var temperatureStack = new Stack<int>();

        for (int day = 0; day < temperatures.Length; day++)
        {
            
            while (temperatureStack.Count > 0 && temperatures[day] > temperatures[temperatureStack.Peek()])
                daysTilWarm[temperatureStack.Peek()] = day - temperatureStack.Pop();

            temperatureStack.Push(day);

        }

        return daysTilWarm;
        
    }

}
