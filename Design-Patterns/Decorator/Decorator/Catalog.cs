namespace Decorator;

/// <summary>
/// The 'ConcreteDecorator' class
/// </summary>
public class Catalog : Decorator
{
        private readonly List<string> borrowers = [];
		LibraryItem libraryItem;

        // Constructor
        public Catalog(LibraryItem libraryItem)
            : base(libraryItem)
        {
			this.libraryItem = libraryItem;
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();
            borrowers.ForEach(b => Console.WriteLine(" borrower: " + b));
        }
    }