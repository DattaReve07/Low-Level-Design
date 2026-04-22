// See https://aka.ms/new-console-template for more information

using Iterator;

Console.WriteLine("====================== Iterator Design Patter ===========================");

var bookList = new List<Book>
{
    new Book("Kraunchvadh", "V.S.Khandekar", 200),
    new Book("Mrityunjay", "Shivaji Sawant", 400),
    new Book("Swami", "Ranjit Desai", 300),
    new Book("Yugandhar", "Shivaji Sawant", 600),
};

var library = new Library(bookList);

var bookIterator =  library.GetIterator();

while (bookIterator.HasNext())
{
    var book = bookIterator.Next();
    Console.WriteLine(book.ToString());
}