namespace EstudoCQRS.Application.Commands.CreateCustomer
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse CreateCustomerHandle(CreateCustomerRequest request)
        {
            //valida as informações
            //chama o repositorio 
            //repositorio faz a logica

            return new CreateCustomerResponse
            {
                IdGerado = 1,//retornoRepository.Id
                Name = request.Name,
                Email = request.Email
            };
        }
    }
}
