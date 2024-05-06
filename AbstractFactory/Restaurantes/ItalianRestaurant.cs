using AbstractFactory.Interfaces;

namespace AbstractFactory.Restaurantes
{
    internal class ItalianRestaurant : IRestaurantFactory
    {
        public string CreateRestaurant()
        {
            return "Created Italian restaurant";
        }
    }
}
