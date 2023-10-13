using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class NoteController : Controller
    {
        CoursesManager coursesManager = new CoursesManager(new EfCoursesDal());
        StudentInfoManager studentManager = new StudentInfoManager(new EfStudentInfoDal());
        public IActionResult Index()
        {
            var student = (from s in studentManager.TGetList()
                           join c in coursesManager.TGetList() on s.StdID equals c.StdID
                           select new StudentWithCourseViewModel { StudentInfo = s, Courses = c }).ToList();


            foreach (var item in student)
            {
                // Her öğrencinin Courses özelliği içindeki Exam1 ve Exam2 değerlerini alın
                double exam1 = item.Courses.Exam1;
                double exam2 = item.Courses.Exam2;

                // Exam1'in %40'ını ve Exam2'nin %60'ını kullanarak ortalama hesaplayın
                double average = (exam1 * 0.4) + (exam2 * 0.6);

                // Hesaplanan ortalama değerini Courses sınıfı içindeki Average değişkenine ata
                item.Courses.Average = average;
            }

            return View(student);

        }
        [HttpGet]
        public IActionResult AddNote()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNote(Courses note)
        {
            coursesManager.TAdd(note);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteNote(int id)
        {
            var note = coursesManager.TGetByID(id);
            coursesManager.TDelete(note);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditNote(int id)
        {
            var note = coursesManager.TGetByID(id);
            return View(note);
        }
        [HttpPost]
        public IActionResult EditNote(Courses note)
        {
            coursesManager.TUpdate(note);
            return RedirectToAction("Index");
        }

    }
}
