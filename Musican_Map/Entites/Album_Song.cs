using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Musican_Map.Entites
{
    public class Album_Song
    {

        public int AlbumId { get; set; }

        [Key]
        public string SongTitle { get; set; }
    }
}
