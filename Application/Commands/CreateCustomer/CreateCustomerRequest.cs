using MediatR;

namespace EstudoCQRS.Application.Commands.CreateCustomer
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
