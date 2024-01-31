// Concepts demonstrated
// 1. Generics
// 2. Func
// 3. Open/Closed Principle
// 4. Decorator Design Pattern

IDataDownloader dataDownloader =
    new CachingDataDownloader(
        new PrintingDataDownloader(
            new SlowDataDownloader()));

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();