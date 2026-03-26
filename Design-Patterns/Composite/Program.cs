// See https://aka.ms/new-console-template for more information

using Directory = Composite.Directory;

Console.WriteLine("========= Composite Design Patern =========");
Console.WriteLine("========= File System =========");


var animeFolder = new Directory("Anime");

var onePieceFolder = new Directory("OnePiece");
var jjkFolder = new Directory("JKK");

var seasonFolder = new Directory("Season 1");
var episode1 = new Composite.File("Episode 1");
var episode2 = new Composite.File("Episode 2");

seasonFolder.Add(episode1);
seasonFolder.Add(episode2);

onePieceFolder.Add(seasonFolder);
jjkFolder.Add(seasonFolder);

animeFolder.Add(onePieceFolder);
animeFolder.Add(jjkFolder);

animeFolder.printContents();