using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musican_Map.Entites
{
    public  class Instrument
    {

        [Key]
        public int Name { get; set; }

        public int key { get; set; }

        public List<Music_Instrument> music_Instruments { get; set; }

    }
}
