using System;
namespace Spotify.Entities
{
	public class Playlist
	{
        public Guid Id { get; set; }
        private List<Songs> Songs { get; set; }
        private Random random;

        public Playlist(Songs firstSong)
        {
            Id = Guid.NewGuid();
            Songs = new List<Songs>();//if we dont do this than Songs list will be null and we cant keep songs in null...
            random = new();
            AddSong(firstSong);
        }

        public void AddSong(Songs song)
        {
            if (song!=null)
            {
                Songs.Add(song);
            }
        }

        public string GetSongs()
        {
            return string.Join("\n", Songs.Select(x => $"{x.Title}-{x.Composer}"));
        }

        public void ShuffleSongs()
        {
            int count = Songs.Count;


            while (count > 0)
            {
                count--;
                Songs song = Songs[count];
                int randomIndex = random.Next(count);
                Songs[count] = Songs[randomIndex];
                Songs[randomIndex] = song;
            }
        }

       
    }
	
}

