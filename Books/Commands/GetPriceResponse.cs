using Books.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Commands
{
    public class GetPriceResponse
    {
        public GetPriceResponse(PriceResponse prices)
        {
            this.PriceResponse = prices;
        }

        public PriceResponse PriceResponse { get; set; }
    }
}
