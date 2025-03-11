using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using eSankalpITSolution.Models;

namespace eSankalpITSolution.Controllers
{
    public class IntershipRegistrationController : Controller
    {
        // GET: IntershipRegistration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Savereg(InternshipRegistrationModel model)
        {
            try
            {
                return Json(new { Message = (new InternshipRegistrationModel().Savereg(model)) }, JsonRequestBehavior.AllowGet);

            }
            catch(Exception ex)
            {
                return Json(new {ex.Message},JsonRequestBehavior.AllowGet);
            }
            

            
        }

    }
}