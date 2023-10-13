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
    public class StudentInfoManager : IStudentInfoService
    {
        IStudentInfoDal _studentInfoDal;

        public StudentInfoManager(IStudentInfoDal studentInfoDal)
        {
            _studentInfoDal = studentInfoDal;
        }

        public void TAdd(StudentInfo t)
        {
            _studentInfoDal.Insert(t);
        }

        public void TDelete(StudentInfo t)
        {
            _studentInfoDal.Delete(t);
        }

        public StudentInfo TGetByID(int id)
        {
            return _studentInfoDal.GetByID(id);
        }

        public List<StudentInfo> TGetList()
        {
            return _studentInfoDal.GetList();
        }

        public void TUpdate(StudentInfo t)
        {
            _studentInfoDal.Update(t);
        }
    }
}
