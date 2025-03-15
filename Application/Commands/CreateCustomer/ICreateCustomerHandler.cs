namespace EstudoCQRS.Application.Commands.CreateCustomer
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse CreateCustomerHandle(CreateCustomerRequest request);
    }
}
