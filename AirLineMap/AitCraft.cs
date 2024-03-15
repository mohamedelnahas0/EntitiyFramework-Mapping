using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AirLineMap
{
    public class AitCraft
    {
        [Key]
        public int ID { get; set; }
        public string Capactiy { get; set; }
        public string Model { get; set; }
        public string Pash_Pilot { get; set; }
        public string Assistant { get; set; }
        public string Host1 { get; set; }
        public string Host2 { get; set; }


    }
}
