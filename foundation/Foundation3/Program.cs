using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities= new List<Activity>();
        activities.Add(new RunningActivity(20, 2));
        activities.Add(new CyclingActivity(23.1, 14.2));
        activities.Add(new SwimmingActivity(37.4, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}