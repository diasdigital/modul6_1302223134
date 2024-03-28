using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace modul6_1302223134;

internal class SayaTubeUser
{
    int id;
    List<SayaTubeVideo> uploadedVideos;
    String username;

    public String getUsername() => username;
    public List<SayaTubeVideo> getUploadedVideos() => uploadedVideos;

    public SayaTubeUser(String username)
    {
        Debug.Assert(username != null, "Username tidak boleh kosong");
        Debug.Assert(username.Length <= 100, "Username max 100 karakter");

        id = new Random().Next(10000,99999);
        uploadedVideos = new List<SayaTubeVideo>();
        this.username = username;
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.getPlayCount();
        }
        return totalPlayCount;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null, "Video tidak boleh null");
        Debug.Assert(video.getPlayCount() < int.MaxValue, "Play count video melebihi max value integer");

        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle());
            Debug.Assert(i < 8, "Max 8 video di print");
        }
    }
}
