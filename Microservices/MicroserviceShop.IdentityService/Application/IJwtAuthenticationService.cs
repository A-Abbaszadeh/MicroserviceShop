namespace MicroserviceShop.IdentityService.Application
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string username, string password);
    }
}
