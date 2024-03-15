using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Map.Entites
{
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

      
        public string Adress { get; set; }

       
        public int Bonus { get; set; }

        public int Salary { get; set; }

        public int Hour_rate { get; set; }

        public Departments departments { get; set; }
        [ForeignKey("DepId")]
        public int departmentsId { get; set; }


        public List<Course_Instructot> course_Instructots { get; set; }
    }
    }

