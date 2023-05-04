using System;

namespace Event
{
    public class Retirement : IEvent
    {
        public void Cost()
        {
            Console.WriteLine("How many will attend the retirement party?");
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
            double cost = people * 25;
            Console.WriteLine($"The total cost is ${cost}.");
        }


    } // end class
} // end namespace