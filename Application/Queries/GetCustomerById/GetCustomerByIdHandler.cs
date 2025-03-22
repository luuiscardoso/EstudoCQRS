using MediatR;

namespace EstudoCQRS.Application.Queries.GetCustomerById
{
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdRequest, GetCustomerByIdResponse>
    {
        public Task<GetCustomerByIdResponse> Handle(GetCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            //valida dados
            //chama repositorio

            var result = new GetCustomerByIdResponse
            {
                Id = request.Id,//retornoRepository.Id
                Name = "Luis",
                Email = "luis@gmail.com"
            };

            return Task.FromResult(result);
        }
    }
}
