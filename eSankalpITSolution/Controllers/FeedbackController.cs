using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eSankalpITSolution.Models;

namespace eSankalpITSolution.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public ActionResult FeedbackIndex()
        {
            return View();
        }
        public ActionResult Savereg(FeedbackModel model)
        {
            try
            {
                HttpPostedFileBase fb = null; for (int i = 0; i < Request.Files.Count; i++)
                {
                    fb = Request.Files[i];
                }
                return Json(new { Message = (new FeedbackModel().Savereg(fb, model)) },
                    JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}