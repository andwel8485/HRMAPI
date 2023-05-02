using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthenticationManager.Model;
using Microsoft.IdentityModel.Tokens;

namespace JwtAuthenticationManager
{
	public class JwtTokenHandler
	{
		public const string JWT_Secret_Key = "cThIIoDvwdueQB468K5xDc5633seEFoqwxjF_xSJyQQ";
		private readonly int JWT_Token_Validity_Min = 20;
		public JwtTokenHandler() { }

		public AuthenticationResponse GenerateToken(AuthenticaionRequest authenticaionRequest, string role)
		{
			

			// start working on Jwt Token need ExpiryTime, TokenKey, claimIdentity

			var tokenExpiryTime = DateTime.UtcNow.AddMinutes(JWT_Token_Validity_Min);
			var tokenKey = Encoding.ASCII.GetBytes(JWT_Secret_Key);
			var claimsIndetity = new ClaimsIdentity(new List<Claim>
			{
				new Claim(ClaimTypes.NameIdentifier, authenticaionRequest.Username),
				new Claim(ClaimTypes.Role, role)

			});

			var securityKey = new SymmetricSecurityKey(tokenKey);
			var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claimsIndetity,
                Expires = tokenExpiryTime,
                SigningCredentials = signingCredentials

            };

            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

			var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

            var token = jwtSecurityTokenHandler.WriteToken(securityToken);

            return new AuthenticationResponse { Token = token, ExpiresIn = (int)tokenExpiryTime.Subtract(DateTime.Now).TotalSeconds, Username = authenticaionRequest.Username };


        }
    }
}

