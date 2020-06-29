namespace Tests
{
    using Books.Models;
    using Books.Queries;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Threading;

    [TestClass]
    public class GetBooksHandlerTest
    {
        private GetBooksHandler _getBooksHandler;

        [TestInitialize]
        public void Setup()
        {
            this._getBooksHandler = new GetBooksHandler();

        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book1_Match()
        {
            var bookList = new BookList()
            {
                Book1 = 0,
                Book2 = 0,
                Book3 = 0,
                Book4 = 0,
                Book5 = 0
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreEqual(actual.BookList.Book1, expected.Book1);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book1_NoMatch()
        {
            var bookList = new BookList()
            {
                Book1 = 1,
                Book2 = 0,
                Book3 = 0,
                Book4 = 0,
                Book5 = 0
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreNotEqual(actual.BookList.Book1, expected.Book1);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book2_Match()
        {
            var bookList = new BookList()
            {
                Book1 = 0,
                Book2 = 0,
                Book3 = 0,
                Book4 = 0,
                Book5 = 0
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreEqual(actual.BookList.Book2, expected.Book2);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book2_NoMatch()
        {
            var bookList = new BookList()
            {
                Book1 = 0,
                Book2 = 2,
                Book3 = 0,
                Book4 = 0,
                Book5 = 0
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreNotEqual(actual.BookList.Book2, expected.Book2);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book3_Match()
        {
            var bookList = new BookList()
            {
                Book1 = 0,
                Book2 = 0,
                Book3 = 0,
                Book4 = 0,
                Book5 = 0
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreEqual(actual.BookList.Book3, expected.Book3);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book3_NoMatch()
        {
            var bookList = new BookList()
            {
                Book1 = 0,
                Book2 = 0,
                Book3 = 3,
                Book4 = 0,
                Book5 = 0
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreNotEqual(actual.BookList.Book3, expected.Book3);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book4_Match()
        {
            var bookList = new BookList()
            {
                Book1 = 0,
                Book2 = 0,
                Book3 = 0,
                Book4 = 0,
                Book5 = 0
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreEqual(actual.BookList.Book4, expected.Book4);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book4_NoMatch()
        {
            var bookList = new BookList()
            {
                Book1 = 0,
                Book2 = 0,
                Book3 = 0,
                Book4 = 4,
                Book5 = 0
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreNotEqual(actual.BookList.Book4, expected.Book4);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book5_Match()
        {
            var bookList = new BookList()
            {
                Book1 = 0,
                Book2 = 0,
                Book3 = 0,
                Book4 = 0,
                Book5 = 0
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreEqual(actual.BookList.Book5, expected.Book5);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetBooks_Book5_NoMatch()
        {
            var bookList = new BookList()
            {
                Book1 = 0,
                Book2 = 0,
                Book3 = 0,
                Book4 = 0,
                Book5 = 5
            };

            var request = new GetBooks();
            var cancellationToken = new CancellationToken();

            var expected = new GetBooksReponse(bookList).BookList;
            var actual = await _getBooksHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreNotEqual(actual.BookList.Book5, expected.Book5);
        }
    }

}
