using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMusic {
    public class SongsRepository {
        private List<Song> songs = new List<Song>();

        public event Action<Song> AddSongEvent;
        public event Action<Song> EditSongEvent;
        public event Action<Song> DeleteSongEvent;

        public SongsRepository() {
            initWithTestSongs();
        }

        public List<Song> getSongs() {
            return songs;
        }

        public void addSong(Song song) {
            songs.Add(song);
            AddSongEvent?.Invoke(song);
        }

        public void editSong(Song song) {
            EditSongEvent?.Invoke(song);
        }

        public void deleteSong(Song song) {
            songs.Remove(song);
            DeleteSongEvent?.Invoke(song);
        }

        private void initWithTestSongs() {
            songs.Add(new Song("Auau", "Hendryx", new DateTime(1989, 12, 10), Genre.ROCK));
            songs.Add(new Song("Hx Add", "3puck", new DateTime(2012, 1, 9), Genre.HIPHOP));
            songs.Add(new Song("Yellow", "Cash and Money", new DateTime(2020, 6, 19), Genre.POP));
            songs.Add(new Song("In The Dark", "Urban-339", new DateTime(1999, 3, 26), Genre.ROCK));
            songs.Add(new Song("I'm Still Lying", "Eldon Phon", new DateTime(2000, 11, 19), Genre.POP));
            songs.Add(new Song("Sour Friend of Them", "Pistols & Tulips", new DateTime(1970, 4, 1), Genre.ROCK));
            songs.Add(new Song("Keke Pepe", "Pepe", new DateTime(2018, 7, 7), Genre.ROCK));
            songs.Add(new Song("Dr Mad", "Mine 'Em", new DateTime(1994, 2, 25), Genre.HIPHOP));
            songs.Add(new Song("Purple Chase", "Hendryx", new DateTime(1992, 7, 11), Genre.ROCK));
        }
    }
}
