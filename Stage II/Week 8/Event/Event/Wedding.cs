using System;

namespace Event
{
    public class Wedding : IEvent
    {
        public void Cost()
        {
            Console.WriteLine("How many will attend the wedding?");
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
            double cost = people * 50;
            Console.WriteLine($"The total cost is ${cost}.");
        }


    } // end class
} // end namespace