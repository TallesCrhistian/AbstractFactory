using AbstractFactory.Interfaces;

namespace AbstractFactory.Foods
{
    internal class Pizza : IFoodFactory
    {
        public string CreateFood()
        {
            return "Created Pizza";
        }
    }
}
