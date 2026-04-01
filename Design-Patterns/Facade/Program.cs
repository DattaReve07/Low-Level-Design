// See https://aka.ms/new-console-template for more information

using Facade;

Console.WriteLine("================== Facade Design Pattern ======================");


var convertor = new VideoConverter();
var mp4File = convertor.Convert("funny-cats-video.ogg", "mp4");
mp4File.Save();