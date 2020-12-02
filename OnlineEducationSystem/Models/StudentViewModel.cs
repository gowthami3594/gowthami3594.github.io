using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineEducationSystem.Models
{
    public class StudentViewModel
    {
        public string SId { get; set; }
        public string SName { get; set; }
        public string DOB { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string MobileNumber { get; set; }
        public string AlternateMobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Branch { get; set; }
    }
}