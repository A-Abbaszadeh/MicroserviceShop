using MicroserviceShop.IdentityService.Repository;
using System.Linq;

namespace MicroserviceShop.IdentityService.Application
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string username, string password);
    }

    public class JwtAuthenticationService : IJwtAuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public JwtAuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public string Authenticate(string username, string password)
        {
            var users = _userRepository.GetAll();

            if (!users.Any(u => u.Username == username && u.Password == password)) return null;

            throw new System.NotImplementedException();
        }
    }
}
