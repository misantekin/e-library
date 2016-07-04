using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Authentication
{
    public class AuthRepository : IDisposable
    {
        private readonly MyUserManager _userManager;
        private readonly ApplicationDbContext _ctx;

        public AuthRepository()
        {
            _userManager = MyUserManager.Initialize();
            _ctx = new ApplicationDbContext();
        }

        public async Task<MyUser> FindUserAsync(string userName, string password)
        {
            var user = await _userManager.FindAsync(userName, password);
            return user;
        }

        public MyUser FindUser(string username, string password)
        {
            return AsyncHelpers.RunSync<MyUser>(() => _userManager.FindAsync(username, password));
        }

        public async Task<long> CreateUser(string username, string email, string password, Dictionary<string, string> claims)
        {
            var user = new MyUser
            {
                UserName = username,
                Email = email

            };
            var result =
                AsyncHelpers.RunSync(() => _userManager.CreateAsync(user, password));

            if (!result.Succeeded)
                throw new Exception("User not created");

            var findUser = AsyncHelpers.RunSync(() => _userManager.FindAsync(username, password));
            if (findUser == null)
                throw new Exception("User not created");

            foreach (var claim in claims)
            {
                AsyncHelpers.RunSync(() => _userManager.AddClaimAsync(findUser.Id, new Claim(claim.Key, claim.Value)));
            }

            return findUser.Id;
        }


        public void Dispose()
        {
            _userManager.Dispose();
        }
    }
}
