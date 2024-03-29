using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video vid1 = new Video("Tylar's C# walkthrough", "Tylar Smith", 624);

        Comment vid1Comment1 = new Comment("Merrick", "This was a great video! very helpful!");
        Comment vid1Comment2 = new Comment("Tim", "You seemed to have mastered C# so much!");
        Comment vid1Comment3 = new Comment("Lucia", "I can't wait to see what your future in C# holds!");

        vid1.AddComment(vid1Comment2);
        vid1.AddComment(vid1Comment3);
        vid1.AddComment(vid1Comment1);

        videoList.Add(vid1);


        Video vid2 = new Video("Understanding classes with abstraction", "Tim Thayne", 3621);

        Comment vid2Comment1 = new Comment("Spencer", "What a great way to simplify my code!");
        Comment vid2Comment2 = new Comment("Tim", "You can find more information in the description of the video.");
        Comment vid2Comment3 = new Comment("Lucas", "You've saved my life! This made C# so much more understandable.");

        vid2.AddComment(vid2Comment2);
        vid2.AddComment(vid2Comment3);
        vid2.AddComment(vid2Comment1);

        videoList.Add(vid2);

        Video vid3 = new Video("The art of not Going Crazy in College", "Christopher Tygret", 999999);

        Comment vid3Comment1 = new Comment("Daniel", "Kinda depressing to be honest.");
        Comment vid3Comment2 = new Comment("Eddie", "This was a veeerrry long video, but he makes a lot of good points.");
        Comment vid3Comment3 = new Comment("Addie", "Good work on this video. Any chance you can make a condensed version?");

        vid3.AddComment(vid3Comment2);
        vid3.AddComment(vid3Comment3);
        vid3.AddComment(vid3Comment1);

        videoList.Add(vid3);


        foreach (Video video in videoList)
        {
            video.DisplayComments();
            Console.WriteLine("--------------------");
        }
    }
}