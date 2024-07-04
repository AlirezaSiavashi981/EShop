using EShop.Infrastructure.Repositories.Implementations;

namespace EShop.Application.Services.Customer
{
    public class CustomerService
    {
        private readonly CustomerRepository _repository;

        public CustomerService(CustomerRepository repository)
        {
            _repository = repository;
        }
    }
}
