using System;
using System.Threading.Tasks;

using Hands.Models.User;

namespace Hands.Services.User
{
    public interface IUserService
    {
        Task<bool> SetAuth(UserInfo user);
        Task<bool> PurgeAuth();
        Task<UserInfo> GetCurrentUser();
    }
}
