using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Listener.DB;
using Listener.Entity;
using OrmLite.Pack.DTO;

namespace Listener.API.Controllers
{
    public class HomeController : ApiController
    {
        SoulTravellerDb svc = new SoulTravellerDb();
        public PageResult<SoulTraveller> GetPage()
        {
            return svc.PageList(0, 20);
        }
    } 
}
    