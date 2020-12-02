using OnlineEducationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineEducationSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "History";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information";

            return View();
        }
        public ActionResult Achievements()
        {


            return View();
        }
        public ActionResult newsEvents()
        {


            return View();
        }
        public ActionResult other()
        {


            return View();
        }
        public ActionResult Fee()
        {


            return View();
        }
        public ActionResult CSEFaculty()
        {


            return View();
        }
        public ActionResult ECEFaculty()
        {


            return View();
        }
        public ActionResult CSECourseI()
        {


            return View();
        }
        public ActionResult ECECourseI()
        {


            return View();
        }
        public ActionResult CSECourseII()
        {


            return View();
        }
        public ActionResult ECECourseII()
        {


            return View();
        }
        public ActionResult CSECourseIII()
        {


            return View();
        }
        public ActionResult ECECourseIII()
        {


            return View();
        }
        public ActionResult CSECourseIV()
        {


            return View();
        }
        public ActionResult ECECourseIV()
        {


            return View();
        }
        
        public ActionResult StudentLogin()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult StudentLogin1(string uname,string password)
        {

            OESEntities2 db = new OESEntities2();
            Student student = db.Students.SingleOrDefault(x=>x.SId==uname && x.DOB==password);
            StudentViewModel studentVM = new StudentViewModel();
            if (student == null)
            {
                
                return RedirectToAction("Error","Home");
            }
            else {

                studentVM.SId = student.SId;
                studentVM.SName = student.SName;
                studentVM.DOB = student.DOB;
                studentVM.FatherName = student.FatherName;
                studentVM.MotherName = student.MotherName;
                studentVM.MobileNumber = student.MobileNumber;
                studentVM.AlternateMobileNumber = student.AlternateMobileNumber;
                studentVM.Email = student.Email;
                studentVM.Address = student.Address;
                studentVM.Branch = student.Branch;


                return View(studentVM);
            }
            
        }
        public ActionResult GetStudents()
        {
            OESEntities2 db = new OESEntities2();
            List<Student> students = db.Students.ToList();
            return View(students);
        }

        public ActionResult FacultyLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FacultyLogin1(string uname, string password)
        {
            OESEntities2 db = new OESEntities2();
            Faculty faculty = db.Faculties.SingleOrDefault(x => x.FId == uname && x.FDOB == password);
            FacultyViewModel facultyVM = new FacultyViewModel();
            if (faculty == null)
            {

                return RedirectToAction("Error1", "Home");
            }
            else
            {

                facultyVM.FId = faculty.FId;
                facultyVM.FName = faculty.FName;
                facultyVM.FBranch = faculty.FBranch;
                facultyVM.MobileNumber = faculty.MobileNumber;
                facultyVM.Email = faculty.Email;
                facultyVM.Address = faculty.Address;
                facultyVM.FDOB = faculty.FDOB;
                facultyVM.Qualification = faculty.Qualification;




                return View(facultyVM);
            }
        }
        public ActionResult GetFaculty()
        {
            OESEntities2 db = new OESEntities2();
            List<Faculty> faculties = db.Faculties.ToList();
            return View(faculties);
        }
        public ActionResult HODLogin()
        {


            return View();
        }
        [HttpPost]
        public ActionResult HODLogin1(string uname, string password)
        {
            OESEntities2 db = new OESEntities2();
            HOD hod = db.HODs.SingleOrDefault(x => x.HId == uname && x.HDOB == password);
            HODViewModel hodVM = new HODViewModel();
            if (hod == null)
            {

                return RedirectToAction("Error2", "Home");
            }
            else
            {

               hodVM.HId = hod.HId;
                hodVM.HName = hod.HName;
                hodVM.HDOB = hod.HDOB;
                hodVM.HBranch = hod.HBranch;
                hodVM.Qualification = hod.Qualification;
                hodVM.HMobileNumber = hod.HMobileNumber;
                hodVM.HEmail = hod.HEmail;
                hodVM.HAddress = hod.HAddress;
                
                




                return View(hodVM);
            }
        }
        public ActionResult GetHOD()
        {
            OESEntities2 db = new OESEntities2();
            List<HOD> hods = db.HODs.ToList();
            return View(hods);
        }
        public ActionResult HeadLogin()
        {


            return View();
        }
        [HttpPost]
        public ActionResult HeadLogin1(string uname, string password)
        {
            OESEntities2 db = new OESEntities2();
            HEAD head = db.HEADs.SingleOrDefault(x => x.PId == uname && x.PDOB == password);
            HeadViewModel headVM = new HeadViewModel();
            if (head == null)
            {

                return RedirectToAction("Error3", "Home");
            }
            else
            {

                headVM.PId = head.PId;
                headVM.PName = head.PName;
                headVM.PDOB = head.PDOB;
                headVM.PQualification = head.PQualification;
                headVM.PMobileNumber = head.PMobileNumber;
                headVM.PEmail = head.PEmail;
                headVM.PAddress = head.PAddress;
               




                return View(headVM);
            }
        }
        public ActionResult Error3()
        {


            return View();
        }
        public ActionResult Error2()
        {


            return View();
        }
        public ActionResult Error1()
        {


            return View();
        }
        public ActionResult Error()
        {


            return View();
        }


    }
}