
namespace MusicCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing default
            Console.WriteLine("Test of default. ");
            Music song1 = new Music();
            Console.WriteLine(song1);

            Console.WriteLine(" ");

            // Testing overload 
            Console.WriteLine("Test of overload. ");
            Music song2 = new Music("Rocketman", "Elton John", 281);
            Console.WriteLine(song2);

            Console.WriteLine(" ");

            Classical song3 = new Classical("24 Prelude Op. 28", "Frederic Chopin", 2700, "Piano Sonata");
            Console.WriteLine(song3);

            Console.WriteLine(" ");

            NonClassical song4 = new NonClassical("Uptown Girl", "Billy Joel", 198, 1983);
            Console.WriteLine(song4);

            Console.WriteLine(" ");

            Pop song5 = new Pop("Billie Jean", "Michael Jackson", 294, 1982, "Thriller");
            Console.WriteLine(song5);


        } // end of Main
    } // end of class
} // end of namespace