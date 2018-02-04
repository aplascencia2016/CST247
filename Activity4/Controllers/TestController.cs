using Activity4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity4.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel("Mark Reha", "mreha@stud.com", "123-333-4567"));
            users.Add(new UserModel("Mary Reha", "mreha@studdet.com", "123-333-7654"));
            users.Add(new UserModel("Justine Dingee", "beautiful@always.com", "111-333-4567"));
            users.Add(new UserModel("Brianna Reha", "stunning@redhead.com", "222-333-4567"));

            return View("Test",users);
        }
    }
}