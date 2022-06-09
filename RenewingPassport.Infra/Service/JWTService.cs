using Microsoft.IdentityModel.Tokens;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class JWTService: IJWTService
    {
        private readonly IJWTRepository iJWTRepository;

        public JWTService(IJWTRepository _iJWTRepository)
        {
            iJWTRepository = _iJWTRepository;
        }


        public string Auth(Pr_Userlogin login)
        {
            var result = iJWTRepository.Auth(login);
            if (result == null)//doesn't match any username and password in DB (Not Authorized User)
            {
                return null;
            }
            else
            {

                //1- token handler : اللي رح يعمل كريت للtoken
                var tokenhandler = new JwtSecurityTokenHandler();



                //2- token key : private key used in encryption method to encrypt data.



                var tokenKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]"));



                //3- descriptor : result(payload) + more prop.
                var tokendescriptor = new SecurityTokenDescriptor
                {
                    //subject : claimidentity
                    Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, result.Email),
                    new Claim(ClaimTypes.Role, result.Rolename)



                }),
                    Expires = DateTime.UtcNow.AddYears(1),//session timeout
                    SigningCredentials = new SigningCredentials(tokenKey, SecurityAlgorithms.HmacSha256)



                };
                var token = tokenhandler.CreateToken(tokendescriptor);
                return tokenhandler.WriteToken(token); //return string value {Token}



            }
        }

     
    }
}
