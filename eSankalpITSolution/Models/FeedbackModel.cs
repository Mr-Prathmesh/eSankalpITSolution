using eSankalpITSolution.Data;
using System.IO;
using System;
using System.Web;

namespace eSankalpITSolution.Models
{
    public class FeedbackModel
    {
        public int FeedbackId { get; set; }
        public string Name { get; set; }
        public string MobNo { get; set; }
        public string Email { get; set; }
        public string Technology { get; set; }
        public string Office { get; set; }
        public string CompSelected { get; set; }
        public string Feedback1 { get; set; }
        public string Image { get; set; }

        public string Savereg(HttpPostedFileBase fb, FeedbackModel model)
        {
            string msg = "Saved Successfully"; string filepath = ""; string filename = ""; string sysFilename = "";
            string Message = "Successfully submit";

            esankal1_esankalpEntities db = new esankal1_esankalpEntities();
            if(fb != null && fb.ContentLength > 0)
            {
                filepath = HttpContext.Current.Server.MapPath("../Content/img"); DirectoryInfo di = new DirectoryInfo(filepath); if (!di.Exists)
                {
                    di.Create();
                }
                filename = fb.FileName;
                sysFilename = DateTime.Now.ToFileTime().ToString() + Path.GetExtension(fb.FileName);

                fb.SaveAs(filepath + "//" + sysFilename); if (!string.IsNullOrWhiteSpace(fb.FileName))
                {
                    string varfilename =
                    HttpContext.Current.Server.MapPath("../Content/img") + "/" + sysFilename;

                }
            }


            var data = new Feedback()
            {
                FeedbackId = model.FeedbackId,
                Name = model.Name,
                MobNo = model.MobNo,
                Email = model.Email,
                Technology = model.Technology,
                Office = model.Office,
                CompSelected = model.CompSelected,
                Feedback1 = model.Feedback1,
                Image = sysFilename,
            };
            db.Feedbacks.Add(data);
            db.SaveChanges();
            return Message;

        }
    }
}