using AbstractFactory.Interfaces;

namespace AbstractFactory.Foods
{
    public class Sashimi : IFoodFactory
    {
        public string CreateFood()
        {
            return "Created Sashimi";
        }
    }
}
