namespace MusicCollection
{
    class Music
    {
        public string Song { get; set; }

        public string Artist { get; set; }

        public int Duration { get; set; }

        public Music()
        {
            Song = " ";
            Artist = " ";
            Duration = 0;
        }

        public Music(string songName, string artistName, int duration)
        {
            Song = songName;
            Artist = artistName;
            Duration = duration;
        }

        public override string ToString()
        {
            return "The song is " + Song + ", the artist is " + Artist + ", the duration is " + Duration + " seconds";
        }
    } // end class 
} // end namespace 