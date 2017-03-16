using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;
using Project_Assesment.Models;

namespace Project_Assesment
{
    public class MyIdentity:IIdentity
    {
        public IIdentity Identity { get; set; }
        public UserClienSite User { get; set; }

        public MyIdentity(UserClienSite user)
        {
            Identity = new GenericIdentity(user.Username);
            User = user;
        }

        public string AuthenticationType
        {
            get { return Identity.AuthenticationType; }
        }

        public bool IsAuthenticated
        {
            get { return Identity.IsAuthenticated; }
        }

        public string Name
        {
            get { return Identity.Name; }
        }
    }
}