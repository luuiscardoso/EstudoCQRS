using MediatR;

namespace EstudoCQRS.Application.Commands.CreateCustomer
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //valida as informações
            //chama o repositorio 
            //repositorio faz a logica

            var result = new CreateCustomerResponse
            {
                IdGerado = 1,//retornoRepository.Id
                Name = request.Name,
                Email = request.Email
            };

            return Task.FromResult(result);
        }
    }
}
