using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musican_Map.Entites
{
   public class Album
    {
        [Key]
        public int Id { get; set; }

        public string title { get; set; }


        public DateTime date { get; set; }


        public Musican musican { get; set; }
        [ForeignKey("musicabId")]
        public int musicanId { get; set; }

        public List<Album_Song> album_Songs { get; set; }
    }
}
