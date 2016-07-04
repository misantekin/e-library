using AutoMapper;
using InfoNovitas.LoginSample.Services.Messaging.Views.Users;

namespace InfoNovitas.LoginSample.Services.Mapping
{
    public static class UserMapper
    {
        public static UserInfo MapToView(this Repositories.DatabaseModel.UserInfo model)
        {
            return new UserInfo()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };
        }
    }
}
