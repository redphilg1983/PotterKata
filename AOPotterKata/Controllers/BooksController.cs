namespace AOPotterKata.Controllers
{
    using System.Threading.Tasks;
    using Books.Commands;
    using Books.Models;
    using Books.Queries;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator mediator;

        public BooksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetBooksAsync()
        {
            var response = await mediator.Send(new GetBooks());

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> ReturnPrice([FromBody] PriceRequest priceRequest)
        {
            var response = await mediator.Send(new GetPrice(priceRequest));

            return Ok(response);
        }
    }
}
