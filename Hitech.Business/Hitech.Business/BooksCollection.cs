namespace Hitech.Business
{
    public class BooksCollection
    {
        private static GenericList<int, Book> BookList = new GenericList<int, Book>();

        public static void LoadCollection(GenericList<int, Book> list)
        {
            BookList = list;
        }

        public static GenericList<int, Book> GetCollection()
        {
            return BookList;
        }

        public static bool AddBook(Book book)
        {
            return BookList.Add(book.ProductId, book);
        }

        public static void RemoveBook(Book book)
        {
            BookList.Remove(book.ProductId);
        }

        public static Book GetBook(int bookId)
        {
            if (BookList.Contains(bookId))
            {
                return BookList.GetByKey(bookId);
            }
            else
            {
                return default(Book);
            }
        }

        public static int NextBookId()
        {
            int nextBookId = default(int);

            for (int i = 0; i < BookList.GetCount(); i++)
            {
                Book book = BookList[i];

                if (book.ProductId > nextBookId)
                {
                    nextBookId = book.ProductId;
                }
            }

            return (nextBookId + 1);
        }

        public static Book GetBookByAuthor(int authorId)
        {
            for (int i = 0; i < BookList.GetCount(); i++)
            {
                Book book = BookList[i];
                if (book.AuthorId == authorId)
                {
                    return book;
                }
            }

            return default(Book);
        }

        public static Book GetBookByCategory(int categoryId)
        {
            for (int i = 0; i < BookList.GetCount(); i++)
            {
                Book book = BookList[i];
                if (book.CategoryId == categoryId)
                {
                    return book;
                }
            }

            return default(Book);
        }

        public static Book GetBookBySupplier(int supplierId)
        {
            for (int i = 0; i < BookList.GetCount(); i++)
            {
                Book book = BookList[i];
                if (book.SupplierId == supplierId)
                {
                    return book;
                }
            }

            return default(Book);
        }
    }
}
