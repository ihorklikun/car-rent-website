using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace CarRentWebsite.Options
{
    public class AuthData
    {

        public string Token { get; set; }
        public long TokenExpirationTime { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string RoleName { get; set; }
        public int RoleId { get; set; }
    }
}
