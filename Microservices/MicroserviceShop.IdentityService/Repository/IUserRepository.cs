using MicroserviceShop.IdentityService.Domain;
using System.Collections.Generic;

namespace MicroserviceShop.IdentityService.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
