using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using OnlineCourse.Domain.Entities.Users;
using OnlineCourse.Service.Helpers;
using OnlineCourse.Service.Interfaces.Auth;
using Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourse.Service.Services.Auth
{
    public class TokenService : ITokenService
    {
        private IConfiguration _config;

        public TokenService(IConfiguration configuration)
        {
            this._config = configuration.GetSection("Jwt");
        }
        public string GenerateToken(User user)
        {
            var IdentityClaims = new Claim[]
            {
                new Claim ("Id", user.Id.ToString()),
                new Claim ("FirstName", user.Id.ToString()),
                new Claim("gmail", user.Gmail.ToString()),
                new Claim(ClaimTypes.Role, user.UserRole.Name.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecurityKey"]!));
            var keycredientials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _config["Issuer"],
                audience: _config["Audience"],
                claims: IdentityClaims,
                expires: TimeHelper.GetDateTime(),
                signingCredentials: keycredientials);

            return new JwtSecurityTokenHandler().WriteToken(token); 
        }
    }
}
