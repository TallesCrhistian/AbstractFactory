using AbstractFactory.Foods;
using AbstractFactory.Interfaces;
using AbstractFactory.Restaurantes;

IRestaurantFactory iRestaurantFactory = null;
IFoodFactory iFoodFactory = null;

Console.WriteLine("Enter the type of Restaurant: ");

string restaurant = Console.ReadLine();

switch (restaurant)
{
    case "Japan":

        iRestaurantFactory = new JapanRestaurant();

        break;

    case "Italian":

        iRestaurantFactory = new ItalianRestaurant();

        break;

    default:

        Console.WriteLine("Type not supported!");

        break;
}

Console.WriteLine("Enter the name of Food: ");

string food = Console.ReadLine();

switch (food)
{
    case "Pizza":

        iFoodFactory = new Pizza();

        break;

    case "Sashimi":

        iFoodFactory = new Sashimi();

        break;

    default:

        Console.WriteLine("Type not supported!"v);

        break;
}

if (iRestaurantFactory is not null)
{
    var createdRestaurant = iRestaurantFactory.CreateRestaurant();
    Console.WriteLine(createdRestaurant);
}
else
{
    Console.WriteLine("No Created Restaurant!");
}

if (iFoodFactory is not null)
{
    var createdFood = iFoodFactory.CreateFood();
    Console.WriteLine(createdFood);
}
else
{
    Console.WriteLine("No Created Food!");
}