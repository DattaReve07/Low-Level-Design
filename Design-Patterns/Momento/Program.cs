// See https://aka.ms/new-console-template for more information

using Momento;

Console.WriteLine("Hello, This is example of memento design pattern");

var textEditor = new Originator();
var careTaker = new CareTaker();

textEditor.setContent("This is first content");
careTaker.Save(textEditor.save());

textEditor.setContent("This is second content");
careTaker.Save(textEditor.save());

textEditor.setContent("This is third content");
careTaker.Save(textEditor.save());

Console.WriteLine("========== Before Undo ==========");
Console.WriteLine(textEditor.getContent());

Console.WriteLine("========== After Undo ==========");
careTaker.Undo(textEditor);
Console.WriteLine(textEditor.getContent());

careTaker.Undo(textEditor);
Console.WriteLine(textEditor.getContent());

careTaker.Undo(textEditor);
Console.WriteLine(textEditor.getContent());