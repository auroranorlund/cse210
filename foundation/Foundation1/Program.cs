using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Cats Dancing", "blueberrypie123", 90);
        video1.AddComment("catlover456", "This is so cute!");
        video1.AddComment("dogl0ver", "Dogs are cuter.");
        video1.AddComment("rainbowsunshine32", "I love this!");

        Video video2 = new Video("10 Secrets to Writing a Novel", "quilloversword", 1200);
        video2.AddComment("aspiringauthor2", "This was so helpful!");
        video2.AddComment("comicgeek25", "These tips could help me write my own comic book too!");
        video2.AddComment("rosesandthorns", "Can you do a poetry video next?");

        Video video3 = new Video("A Day In The Life of a Secret Agent", "SuitsAndSunglasses", 1450);
        video3.AddComment("bodyguardlife", "We have a lot in common!");
        video3.AddComment("nopainnogain", "Can you share your full workout routine?");
        video3.AddComment("mrsmatthews", "Be careful out there!");
        
        List<Video> videos = new List<Video>{video1, video2, video3};
        foreach(Video v in videos)
        {
            v.DisplayText();
        }
    }
}