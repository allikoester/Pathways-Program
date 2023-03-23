namespace MusicCollection
{
    class Pop : NonClassical
    {
        public string Album;
        public Pop(string songName, string artistName, int duration, int year, string album) : base(songName, artistName, duration, year)
        {
            Album = album;
        }

        public override string ToString()
        {
            return base.ToString() + ", the album name is " + Album;
        }
    } // end class 

} // end namespace