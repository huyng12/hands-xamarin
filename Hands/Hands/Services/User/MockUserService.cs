using System;
using System.Threading.Tasks;

using Hands.Models.User;

namespace Hands.Services.User
{
    public class MockUserService : IUserService
    {
        UserInfo user = new UserInfo
        {
            Id = "huy-nguyen",
            FirstName = "Huy",
            LastName = "Nguyen",
            Email = "touch@nguyenrk.com"
        };

        public async Task<UserInfo> GetCurrentUser()
        {
            return await Task.FromResult(user);
        }

        public async Task<bool> SetAuth(UserInfo user)
        {
            return await Task.FromResult(true);
        }

        public async Task<bool> PurgeAuth()
        {
            user = null;
            return await Task.FromResult(true);
        }
    }
}
