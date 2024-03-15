using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Map.Entites
{
    public class Departments
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime HiringDate { get; set; }

        public Instructor instructor { get; set; }
        [ForeignKey("instructor")]
        public int instructorID { get; set; }
    }
}
