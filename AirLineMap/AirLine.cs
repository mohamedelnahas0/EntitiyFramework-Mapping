using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMap
{
    public class AirLine
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Cont_Person { get; set; }
    

    }
}
