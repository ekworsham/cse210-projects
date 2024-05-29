using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Trapped in a Tiny House","The Royality Family", 1167);
        Comment comment1 = new Comment("Jenniferbrown54", "Can y’all please post more for the summer pls like");
        Comment comment2 = new Comment("jayfivebuk-62", "Best family in the world");
        Comment comment3 = new Comment("AreexahSyed-yx1my", "Love you guys TEAM ALL");

        Video video2 = new Video("Total idiots at work", "Amazing People", 2432);
        Comment comment4 = new Comment("Lewie Atlanta", "Laughter may be the destination, but these videos are the journey");
        Comment comment5 = new Comment("FarrahMartin-vj6ff", "Great video clips..i really enjoyed this");
        Comment comment6 = new Comment("fftves39", "Amigo mio, admiro tu coleccion de eestos fracasos humoristicos");

        Video video3 = new Video("2014 Cherokee High 4x400m @ Etowah", "Keith Worsham", 245);
        Comment comment7 = new Comment("keithworsham7781", "Love watching CHEROKEE HIGH track and field.....GO RYAN!");
        Comment comment8 = new Comment("PamWorsham", "Yaya, Ryan");
        Comment comment9 = new Comment("aaron", "awesome day");
        
        videos.Add(video1);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        videos.Add(video2);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        videos.Add(video3);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);


        foreach (Video video in videos)
        {
            Console.WriteLine();
            video.Display();
        }
    }
}