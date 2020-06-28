namespace Books.Queries
{
    using MediatR;
    using System.Threading.Tasks;
    using Books.Models;
    using System.Threading;

    public class GetBooksHandler : IRequestHandler<GetBooks, GetBooksReponse>
    {
        public Task<GetBooksReponse> Handle(GetBooks request, CancellationToken cancellationToken)
        {
            BookList response = new BookList
            {
                Book1 = 0,
                Book2 = 0,
                Book3 = 0,
                Book4 = 0,
                Book5 = 0,
            };

            return HandleInternalAsync(response, cancellationToken);
        }

        private async Task<GetBooksReponse> HandleInternalAsync(BookList response, CancellationToken cancellationToken)
        {
            return new GetBooksReponse(response);
        }
    }
}
