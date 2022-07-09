using MicroserviceShop.IdentityService.Domain;
using System.Collections.Generic;

namespace MicroserviceShop.IdentityService.Repository
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
    public class UserRepository : IUserRepository
    {
        public List<User> GetAll()
        {
            // In reality, the data is received from somewhere like a database.
            return new List<User>
            {
                new User { Username = "Username1" , Password = "Password1"},
                new User { Username = "Username2" , Password = "Password2"},
                new User { Username = "Username3" , Password = "Password3"},
            };
        }
    }
}
