using System.Collections.Generic;
using System.Linq;
using InfoNovitas.LoginSample.Repositories.DatabaseModel;

namespace InfoNovitas.LoginSample.Repositories.Users
{
    public class UserRepository:IUserRepository
    {
        public List<UserInfo> FindAll()
        {
            using (var context = new IdentityExDbEntities())
            {
                return context.UserInfoes.ToList();
            }
        }

        public UserInfo FindBy(int key)
        {
            using (var context = new IdentityExDbEntities())
            {
                return context.UserInfoes.FirstOrDefault(user => user.Id == key);
            }
        }

        #region Not implemented

        public int Add(UserInfo item)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(UserInfo item)
        {
            throw new System.NotImplementedException();
        }

        public UserInfo Save(UserInfo item)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
