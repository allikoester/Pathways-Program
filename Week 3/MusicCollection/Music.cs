class Music
{
    public string MusicSong
    { get; set; }

    public string MusicArtist
    { get; set; }

    public int MusicDuration
    { get; set; }

    public Music()
    {
        MusicSong = " ";
        MusicArtist = " ";
        MusicDuration = 0;
    }

    public Music(string songName, string artistName, int duration)
    {
        MusicSong = songName;
        MusicArtist = artistName;
        MusicDuration = duration;
    }

    public override string ToString()
    {
        return "The song is " + MusicSong + ", the artist is " + MusicArtist + ", and the duration is " + MusicDuration + " seconds. ";
    }
}
