using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethods
{
    public class FordExplorerFactory : CarFactory
    {

        public override Car Create()
        {

            return new Car(
                color: "Red",
                brand: "Ford",
                model: "Explorer",
                year: 2026
            );

        }

    }
}