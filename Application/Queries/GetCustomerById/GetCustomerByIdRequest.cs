using MediatR;

namespace EstudoCQRS.Application.Queries.GetCustomerById
{
    public class GetCustomerByIdRequest : IRequest<GetCustomerByIdResponse>
    {
        public int Id { get; set; }
        public GetCustomerByIdRequest(int id)
        {
            Id = id;
        }
    }
}
