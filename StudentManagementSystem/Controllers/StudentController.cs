using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        StudentInfoManager studentManager = new StudentInfoManager(new EfStudentInfoDal());
        public IActionResult Index()
        {
            //var students = (from s in studentManager.TGetList()
            //                select new StudentWithCourseViewModel { StudentInfo = s }).ToList();
            var students = studentManager.TGetList();
         
            return View(students);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddStudent(StudentInfo student) 
        {
            studentManager.TAdd(student);
            return RedirectToAction("Index");
            
        }

        public IActionResult DeleteStudent(int id)
        {
            var student = studentManager.TGetByID(id);
            studentManager.TDelete(student);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var student = studentManager.TGetByID(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult EditStudent(StudentInfo student)
        {
            studentManager.TUpdate(student);
            return RedirectToAction("Index");
        }
    }
}
