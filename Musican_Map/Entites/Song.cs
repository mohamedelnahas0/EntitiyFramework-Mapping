using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musican_Map.Entites
{
    public class Song
    {

        [Key]
        public string Title { get; set; }

        public string Author { get; set; }

        public List<Album_Song>  album_Songs { get; set; }

        public List<Music_Song> Music_Songs { get; set; }

    }
}
