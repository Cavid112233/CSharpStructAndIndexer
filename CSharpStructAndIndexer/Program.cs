using Core.Entities;

namespace CSharpStructAndIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            int choice;
            do
            {
                Console.WriteLine("Menu:\n" +
                    "1. Kitab elave et.\n" +
                    "2. Butun kitablarin siyahisina bax.\n" +
                    "3. Ada gore axtaris et.\n" +
                    "4. Kitabi sil.\n" +
                    "5. Value deyerine gore axtaris et.\n" +
                    "0. Proqrami bitir.");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Kitabin adini daxil edin:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Yazicinin adini daxil edin:");
                    string authorName = Console.ReadLine();

                    int pageCount;
                    do
                    {
                        Console.WriteLine("Sehife sayini daxil edin:");
                    }
                    while (!int.TryParse(Console.ReadLine(), out pageCount));

                    Book newBook = new Book(name, authorName, pageCount);
                    library.AddBook(newBook);
                    Console.WriteLine("Kitab elave edildi!");
                }
                else if (choice == 2)
                {
                    foreach (var book in library.ShowAllBooks())
                    {
                        Console.WriteLine(book);
                        Console.WriteLine("=========================");
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Deyer daxil edin(ada gore axtaris edeceksiniz!):");
                    string value = Console.ReadLine();

                    foreach (var item in library.FindAllBooksByName(value))
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("------------------------------------------");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Deyer daxil edin(kitabin adina gore silecek!):");
                    string value = Console.ReadLine();

                    foreach (var item in library.RemoveAllBooksByName(value))
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Deyer daxil edin:");
                    string value = Console.ReadLine();

                    foreach (var item in library.SearchBooks(value))
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("======================");
                }
            } while (choice != 0);

            Console.WriteLine("Proqram bitdi!");

        }
    }
}
