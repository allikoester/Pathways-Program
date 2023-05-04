/*
Developer Name: Alli Koester
Last Update: 3/21/23

Program: Class Music will hold music collection including song name, artist name, and duration of song in seconds. 
    Program will then put data in array to be manipulated by the user to open data, add infomration, update, and delete. 

Requirements: 
(1) Song name and artist names will be in strings
(2) Duration of songs will be in seconds as integers

*/

namespace MusicCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing default
            Console.WriteLine("Test of default. ");
            Music song1 = new Music();
            Console.WriteLine(song1.MusicSong);
            Console.WriteLine(song1.MusicArtist);
            Console.WriteLine(song1.MusicDuration);

            Console.WriteLine(" ");

            // Testing overload 
            Console.WriteLine("Test of overload. ");
            Music song2 = new Music("Rocketman", "Elton John", 281);
            Console.WriteLine(song2.MusicSong);
            Console.WriteLine(song2.MusicArtist);
            Console.WriteLine(song2.MusicDuration);

            Console.WriteLine(" ");

            Console.WriteLine("Test of Array. ");
            // Initialize array of elements
            Music[] musicArray = new Music[25];

            // Initialize each element of the array
            for (int i = 0; i < musicArray.Length; i++)
            {
                Music temp = new Music();
                musicArray[i] = temp;
            }

            // Print array
            foreach (Music song in musicArray)
            {
                if (song.MusicSong != " ")
                {
                    Console.WriteLine(song.MusicSong);
                    Console.WriteLine(song.MusicArtist);
                    Console.WriteLine(song.MusicDuration);
                }
            }

            Console.WriteLine(" ");

            // Test the get/set
            Console.WriteLine("Test of get and set. ");
            musicArray[5].MusicSong = "Rocketman";
            musicArray[5].MusicArtist = "Elton John";
            musicArray[5].MusicDuration = 281;

            musicArray[7].MusicSong = "Uptown Girl";
            musicArray[7].MusicArtist = "Billy Joel";
            musicArray[7].MusicDuration = 198;

            foreach (Music song in musicArray)
            {
                if (song.MusicSong != " ")
                {
                    Console.WriteLine(song);
                }
            }

            Console.WriteLine(" ");

            // Update element in array 
            Console.WriteLine("Press 'y' to update an entry. Any other key to continue. ");
            string userResponse = Console.ReadLine();
            if ((userResponse == "y") || (userResponse == "Y"))
            {
                Console.WriteLine("Please enter name of song to update. ");
                string? songEntered = Console.ReadLine();
                bool foundOne = false;

                foreach (Music song in musicArray)
                {
                    if (song.MusicSong.ToUpper().Trim() == songEntered.ToUpper().Trim())
                    {
                        Console.WriteLine("What would you like to change name to? ");
                        string? songUpdated = Console.ReadLine();
                        song.MusicSong = songUpdated;

                        Console.WriteLine("Press 'y' to update song artist. Any other key to continue. ");
                        userResponse = Console.ReadLine();
                        if ((userResponse == "y") || (userResponse == "Y"))
                        {
                            Console.WriteLine("Please enter updated artist name. ");
                            string? artistUpdated = Console.ReadLine();
                            song.MusicArtist = artistUpdated;
                        }

                        Console.WriteLine("Press 'y' to update song duration. Any other key to continue. ");
                        userResponse = Console.ReadLine();
                        if ((userResponse == "y") || (userResponse == "Y"))
                        {
                            Console.WriteLine("Please enter updated song duration. ");
                            int durationUpdated = Convert.ToInt32(Console.ReadLine());
                            song.MusicDuration = durationUpdated;
                        }
                        foundOne = true;
                        break;
                    }
                }
                if (!foundOne)
                {
                    Console.WriteLine("Name of song was not found. ");
                }
                foreach (Music song in musicArray)
                {
                    if (song.MusicSong != " ")
                    {
                        Console.WriteLine(song);
                    }
                }
            }

            Console.WriteLine(" ");

            // Delete element in array 
            Console.WriteLine("Press 'y' to delete an entry. Any other key to continue. ");
            userResponse = Console.ReadLine();
            if ((userResponse == "y") || (userResponse == "Y"))
            {
                Console.WriteLine("Please enter name of song to delete. ");
                string? songEntered = Console.ReadLine();
                bool foundOne = false;

                foreach (Music song in musicArray)
                {
                    if (song.MusicSong.ToUpper().Trim() == songEntered.ToUpper().Trim())
                    {
                        song.MusicSong = string.Empty;
                        song.MusicArtist = string.Empty;
                        song.MusicDuration = -1;

                        foundOne = true;
                        break;
                    }
                }
                if (!foundOne)
                {
                    Console.WriteLine("Name of song was not found. ");
                }
                foreach (Music song in musicArray)
                {
                    if (song.MusicSong != " ")
                    {
                        Console.WriteLine(song);
                    }
                }
            }

        } // end Main
    } // end class
} // end namespace