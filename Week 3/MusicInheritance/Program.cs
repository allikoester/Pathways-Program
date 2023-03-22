// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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


        } // end of Main
    } // end of class
} // end of namespace