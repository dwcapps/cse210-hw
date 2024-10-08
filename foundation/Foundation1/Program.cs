using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video_1 = new Video("How to write the best C# Program of all time!", "C#_Guy", 655);
        videos.Add(video_1);
        video_1.AddComment("C# Noob", "This was so helpful!");
        video_1.AddComment("DunningKruger", "I could've made it better...");
        video_1.AddComment("Danex", "Guys I think we're in a CSE210 program.");

        Video video_2 = new Video("You WON'T BELIEVE what this video is about!!! (not clickbait)", "ChannelEngagement101", 340);
        videos.Add(video_2);
        video_2.AddComment("GullibleDude", "OMG I DON'T BELIEVE IT!!!");
        video_2.AddComment("ScamBot", "Want free v-bucks? Check my profile!");
        video_2.AddComment("Danex", "Wasn't this program supposed to identify product placements or something, these are just random fake videos.");

        Video video_3 = new Video("12 Hours of Complete Silence with No Visuals.", "BadWhiteNoise", 43200);
        videos.Add(video_3);
        video_3.AddComment("BoredBrowser", "Idk what I expected...");
        video_3.AddComment("NeverSatisfied", "Eh, could be quieter.");
        video_3.AddComment("Danex", "It gets really good around the 9 hour mark.");

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}