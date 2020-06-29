namespace Tests
{
    using Books.Commands;
    using Books.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Threading;

    [TestClass]
    public class GetPriceHandlerTests
    {
        private GetPriceHandler _getPriceHandler;

        [TestInitialize]
        public void Setup()
        {
            this._getPriceHandler = new GetPriceHandler();

        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetPrice_GBP_Match()
        {
            var bookList = new PriceRequest()
            {
                BookList = new BookList
                {
                    Book1 = 0,
                    Book2 = 0,
                    Book3 = 0,
                    Book4 = 0,
                    Book5 = 0
                }
            };

            var priceResponse = new PriceResponse
            {
                GBP = 0m,
                Euro = 0m
            };

            var request = new GetPrice(bookList);
            var cancellationToken = new CancellationToken();

            var expected = new GetPriceResponse(priceResponse).PriceResponse.GBP;
            var actual = await _getPriceHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreEqual(actual.PriceResponse.GBP, expected);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetPrice_Euro_Match()
        {
            var bookList = new PriceRequest()
            {
                BookList = new BookList
                {
                    Book1 = 0,
                    Book2 = 0,
                    Book3 = 0,
                    Book4 = 0,
                    Book5 = 0
                }
            };

            var priceResponse = new PriceResponse
            {
                GBP = 0m,
                Euro = 0m
            };

            var request = new GetPrice(bookList);
            var cancellationToken = new CancellationToken();

            var expected = new GetPriceResponse(priceResponse).PriceResponse.Euro;
            var actual = await _getPriceHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreEqual(actual.PriceResponse.Euro, expected);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetPrice_GBP_Books_Cost_Match()
        {
            var bookList = new PriceRequest()
            {
                BookList = new BookList
                {
                    Book1 = 2,
                    Book2 = 2,
                    Book3 = 2,
                    Book4 = 1,
                    Book5 = 1
                }
            };

            var priceResponse = new PriceResponse
            {
                GBP = 51.20m,
                Euro = 56.32m
            };

            var request = new GetPrice(bookList);
            var cancellationToken = new CancellationToken();

            var expected = new GetPriceResponse(priceResponse).PriceResponse.GBP;
            var actual = await _getPriceHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreEqual(actual.PriceResponse.GBP, expected);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task GetPrice_Euro_Books_Cost_Match()
        {
            var bookList = new PriceRequest()
            {
                BookList = new BookList
                {
                    Book1 = 2,
                    Book2 = 2,
                    Book3 = 2,
                    Book4 = 1,
                    Book5 = 1
                }
            };

            var priceResponse = new PriceResponse
            {
                GBP = 51.20m,
                Euro = 56.32m
            };

            var request = new GetPrice(bookList);
            var cancellationToken = new CancellationToken();

            var expected = new GetPriceResponse(priceResponse).PriceResponse.Euro;
            var actual = await _getPriceHandler.Handle(request, cancellationToken).ConfigureAwait(false);

            Assert.AreEqual(actual.PriceResponse.Euro, expected);
        }
    }
}
