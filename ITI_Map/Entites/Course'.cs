using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Map.Entites
{
    public class Course_
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Duration { get; set; }

        public int Description { get; set; }


        public Topic  topic { get; set; }
        [ForeignKey("topic")]
        public int topicId { get; set; }

        public List<Stud_Course> stud_Courses { get; set; }

        public List<Course_Instructot> course_Instructots { get; set; }

    }
}
