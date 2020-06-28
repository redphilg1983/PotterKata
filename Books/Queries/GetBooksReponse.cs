namespace Books.Queries
{
    using Books.Models;

    public class GetBooksReponse
    {
        internal GetBooksReponse(BookList bookList)
        {
            this.BookList = bookList;
        }

        public BookList BookList { get; set; }
    }
}
