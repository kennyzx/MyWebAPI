using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCWebAPI.Models;

namespace MVCWebAPI.Controllers
{
    public class DVDController : ApiController
    {
        public List<DVD> GetAllDVDsListedInStore()
        {
            return new List<DVD>()
            {
                new DVD { Title = "Win10 Home", Price = 99.99 },
                new DVD { Title = "Win10 Pro", Price = 199.99 }
            };
        }
    }
}
