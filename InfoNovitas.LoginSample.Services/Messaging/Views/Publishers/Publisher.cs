using InfoNovitas.LoginSample.Services.Messaging.Views.Users;
using System;

namespace InfoNovitas.LoginSample.Services.Messaging.Views.Publishers
{
    public class Publisher
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset? LastModified { get; set; }

        public UserInfo UserCreated { get; set; }
        public UserInfo UserLastModified { get; set; }
    }
}
