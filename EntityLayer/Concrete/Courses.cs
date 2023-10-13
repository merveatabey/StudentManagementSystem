using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public double Exam1 { get; set; }
        public double Exam2 { get; set; }
        public double Average { get; set; } = 0;
        public int StdID { get; set; }
        public int DepartmentID { get; set; }
        public List<StudentInfo> StudentInfos { get; set; }
        public List<Department> Departments { get; set; }
        
    }
}
