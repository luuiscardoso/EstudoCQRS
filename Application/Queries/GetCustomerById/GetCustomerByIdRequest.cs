namespace EstudoCQRS.Application.Queries.GetCustomerById
{
    public class GetCustomerByIdRequest
    {
        public int Id { get; set; }
        public GetCustomerByIdRequest(int id)
        {
            Id = id;
        }
    }
}
