using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CoursesManager : ICoursesService
    {

        ICoursesDal _coursesDal;

        public CoursesManager(ICoursesDal coursesDal)
        {
            _coursesDal = coursesDal;
        }

        public void TAdd(Courses t)
        {
            _coursesDal.Insert(t);
        }

        public void TDelete(Courses t)
        {
            _coursesDal.Delete(t);
        }

        public Courses TGetByID(int id)
        {
            return _coursesDal.GetByID(id);
        }

        public List<Courses> TGetList()
        {
            return _coursesDal.GetList();
        }

        public void TUpdate(Courses t)
        {
            _coursesDal.Update(t);
        }
    }
}
