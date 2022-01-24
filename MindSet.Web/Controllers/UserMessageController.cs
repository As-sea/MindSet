using MindSet.Web.Services;
using MindSet.Web.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MindSet.Web.Controllers
{
    public class UserMessageController : ApiController
    {
         
        // GET: api/UserMessage
        public IEnumerable<string> Get()
        {
            if (true)
            {
                var x = new Manageservice();
                  return x.ListPeopleMessage();
            }
            else
            {
return new string[] { "value1", "value2" };
            }
            
        }

        // GET: api/UserMessage/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserMessage
        public void Post(UserMessage people )
        {
            CreatePeopleMessage(people)
        }

        // PUT: api/UserMessage/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserMessage/5
        public void Delete(int id)
        {
        }
    }
}
