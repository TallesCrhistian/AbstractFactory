using AbstractFactory.Interfaces;

namespace AbstractFactory.Restaurantes
{
    public class JapanRestaurant : IRestaurantFactory
    {
        public string CreateRestaurant()
        {
            return "Created Japan restaurant";
        }
    }
}
