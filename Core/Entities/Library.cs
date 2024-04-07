namespace Core.Entities
{
    public class Library
    {
        Book[] Books = { };

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] FindAllBooksByName(string value)
        {
            Book[] findName = new Book[] { };

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.Contains(value))
                {
                    Array.Resize(ref findName, findName.Length + 1);
                    findName[findName.Length - 1] = Books[i];
                }
            }
            return findName;
        }
        public Book[] RemoveAllBooksByName(string value)
        {
            Book[] removeBooks = new Book[] { };

            for (int i = 0; i < Books.Length; i++)
            {
                if (!Books[i].Name.Contains(value))
                {
                    Array.Resize(ref removeBooks, removeBooks.Length + 1);
                    removeBooks[removeBooks.Length - 1] = Books[i];

                }
            }
            Books = removeBooks;
            return removeBooks;
        }
        public Book[] SearchBooks(string value)
        {
            Book[] searchBooks = new Book[] { };


            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.Contains(value) || Books[i].AuthorName.Contains(value) || Books[i].PageCount.ToString().Contains(value))
                {
                    Array.Resize(ref searchBooks, searchBooks.Length + 1);
                    searchBooks[searchBooks.Length - 1] = Books[i];
                }
            }
            return searchBooks;
        }
    }
}
