using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMap.Entites
{
    public class Owner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Prop_Owner>  prop_Owners { get; set; }
    }
}
