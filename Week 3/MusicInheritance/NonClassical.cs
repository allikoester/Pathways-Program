namespace MusicCollection
{
    class NonClassical : Music
    {
        public int Year;
        public NonClassical(string songName, string artistName, int duration, int year) : base(songName, artistName, duration)
        {
            Year = year;
        }

        public override string ToString()
        {
            return base.ToString() + " the year the song was released was " + Year;
        }
    } // end class 

} // end namespace