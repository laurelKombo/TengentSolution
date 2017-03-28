using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Assesment.Models;
using System.Web.Security;
using System.Web.Script.Serialization;

namespace Project_Assesment.Controllers
{
    public class MyAccountController : Controller
    {
        //
        // GET: /MyAccount/

        public ActionResult Login()
        {
            return View();
        }

            //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(UserClienSite client, string ReturnUrl = "")
        //{

        //    if (ModelState.IsValid)
        //    {
        //        bool isValidUser = Membership.ValidateUser(client.Username, client.Password);
        //        if (isValidUser)
        //        {
        //            UserClienSite user = null;
        //            user = Repositories.UserRepository.findOne(client.Username, client.Password);

        //            if (user != null)
        //            {
        //                JavaScriptSerializer js = new JavaScriptSerializer();
        //                string data = js.Serialize(user);
        //                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, user.Username, DateTime.Now, DateTime.Now.AddMinutes(30), client.RememberMe, data);
        //                string encToken = FormsAuthentication.Encrypt(ticket);
        //                HttpCookie authoCookies = new HttpCookie(FormsAuthentication.FormsCookieName, encToken);
        //                Response.Cookies.Add(authoCookies);
        //                return Redirect(ReturnUrl);
        //            }
        //        }
        //    }
        //    ModelState.Remove("Password");
        //    return View();
        //}

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}
