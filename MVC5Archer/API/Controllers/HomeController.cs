﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC5Archer.API.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public string Index()
        {
            return "homeapi";
        }
    }
}
