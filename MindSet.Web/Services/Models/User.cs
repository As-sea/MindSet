using SquirrelFramework.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindSet.Web.Services.Models
{
    //最完整的领域对象 随便写
    //Domain Model
    [Collection("UsersTable")]
    public class User:DomainModel
    {
        public string LoginName { get; set; }
        public string DisplayName { get; set; }
        public string Password { set; get; }
        public string Email { set; get; }
    }
}