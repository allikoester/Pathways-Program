class Restaurant
{
    public string RestaurantName
    { get; set; }
    public int RestaurantRating
    { get; set; }

    public Restaurant()
    {
        RestaurantName = " ";
        RestaurantRating = 0;
    }

    public Restaurant(string newName, int newRating)
    {
        RestaurantName = newName;
        RestaurantRating = newRating;
    }

    public override string ToString()
    {
        return "The name of the restaurant is " + RestaurantName + " and the rating is " + RestaurantRating;
    }
}