using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoNovitas.LoginSample.Repositories;
using InfoNovitas.LoginSample.Services.Mapping;
using InfoNovitas.LoginSample.Services.Messaging.Views.Users;

namespace InfoNovitas.LoginSample.Services.Impl
{
    public class UserService:IUserService
    {
        private IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public UserInfo GetUserInfo(int userId)
        {
            try
            {
                return _repository.FindBy(userId).MapToView();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
