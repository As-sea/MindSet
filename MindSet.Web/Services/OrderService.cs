using MindSet.Web.Repository;
using MindSet.Web.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindSet.Web.Services
{
    public class OrderService
    {
        public void CreateNote()
        {
            var x = new UserRepository();
            x.Add(new User { Name="Kristen" });
        }
    }
}