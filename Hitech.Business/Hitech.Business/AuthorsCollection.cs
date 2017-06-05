namespace Hitech.Business
{
    public class AuthorsCollection
    {
        private static GenericList<int, Author> AuthorList = new GenericList<int, Author>();

        public static void LoadCollection(GenericList<int, Author> list)
        {
            AuthorList = list;
        }

        public static GenericList<int, Author> GetCollection()
        {
            return AuthorList;
        }

        public static bool AddAuthor(Author author)
        {
            return AuthorList.Add(author.AuthorId, author);
        }

        public static void RemoveAuthor(Author author)
        {
            AuthorList.Remove(author.AuthorId);
        }

        public static Author GetAuthor(int authorId)
        {
            if (AuthorList.Contains(authorId))
            {
                return AuthorList.GetByKey(authorId);
            }
            else
            {
                return default(Author);
            }
        }

        public static int NextAuthorId()
        {
            int nextAuthorId = default(int);

            for (int i = 0; i < AuthorList.GetCount(); i++)
            {
                Author author = AuthorList[i];

                if (author.AuthorId > nextAuthorId)
                {
                    nextAuthorId = author.AuthorId;
                }
            }

            return (nextAuthorId + 1);
        }
    }
}
