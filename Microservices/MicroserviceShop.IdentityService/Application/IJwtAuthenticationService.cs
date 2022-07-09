namespace MicroserviceShop.IdentityService.Application
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string username, string password);
    }

    public class JwtAuthenticationService : IJwtAuthenticationService
    {
        public string Authenticate(string username, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}
