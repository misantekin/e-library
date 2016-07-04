using InfoNovitas.LoginSample.Services.Messaging.Views.Publishers;
using InfoNovitas.LoginSample.Web.Api.Models.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InfoNovitas.LoginSample.Web.Api.Mapping
{
    public static class PublisherMapping
    {
        public static PublisherViewModel MapToViewModel(this Publisher view)
        {
            if (view == null)
                return null;
            return new PublisherViewModel()
            {
                Id = view.Id,
                Name = view.Name,
                Description = view.Description,
                Url = view.Url
            };
        }

        public static List<PublisherViewModel> MapToViewModels(this List<Publisher> views)
        {
            var result = new List<PublisherViewModel>();
            if (views == null)
                return result;
            foreach(var item in views)
            {
                result.Add(item.MapToViewModel());
            }
            return result;
        }
    }
}