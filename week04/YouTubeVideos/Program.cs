using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Comment vid1com1 = new Comment("Commenter1-1","This is the first comment for the first video!");
        Comment vid1com2 = new Comment("Commenter1-2","This is the second comment for the first video!");
        Comment vid1com3 = new Comment("Commenter1-3","This is the third commehnt for the first video!");

        List<Comment> vid1coms = new List<Comment>();

        vid1coms.Add(vid1com1);
        vid1coms.Add(vid1com2);
        vid1coms.Add(vid1com3);



        Comment vid2com1 = new Comment("Commenter2-1", "This is the first comment for the second video!");
        Comment vid2com2 = new Comment("Commenter2-2", "This is the second comment for the second video!");
        Comment vid2com3 = new Comment("Commenter2-3", "This is the third commehnt for the second video!");

        List<Comment> vid2coms = new List<Comment>();

        vid2coms.Add(vid2com1);
        vid2coms.Add(vid2com2);
        vid2coms.Add(vid2com3);



        Comment vid3com1 = new Comment("Commenter3-1", "This is the first comment for the third video!");
        Comment vid3com2 = new Comment("Commenter3-2", "This is the second comment for the third video!");
        Comment vid3com3 = new Comment("Commenter3-3", "This is the third commehnt for the third video!");

        List<Comment> vid3coms = new List<Comment>();

        vid3coms.Add(vid3com1);
        vid3coms.Add(vid3com2);
        vid3coms.Add(vid3com3);


        Video video1 = new Video("Video 1", "Tyler", 420, vid1coms);
        Video video2 = new Video("Video 2", "Bob", 69, vid2coms);
        Video video3 = new Video("Video 3", "Sally", 8675309, vid3coms);

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Time in seconds: {video.GetTime()}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            Console.WriteLine(video.GetComments());
        }

    }
}