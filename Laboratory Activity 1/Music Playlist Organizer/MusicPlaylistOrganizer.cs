using System;

class Song
{
    private string title;
    private string artist;
    private double duration;

    public Song() : this("Unknown", "Unknown", 0) { }

    public Song(string title, string artist) : this(title, artist, 0) { }

    public Song(string title, string artist, double duration)
    {
        this.title = string.IsNullOrWhiteSpace(title) ? "Unknown" : title;
        this.artist = string.IsNullOrWhiteSpace(artist) ? "Unknown" : artist;
        this.duration = duration;
    }

    public double GetDuration()
    {
        return duration;
    }

    public void DisplaySong()
    {
        Console.WriteLine("{0,-20} {1,-15} {2,6:F2}", title, artist, duration);
    }
}

class Program
{
    static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        string s = Console.ReadLine();
        if (int.TryParse(s, out int v) && v >= 0) return v;
        return 0;
    }

    static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        string s = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(s)) return 0;

        s = s.Replace(',', '.');
        if (double.TryParse(s, out double v)) return v;

        return 0;
    }

    static void Main()
    {
        int count = ReadInt("Songs to add: ");

        Song[] playlist = new Song[count];

        bool allBlankFirstSong = false;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Song #{0}", i + 1);

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            string durText = Console.ReadLine();

            if (i == 0)
                allBlankFirstSong = string.IsNullOrWhiteSpace(title) && string.IsNullOrWhiteSpace(artist) && string.IsNullOrWhiteSpace(durText);

            double duration = 0;
            if (!string.IsNullOrWhiteSpace(durText))
            {
                durText = durText.Replace(',', '.');
                double.TryParse(durText, out duration);
            }

            playlist[i] = new Song(title, artist, duration);
        }

        Console.WriteLine();

        if (allBlankFirstSong)
            Console.WriteLine("=== PLAYLIST ===");
        else
            Console.WriteLine("=== || MY PLAYLIST || ===");

        Console.WriteLine("{0,-20} {1,-15} {2,6}", "Title", "Artist", "Time");
        Console.WriteLine("--------------------------------------------------");

        double total = 0;

        for (int i = 0; i < count; i++)
        {
            playlist[i].DisplaySong();
            total += playlist[i].GetDuration();
        }

        double average = count > 0 ? total / count : 0;

        Console.WriteLine();
        Console.WriteLine("Total Duration: {0:F2} mins", total);
        Console.WriteLine("Average Duration: {0:F2} mins", average);
    }
}
