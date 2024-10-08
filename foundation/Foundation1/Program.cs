using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("How to write the best C# Program of all time!", "C#_Guy", 655);
        videos.Add(video1);
        video1.AddComment("C# Noob", "This was so helpful!");
        video1.AddComment("DunningKruger", "I could've made it better...");
        video1.AddComment("Danex", "Guys I think we're in a CSE210 program.");

        Video video2 = new Video("You WON'T BELIEVE what this video is about!!! (not clickbait)", "ChannelEngagement101", 340);
        videos.Add(video2);
        video2.AddComment("GullibleDude", "OMG I DON'T BELIEVE IT!!!");
        video2.AddComment("ScamBot", "Want free v-bucks? Check my profile!");
        video2.AddComment("Danex", "Wasn't this program supposed to identify product placements or something, these are just random fake videos.");

        Video video3 = new Video("12 Hours of Complete Silence with No Visuals.", "BadWhiteNoise", 43200);
        videos.Add(video3);
        video3.AddComment("BoredBrowser", "Idk what I expected...");
        video3.AddComment("NeverSatisfied", "Eh, could be quieter.");
        video3.AddComment("Danex", "It gets really good around the 9 hour mark.");

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}