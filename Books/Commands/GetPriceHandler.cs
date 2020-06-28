namespace Books.Commands
{
    using Books.Models;
    using MediatR;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetPriceHandler : IRequestHandler<GetPrice, GetPriceResponse>
    {
        private readonly decimal bookPrice = 8m;
        private readonly decimal twoBookDiscount = 0.95m;
        private readonly decimal threeBookDiscount = 0.9m;
        private readonly decimal fourBookDiscount = 0.8m;
        private readonly decimal fiveBookDiscount = 0.75m;
        private readonly decimal currencyConversionGBPToEuro = 1.1m;
        private List<List<int>> combinations;
        private List<decimal> costings;

        public Task<GetPriceResponse> Handle(GetPrice request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            return HandleInternalAsync(request, cancellationToken);
        }

        private async Task<GetPriceResponse> HandleInternalAsync(GetPrice request, CancellationToken cancellationToken)
        {
            int[] booksArray = HandleGetBooksLength(request);
            int[] updatedArray = HandleUpdateArray(booksArray);

            int booksLength = updatedArray.Length;
            int bookValue = updatedArray[0];

            if (booksLength == 1)
            {
                PriceResponse singleBookTypePrice = new PriceResponse
                {
                    GBP = bookValue * bookPrice,
                    Euro = bookValue * bookPrice * currencyConversionGBPToEuro,
                };

                return new GetPriceResponse(singleBookTypePrice);
            };

            List<List<int>> combinations = CalculateCombinations(updatedArray);

            List<decimal> costings = CalculateCostings(combinations);

            decimal lowestPrice = costings.Min();

            PriceResponse prices = new PriceResponse
            {
                GBP = lowestPrice,
                Euro = lowestPrice * currencyConversionGBPToEuro,
            };

            return new GetPriceResponse(prices);
        }

        private int[] HandleGetBooksLength(GetPrice request)
        {
            int[] booksArray = new int[] {
                request.PriceRequest.BookList.Book1,
                request.PriceRequest.BookList.Book2,
                request.PriceRequest.BookList.Book3,
                request.PriceRequest.BookList.Book4,
                request.PriceRequest.BookList.Book5,
            };

            return booksArray;
        }

        private List<List<int>> CalculateCombinations(int[] books)
        {
            combinations = new List<List<int>>();
            for (int x = 5; x > 0; x--)
            {
                List<int> intArray = new List<int>();
                if (books.Sum() >= x)
                {
                    int totalBooks = books.Sum();
                    int i = x;
                    while (i <= totalBooks)
                    {
                        intArray.Add(i);
                        totalBooks = totalBooks - x;
                    }
                    if (totalBooks != 0)
                    {
                        intArray.Add(totalBooks);
                    }
                }
                if (intArray.Count > 0)
                {
                    combinations.Add(intArray);
                }
            }

            return combinations;
        }

        private List<decimal> CalculateCostings(List<List<int>> combinations)
        {
            costings = new List<decimal>();
            foreach (List<int> combination in combinations)
            {
                decimal cost = 0m;
                foreach (int books in combination)
                {
                    cost = cost + HandleBookCosts(books);
                }
                costings.Add(cost);
            }
            return costings;
        }

        private int[] HandleUpdateArray(int[] booksArray)
        {
            int[] updatedArray = Array.FindAll(booksArray, i => i != 0).ToArray();
            return updatedArray;
        }

        private Decimal HandleBookCosts(int books)
        {
            if (books == 5)
            {
                decimal cost = bookPrice * 5 * fiveBookDiscount;
                return cost;
            };
            if (books == 4)
            {
                decimal cost = bookPrice * 4 * fourBookDiscount;
                return cost;
            }
            if (books == 3)
            {
                decimal cost = bookPrice * 3 * threeBookDiscount;
                return cost;
            }
            if (books == 2)
            {
                decimal cost = bookPrice * 2 * twoBookDiscount;
                return cost;
            }
            if (books == 1)
            {
                return bookPrice;
            }
            return 0;
        }
    }
}
