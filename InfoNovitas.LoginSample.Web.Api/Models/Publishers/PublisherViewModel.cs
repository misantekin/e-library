using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoNovitas.LoginSample.Web.Api.Models.Publishers
{
    public class PublisherViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}