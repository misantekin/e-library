using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Services.Mapping
{
    public static class PublisherMapper
    {
        public static Publisher MapToView(this Repositories.DatabaseModel.Publisher model)
        {
            if (model == null)
                return null;
            return new Publisher()
            {
                Id = model.Id,
                Active = model.Active,
                DateCreated = model.DateCreated,
                Description = model.Description,
                LastModified = model.LastModified,
                Name = model.Name,
                Url = model.Url,
                UserCreated = new Messaging.Views.Users.UserInfo()
                {
                    Id = model.UserCreated
                },
                UserLastModified = new Messaging.Views.Users.UserInfo()
                {
                    Id = model.UserLastModified.GetValueOrDefault()
                }
            };
        }

        public static List<Publisher> MapToViews(this List<Repositories.DatabaseModel.Publisher> models)
        {
            var result = new List<Publisher>();
            if (models == null)
                return result;

            foreach(var item in models)
            {
                result.Add(item.MapToView());
            }
            return result;
        }
    }
}
