using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using System.Web.WebPages;
using MVC5Archer.Models;

namespace MVC5Archer.API.Controllers
{
    public class ActionResultsController : ApiController
    {
        Product[] Products = new Product[]
            {
                new Product {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1},
                new Product {Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M}
            };

        public void Post()
        {

        }

        public HttpResponseMessage Get()
        {

            //HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");
            //response.Content = new StringContent("hello", Encoding.Unicode);
            //response.Headers.CacheControl = new CacheControlHeaderValue()
            //{
            //    MaxAge = TimeSpan.FromMinutes(20)
            //};
            //return response;

            return Request.CreateResponse(HttpStatusCode.OK, Products);
        }

        public IHttpActionResult Get(int id)
        {
            if (Products == null)
            {
                return NotFound(); // Returns a NotFoundResult
            }
            return Ok(Products);  // Returns an OkNegotiatedContentResult
        }
    }
}
