using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using System.Collections.Generic;

namespace InfoNovitas.LoginSample.Services.Messaging.Publishers
{
    public class GetPublishersResponse:LibraryResponse
    {
        public List<Publisher> Publishers { get; set; }
    }
}
