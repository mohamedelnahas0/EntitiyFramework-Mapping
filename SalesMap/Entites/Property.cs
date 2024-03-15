using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMap.Entites
{
    public  class Property
    {

        public int Id { get; set; }
       
        public string Adress { get; set; }
        
        public string City { get; set; }

      
        public string State { get; set; }


        [DataType(DataType.PostalCode)]
        public string Code { get; set; }

        public Sales_Office salesOffices { get; set; }
        [ForeignKey("offnumbers")]
        public int salesOfficesNumber { get; set; }

        public List<Prop_Owner> prop_Owners { get; set; }
    }
}
