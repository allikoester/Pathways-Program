namespace RestaurantApp
{
    class Burgers : Restaurant
    {
        public string bestBurger;
        public Burgers(string restaurantName, int restaurantRating, string burgerName) : base(restaurantName, restaurantRating)
        {
            bestBurger = burgerName;
        }

        public override string ToString()
        {
            return base.ToString() + ", and the best burger is " + bestBurger;
        }


    } // end class
}