using IdentityModel;
using MBRSolutions.Services.Identity.DBContext;
using MBRSolutions.Services.Identity.HelperModules;
using MBRSolutions.Services.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace MBRSolutions.Services.Identity
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public DbInitializer(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Initialize()
        {
            if (_roleManager.FindByNameAsync(Config.Admin).Result == null)
            {
                _roleManager.CreateAsync(new IdentityRole(Config.Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(Config.Customer)).GetAwaiter().GetResult();
            }
            else
            {
                return;
            }


            //create new user for admin

            ApplicationUser adminUser = new()
            {
                UserName="Admin",
                Email= "admin1126@yahoo.com",
                EmailConfirmed=true,
                PhoneNumber="839495455",
                FirstName="Aladdine",
                LastName="Alcala"

            };
           
            _userManager.CreateAsync(adminUser,"pass4admin*123").GetAwaiter().GetResult();

            _userManager.AddToRoleAsync(adminUser, Config.Admin).GetAwaiter().GetResult();


          var user1=_userManager.AddClaimsAsync(adminUser, new[]
            {
                new Claim(JwtClaimTypes.Name,adminUser.FirstName + " " + adminUser.LastName),
                new Claim(JwtClaimTypes.GivenName,adminUser.FirstName + " " + adminUser.LastName),
                new Claim(JwtClaimTypes.FamilyName,adminUser.LastName),
                new Claim(JwtClaimTypes.Email,adminUser.Email),
                new Claim(JwtClaimTypes.PhoneNumber,adminUser.PhoneNumber),
                new Claim(JwtClaimTypes.Role,Config.Admin),
                new Claim(JwtClaimTypes.EmailVerified, adminUser.EmailConfirmed.ToString(), ClaimValueTypes.Boolean)
            }).Result;



            //create new user for customer
            ApplicationUser cusUser = new()
            {
                UserName = "Cususer",
                Email = "cusUser1126@yahoo.com",
                EmailConfirmed = true,
                PhoneNumber = "831194955",
                FirstName = "Jourgena",
                LastName = "Taneo"

            };

            _userManager.CreateAsync(cusUser, "pass4user").GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(cusUser, Config.Customer).GetAwaiter().GetResult();


            var user2 = _userManager.AddClaimsAsync(cusUser, new[]
              {
                new Claim(JwtClaimTypes.Name,cusUser.FirstName + " " + cusUser.LastName),
                new Claim(JwtClaimTypes.GivenName,cusUser.FirstName + " " + cusUser.LastName),
                new Claim(JwtClaimTypes.FamilyName,cusUser.LastName),
                new Claim(JwtClaimTypes.Email,cusUser.Email),
                new Claim(JwtClaimTypes.PhoneNumber,cusUser.PhoneNumber),
                new Claim(JwtClaimTypes.Role,Config.Customer),
                new Claim(JwtClaimTypes.EmailVerified, cusUser.EmailConfirmed.ToString(), ClaimValueTypes.Boolean)
            }).Result;


        }
    }
}
