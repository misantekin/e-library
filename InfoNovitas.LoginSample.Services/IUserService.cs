using InfoNovitas.LoginSample.Services.Messaging.Views.Users;

namespace InfoNovitas.LoginSample.Services
{
    public interface IUserService
    {
        UserInfo GetUserInfo(int userId);
    }
}