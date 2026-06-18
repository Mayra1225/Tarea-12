using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethods
{
    public class FordMustangFactory : CarFactory
    {

        public override Car Create()
        {

            return new Car(
                color: "Red",
                brand: "Ford",
                model: "Mustang",
                year: 2026
            );

        }

    }
}