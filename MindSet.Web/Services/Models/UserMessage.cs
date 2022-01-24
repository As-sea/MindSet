using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindSet.Web.Services.Models
{
    [Collection("PeopleMessage")]
    public class UserMessage : DomainModel
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Email { set; get; }
        public string Phone { set; get; }
    }
}