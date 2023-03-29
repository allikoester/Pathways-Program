/*

Developer Name: Alli Koester
Last Update 3/27/23

Program: Program will store health information from user including name, birthdate, health conditions, 
    medications, allergies, previous surgeries, and family history. 

*/

namespace HealthRecord

{
    class Program
    {
        static void Main(string[] args)
        {

            Patient patient1 = new Patient("Alli", "Koester", "August", 22, 1991);
            Console.WriteLine(patient1);


        } // end Main
    } // end class
} // end namespace