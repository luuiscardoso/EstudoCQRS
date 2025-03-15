using EstudoCQRS.Application.Commands.CreateCustomer;
using EstudoCQRS.Application.Queries.GetCustomerById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstudoCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICreateCustomerHandler _createCustomerHandler;
        private readonly IGetCustomerByIdHandler _getCustomerByIdHandler;

        public CustomerController(ICreateCustomerHandler createCustomerHandler, IGetCustomerByIdHandler getCustomerByIdHandler)
        {
            _createCustomerHandler = createCustomerHandler;
            _getCustomerByIdHandler = getCustomerByIdHandler;
        }

        [HttpPost]
        public CreateCustomerResponse CreateCustomer(CreateCustomerRequest command)
        {
            return _createCustomerHandler.CreateCustomerHandle(command);
        }

        [HttpGet("{id:int}")]
        public GetCustomerByIdResponse GetCustomer(int id)
        {
            GetCustomerByIdRequest queryCommand = new GetCustomerByIdRequest(id);
            return _getCustomerByIdHandler.GetCustomerById(queryCommand);
        }
    }
}
