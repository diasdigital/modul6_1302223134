namespace modul6_1302223134;

internal class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public int getPlayCount() => playCount;
    public String getTitle() => title;

    public SayaTubeVideo(String title)
    {
        id = new Random().Next(10000,99999);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount = playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("========== Detail video ==========");
        Console.WriteLine("| ID         : " + id);
        Console.WriteLine("| Title      : " + title);
        Console.WriteLine("| Play Count : " + playCount);
        Console.WriteLine("----------------------------------\n");

    }
}
