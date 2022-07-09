using MicroserviceShop.IdentityService.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace MicroserviceShop.IdentityService.Application
{
    public class JwtAuthenticationService : IJwtAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly string _key;

        public JwtAuthenticationService(IUserRepository userRepository, string key)
        {
            _userRepository = userRepository;
            _key = key;
        }
        public string Authenticate(string username, string password)
        {
            var users = _userRepository.GetAll();

            if (!users.Any(u => u.Username == username && u.Password == password)) return null;

            return CreateJwtToken(username);
        }

        private string CreateJwtToken(string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_key);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, username)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
