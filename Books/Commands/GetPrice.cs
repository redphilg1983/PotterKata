namespace Books.Commands
{
    using Books.Models;
    using MediatR;

    public class GetPrice : IRequest<GetPriceResponse>
    {
        public GetPrice(PriceRequest priceRequest)
        {
            PriceRequest = priceRequest;
        }

        public PriceRequest PriceRequest { get; set; }
    }
}
