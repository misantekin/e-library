using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoNovitas.LoginSample.Services.Messaging.Publishers;
using InfoNovitas.LoginSample.Repositories;
using InfoNovitas.LoginSample.Services.Mapping;

namespace InfoNovitas.LoginSample.Services.Impl
{
    public class PublisherService : IPublisherService
    {
        private IPublisherRepository _repository;

        public PublisherService(IPublisherRepository repository)
        {
            _repository = repository;
        }
        public GetPublishersResponse GetPublishers()
        {
            var response = new GetPublishersResponse();
            try
            {
                response.Publishers = _repository.FindAll().ToList().MapToViews();
                response.Success = true;
            }
            catch(Exception ex)
            {
                response.Success = false;
            }
            return response;
        }
    }
}
