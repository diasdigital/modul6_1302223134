using System.Diagnostics;

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
        Debug.Assert(title != null, "Judul video tidak boleh kosong");
        Debug.Assert(title.Length <= 200, "Judul video max 200 karakter");

        id = new Random().Next(10000,99999);
        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Debug.Assert(playCount <= 25000000, "Penambahan play count max 25.000.000 per panggilan");
        Debug.Assert(playCount >= 0, "Nilai play count tidak boleh negatif");

        try
        {
            int newPlayCount = checked(this.playCount + playCount);
            this.playCount = newPlayCount;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
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
