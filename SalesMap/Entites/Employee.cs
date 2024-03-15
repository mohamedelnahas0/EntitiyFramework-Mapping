using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesMap.Entites
{
    public  class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Sales_Office salesOffice { get; set; }
        [ForeignKey("offnumber")]
        public int salesOfficeNumber { get; set; }
    }
}
