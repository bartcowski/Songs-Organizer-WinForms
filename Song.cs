using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMusic
{
    public class Song {
        public String Title { get; set; }
        public String Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }

        public Song(String title, String author, DateTime releaseDate, Genre genre) {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
            Genre = genre;
        }
    }
}
