using Books.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Commands
{
    public class GetPrice : IRequest<GetPriceResponse>
    {
        public GetPrice(PriceRequest priceRequest)
        {
            this.PriceRequest = priceRequest;
        }

        public PriceRequest PriceRequest { get; set; }
    }
}
