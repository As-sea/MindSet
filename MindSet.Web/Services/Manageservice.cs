using MindSet.Web.Repository;
using MindSet.Web.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MindSet.Web.Services
{
    public class Manageservice
    {
        public void CreatePeopleMessage(UserMessage people)
        {
            
            var create = new UserMessageRepository();
            create.Add(new UserMessage { 
                Name=people.Name ,
                Sex=people.Sex,
                Email=people.Email,
                Phone=people.Phone
            });

        }


        public List<UserMessage> ListPeopleMessage()
        {
            var peopleList = new List<UserMessage>();
            var list = new UserMessageRepository();
            foreach(var aPeople in list.GetAll())
            {
                peopleList.Add(aPeople); 
            }
            return peopleList;
        }
    }
}