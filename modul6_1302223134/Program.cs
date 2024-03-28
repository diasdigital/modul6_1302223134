using modul6_1302223134;

SayaTubeUser pengguna = new SayaTubeUser("Dias");
String[] judulFilm =
{
    "Interstellar",
    "Dune",
    "Murder On The Orient Express",
    "Kung Fu Panda",
    "How To Train Your Dragon",
    "Tenet",
    "Transformer",
    "Night At The Museum",
    "Spiderman Into The Spiderverse",
    "Up"
};

foreach (String film in judulFilm)
{
    SayaTubeVideo video = new SayaTubeVideo("Review Film " + film + " oleh " + pengguna.getUsername());
    video.IncreasePlayCount(new Random().Next(10, 1000));
    pengguna.AddVideo(video);
}


pengguna.PrintAllVideoPlaycount();
Console.WriteLine("Total view count: " + pengguna.GetTotalVideoPlayCount());
Console.WriteLine();

foreach (var video in pengguna.getUploadedVideos())
{
    video.PrintVideoDetails();
}
