using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MindSet.Web.Models
{
    public class UserMessageModel
    {
        public string Id { get; set; }
        
        [DisplayName("Name")]
        public string Name { get; set; }
        
        [DisplayName("Gender")]
        public string Sex { get; set; }
        
        [DisplayName("Mail")]
        public string Email { get; set; }
        
        [DisplayName("PhoneNumber")]
        public string phone { get; set; }

    }
}