using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class StudentInfo
    {
        [Key]
        public int StdID { get; set; }
        public int TC { get; set; }
        public string StdName { get; set; }
        public string StdSurname { get; set; }
        public int StdNum { get; set; }
        public int StdBirthDay { get; set; }
        public string StdClass { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public int AbsentDay { get; set; }

       
       
    }

}
