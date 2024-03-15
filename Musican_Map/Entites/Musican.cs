using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Musican_Map.Entites
{
    public class Musican
    {
        [Key]
        public int Id { get; set; }

        public  int PhoneNumber { get; set; }

        [Required]
        public string Name { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public List<Music_Song>  Music_Songs { get; set; }

        public List<Music_Instrument>  music_Instruments { get; set; }

    }
}
