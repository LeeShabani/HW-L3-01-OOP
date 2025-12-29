// See https://aka.ms/new-console-template for more information
using HomeWork3_Task1;

Console.WriteLine("Hello , welcome to library");
Library library = new Library();
bool OpenCosole = false;


while (!OpenCosole)
{
    Console.WriteLine("USE THE MENU FOR THE ACTION YOU WANT");
    Console.WriteLine("Enter 1 to AddBook");
    Console.WriteLine("Enter 2 to BorrowBook");
    Console.WriteLine("Enter 3 to Return Borrowed Book");
    Console.WriteLine("Enter 4 for all book");
    Console.WriteLine("Enter 5 to Exit");

    Console.Write("Enter your choice: ");
    string Input = Console.ReadLine();

    switch (Input)
    {
        case "1":
            Console.Write("please enter the title: ");
            string title = Console.ReadLine();
            Console.Write("please enter author name: ");
            string author = Console.ReadLine();
            Console.Write("please enter isbn: ");
            int isbn = int.Parse(Console.ReadLine());
            Bookcs newBook = new Bookcs(title, author, isbn);
            library.AddBook(newBook);
            break;

        case "2":
            Console.Write("please enter isbn: ");
            int borrowIsbn = int.Parse(Console.ReadLine());
            library.BorrowBook(borrowIsbn);
            break;

        case "3":
            Console.Write("please enter isbn: ");
            int returnIsbn = int.Parse(Console.ReadLine());
            library.ReturnBook(returnIsbn);
            break;

        case "4":
            library.DisplayBooks();
            break;

        case "5":
            OpenCosole = true;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
            break;
    }

    if (!OpenCosole)
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}