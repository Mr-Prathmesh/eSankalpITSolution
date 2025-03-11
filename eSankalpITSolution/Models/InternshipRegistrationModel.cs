 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eSankalpITSolution.Data;
namespace eSankalpITSolution.Models
{
    public class InternshipRegistrationModel
    {
        public int RegId { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public decimal Percentage { get; set; }
        public string Service { get; set; }
        public string Technology { get; set; }
        public string Office { get; set; }
        public string College { get; set; }
        public string Address { get; set; }

        public string Savereg(InternshipRegistrationModel model)
        {
            string Message = "Successfully submit";
            esankal1_esankalpEntities db = new esankal1_esankalpEntities();

            var data = new InternshipRegistration()
            {
                RegId = model.RegId,
                Name = model.Name,
                MobileNo = model.MobileNo,
                Email = model.Email,
                Education = model.Education,
                Percentage = model.Percentage,
                Service = model.Service,
                Technology = model.Technology,
                Office = model.Office,
                College = model.College,
                Address = model.Address,
            };
            db.InternshipRegistrations.Add(data);
            db.SaveChanges();
            return Message;
        }


    }
}