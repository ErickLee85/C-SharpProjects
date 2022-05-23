using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using System.Data.Entity;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var users = db.Insurees;
                var userList = new List<InsureeUser>();
                foreach( var user in users)
                {
                    var theUser = new InsureeUser();
                    theUser.Quote = user.Quote;
                    theUser.FirstName = user.FirstName;
                    theUser.LastName = user.LastName;
                    theUser.EmailAddress = user.EmailAddress;
                    userList.Add(theUser);
                }
                return View(userList);
            }
            
        }
    }
}