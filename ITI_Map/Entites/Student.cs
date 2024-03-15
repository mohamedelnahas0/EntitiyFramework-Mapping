using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Map.Entites
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }

        public string Adress { get; set; }

        public Departments departments  { get; set; }
        [ForeignKey("DepId")]
        public int departmentsId{ get; set; }

        public List<Stud_Course> stud_Courses { get; set; }
    }
}
