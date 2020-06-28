namespace Books.Commands
{
    using Books.Models;

    public class GetPriceResponse
    {
        public GetPriceResponse(PriceResponse prices)
        {
            this.PriceResponse = prices;
        }

        public PriceResponse PriceResponse { get; set; }
    }
}
