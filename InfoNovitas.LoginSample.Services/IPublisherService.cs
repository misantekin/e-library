﻿using InfoNovitas.LoginSample.Services.Messaging.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoNovitas.LoginSample.Services
{
    public interface IPublisherService
    {
        GetPublishersResponse GetPublishers();
    }
}
