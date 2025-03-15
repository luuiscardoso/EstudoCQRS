namespace EstudoCQRS.Application.Queries.GetCustomerById
{
    public interface IGetCustomerByIdHandler
    {
        GetCustomerByIdResponse GetCustomerById(GetCustomerByIdRequest request);
    }
}
