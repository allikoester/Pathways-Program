namespace MusicCollection
{
    class Classical : Music
    {
        public string Genre;
        public Classical(string songName, string artistName, int duration, string genre) : base(songName, artistName, duration)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            return base.ToString() + " the genre is " + Genre;
        }
    } // end class 

} // end namespace