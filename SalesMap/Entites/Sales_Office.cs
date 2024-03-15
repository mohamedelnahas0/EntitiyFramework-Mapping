using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesMap.Entites
{
    public class Sales_Office
    {
        [Key]
        public int Numbers { get; set; }

        
       // [DataType(DataType.)]
        public string location { get; set; }

        public Employee Emp { get; set; }
        [ForeignKey("Emp")]
        public int EmpId { get; set; }




    }
}
