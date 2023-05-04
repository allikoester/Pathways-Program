using System;

namespace Event
{
    public class Graduation : IEvent
    {
        public void Cost()
        {
            Console.WriteLine("How many will attend the graduation party?");
            string peopleS = Console.ReadLine();
            int people = 0;
            while (!int.TryParse(peopleS, out people))
            {
                Console.WriteLine("Not a valid input. ");
                peopleS = Console.ReadLine();
            }
            CalculateCost(people);
        }

        private void CalculateCost(int people)
        {
            double cost = people * 15;
            Console.WriteLine($"The total cost is ${cost}.");
        }


    } // end class
} // end namespace