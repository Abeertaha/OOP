using System;

namespace Art 
{
public interface IMusic
{
    void Play();
}

public abstract class Media : IMusic
{
    public string? Title { get; set; }
    public abstract void Play();
}

public class Music : Media
{
    public string? Artist { get; set; }
    public override void Play() => Console.WriteLine($"Playing music: {Title} by {Artist}");
}

public class Movie : Media
{
    public string? Director { get; set; }
    public override void Play() => Console.WriteLine($"Playing movie: {Title} directed by {Director}");
}

class Program 
{
    static void Main(string[] args)
    {
        Media media1 = new Music { Title = "Wherever I May Roam", Artist = "Metallica" };
        Media media2 = new Movie { Title = "Stay", Director = "Marc Forster" };

        media1.Play();
        media2.Play();
    }
}
}