namespace EstudoCQRS.Application.Queries.GetCustomerById
{
    public class GetCustomerByIdHandler : IGetCustomerByIdHandler
    {
        public GetCustomerByIdResponse GetCustomerById(GetCustomerByIdRequest request)
        {
            //valida dados
            //chama repositorio

            return new GetCustomerByIdResponse
            {
                Id = 1,//retornoRepository.Id
                Name = "Luis",
                Email = "luis@gmail.com"
            };
        }
    }
}
