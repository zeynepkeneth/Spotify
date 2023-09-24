// See https://aka.ms/new-console-template for more information
using Spotify.Entities;
using Spotify.Services;

Console.WriteLine();

string currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;

var song1 = new Songs("Requiem K. 626", "W. A. Mozart", "Orchestre national de France ", null) ;
var song2 = new Songs("Sonata No.6 in F Major ","L. Beethoven ","Fazıl Say ","Warner Music");
var song3 = new Songs("Moonlight Sonata", "Ludwig van Beethoven", "Various Artists", "Classical Records");
var song4 = new Songs("The Four Seasons", "Antonio Vivaldi", "Chamber Orchestra", "Baroque Productions");
var song5 = new Songs("Symphony No. 9", "Ludwig van Beethoven", "Philharmonic Orchestra", "Classic Harmony Records");

var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);

Console.WriteLine("Before the suffle");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();

Console.WriteLine("After the suffle");
Console.WriteLine(playlist1.GetSongs());


NotepadService notepadService = new();
notepadService.PlaylistToNotepad(playlist1);
