using System;
using Spotify.Entities;
namespace Spotify.Services
{
	public class NotepadService
	{
		public void PlaylistToNotepad(Playlist playlist)
		{
            //saving to Notepad
            string directory = $@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlists";

			if (File.Exists(directory))
				Directory.CreateDirectory(directory);
			

			string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");

            File.WriteAllText(saveFile, playlist.GetSongs());
			Console.WriteLine("Data Succesfully saved to Notepad ");
		 
		}
	}
}

