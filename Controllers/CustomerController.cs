using EstudoCQRS.Application.Commands.CreateCustomer;
using EstudoCQRS.Application.Queries.GetCustomerById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstudoCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public Task<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest command)
        {
            return _mediator.Send(command);
        }

        [HttpGet("{id:int}")]
        public Task<GetCustomerByIdResponse> GetCustomer(int id)
        {
            GetCustomerByIdRequest queryCommand = new GetCustomerByIdRequest(id);
            return _mediator.Send(queryCommand);
        }
    }
}
