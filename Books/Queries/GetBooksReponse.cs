using Books.Models;

namespace Books.Queries
{
    public class GetBooksReponse
    {
        internal GetBooksReponse(BookList bookList)
        {
            this.BookList = bookList;
        }

        public BookList BookList { get; set; }
    }
}
