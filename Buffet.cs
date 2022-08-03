namespace HungryNinja;

class Buffet
{
    public List<Food> Menu;

    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            // Set Menu to a hard coded list of 7 or more Food objects you instantiate manually
            new Food("Cake", 350, false, true),
            new Food("Pad Thai", 1200, true, true),
            new Food("Taco Combo", 400, true, false),
            new Food("Paella", 600, false, false),
            new Food("Sandwich", 450, false, false),
            new Food("Ice cream", 450, false, true),
            new Food("Apples and Peanut Butter", 250, false, true)

        };
    }
    public Food Serve()
    {
        Random random = new Random();
        int randomNum = random.Next( 0, 8 );
        Food randomFood = Menu[ randomNum ];
        return( randomFood );
    }
}

